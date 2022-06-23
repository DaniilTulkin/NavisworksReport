using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace NavisworksReport
{
    public partial class MainWindowModelService
    {
        private const string NameOf3DView = "Обработка коллизий";

        internal ObservableCollection<exchangeBatchtestClashtestClashresultsClashresult> ClashResults(exchangeBatchtestClashtest selectedReport)
        {
            ObservableCollection<exchangeBatchtestClashtestClashresultsClashresult> clashresults =
                new ObservableCollection<exchangeBatchtestClashtestClashresultsClashresult>();
            foreach (exchangeBatchtestClashtestClashresultsClashresult clashresult in selectedReport.clashresults.clashresult 
                ?? new exchangeBatchtestClashtestClashresultsClashresult[0])
                clashresults.Add(clashresult);

            return clashresults;
        }

        internal void ClashResultStatusChanged(exchangeBatchtestClashtest selectedReport, 
                                               exchangeBatchtestClashtestClashresultsClashresult selectedClashResult)
        {
            var newStatus = ClashResultStatusHelper.ToEng(selectedClashResult.resultstatus);
            var oldStatus = selectedClashResult.status;

            selectedClashResult.status = newStatus;

            var newStatusProperty = selectedReport.summary.GetType().GetProperty(newStatus);
            var newValue = (int)newStatusProperty.GetValue(selectedReport.summary, null) + 1;
            newStatusProperty.SetValue(selectedReport.summary, newValue);

            var oldStatusProperty = selectedReport.summary.GetType().GetProperty(oldStatus);
            var oldValue = (int)oldStatusProperty.GetValue(selectedReport.summary, null) - 1;
            oldStatusProperty.SetValue(selectedReport.summary, oldValue);
        }

        internal void AddClashResultAssignment(exchangeBatchtestClashtestClashresultsClashresult selectedClashResult)
        {
            using (AddClashResultAssignmentWindow window = new AddClashResultAssignmentWindow())
            {
                window.ShowDialog();
                string strAssignedTo = window.viewModel.AssignedTo;
                string strComment = window.viewModel.Comment;
                if (!string.IsNullOrEmpty(strAssignedTo))
                {
                    selectedClashResult.assignedto = strAssignedTo;
                    CreateComment(selectedClashResult,
                                  $"Назначено для {strAssignedTo}\n___________________________________\n{strComment}");
                }
            }
        }

        internal void DeleteClashResultAssignment(exchangeBatchtestClashtestClashresultsClashresult selectedClashResult)
        {
            selectedClashResult.assignedto = null;
            CreateComment(selectedClashResult, "Не назначено");
        }

        internal void SelectElement(exchangeBatchtestClashtestClashresultsClashresultClashobject clashobject)
        {
            ElementId id = new ElementId((int)(clashobject.objectattribute.value));
            uidoc.Selection.SetElementIds(new Collection<ElementId> { id });
        }

        internal void AddComment(exchangeBatchtestClashtestClashresultsClashresult selectedClashResult)
        {
            using (AddCommentWindow window = new AddCommentWindow())
            {
                window.ShowDialog();
                string strComment = window.viewModel.Comment;
                if (!string.IsNullOrEmpty(strComment))
                {
                    CreateComment(selectedClashResult ,strComment);
                }
            }
        }

        internal void FocusClashResultPoint(exchangeBatchtestClashtestClashresultsClashresult selectedClashResult, double viewCubeSize)
        {
            revitEvent.Run(app => 
            { 
                View3D view3D = new FilteredElementCollector(doc)
                                    .OfClass(typeof(View3D))
                                    .WhereElementIsNotElementType()
                                    .Cast<View3D>()
                                    .Where(x => x.Name == NameOf3DView)
                                    .FirstOrDefault();

                if (view3D == null)
                {
                    ViewFamilyType viewFamilyType = new FilteredElementCollector(doc)
                                                        .OfClass(typeof(ViewFamilyType))
                                                        .Cast<ViewFamilyType>()
                                                        .Where(x => x.ViewFamily == ViewFamily.ThreeDimensional)
                                                        .FirstOrDefault();

                    using (Transaction t = new Transaction(doc, "Созание 3D вида"))
                    {
                        t.Start();

                        view3D = View3D.CreateIsometric(doc, viewFamilyType.Id);
                        view3D.Name = NameOf3DView;
                        view3D.DetailLevel = ViewDetailLevel.Fine;
                        view3D.DisplayStyle = DisplayStyle.FlatColors;

                        t.Commit();
                    }
                }

                exchangeBatchtestClashtestClashresultsClashresultClashpointPos3f
                    clashPoint = selectedClashResult.clashpoint.pos3f;
                double X = UnitUtils.ConvertToInternalUnits(clashPoint.x, DisplayUnitType.DUT_METERS);
                double Y = UnitUtils.ConvertToInternalUnits(clashPoint.y, DisplayUnitType.DUT_METERS);
                double Z = UnitUtils.ConvertToInternalUnits(clashPoint.z, DisplayUnitType.DUT_METERS);

                BasePoint bp = new FilteredElementCollector(doc)
                             .OfClass(typeof(BasePoint))
                             .OfCategory(BuiltInCategory.OST_ProjectBasePoint)
                             .Cast<BasePoint>()
                             .FirstOrDefault();
                XYZ bpCoor = bp.SharedPosition;
                double bpAngle = bp.get_Parameter(BuiltInParameter.BASEPOINT_ANGLETON_PARAM).AsDouble();

                XYZ eyePosition = new XYZ((X - bpCoor.X) * Math.Cos(bpAngle) - (Y - bpCoor.Y) * Math.Sin(bpAngle),
                                          (X - bpCoor.X) * Math.Sin(bpAngle) + (Y - bpCoor.Y) * Math.Cos(bpAngle),
                                           Z - bpCoor.Z);
                XYZ upDirection = view3D.GetOrientation().UpDirection;
                XYZ forwardDirection = view3D.GetOrientation().ForwardDirection;
                ViewOrientation3D viewOrientation3D = new ViewOrientation3D(eyePosition, upDirection, forwardDirection);

                double d = UnitUtils.ConvertToInternalUnits(viewCubeSize, DisplayUnitType.DUT_METERS);
                Transform transform = Transform.Identity;
                transform.Origin = eyePosition;

                BoundingBoxXYZ boundingBoxXYZ = new BoundingBoxXYZ();
                boundingBoxXYZ.Transform = transform;
                boundingBoxXYZ.Min = new XYZ(-d, -d, -d);
                boundingBoxXYZ.Max = new XYZ(d, d, d);

                using (Transaction t = new Transaction(doc, "Установка границ 3D вида"))
                {
                    t.Start();

                    view3D.SetOrientation(viewOrientation3D);
                    view3D.SetSectionBox(boundingBoxXYZ);
                    view3D.IsSectionBoxActive = true;

                    t.Commit();
                }

                uidoc.ActiveView = view3D;
            });
        }

        private static void CreateComment(exchangeBatchtestClashtestClashresultsClashresult selectedClashResult,
                                                                                              string strComment)
        {
            DateTime dateTime = DateTime.Now.AddHours(-3);
            var comment = new exchangeBatchtestClashtestClashresultsClashresultComment
            {
                id = new Random().Next(100000, 999999),
                status = "new",
                user = Environment.UserName,
                body = strComment,
                createddate = new exchangeBatchtestClashtestClashresultsClashresultCommentCreateddate
                {
                    date = new exchangeBatchtestClashtestClashresultsClashresultCommentCreateddateDate
                    {
                        year = dateTime.Year,
                        month = dateTime.Month,
                        day = dateTime.Day,
                        hour = dateTime.Hour,
                        minute = dateTime.Minute,
                        second = dateTime.Second
                    }
                }
            };

            var list = new List<exchangeBatchtestClashtestClashresultsClashresultComment>();
            if (selectedClashResult.comments == null)
            {
                list.Add(comment);
                selectedClashResult.comments = list.ToArray();
                return;
            }
            foreach (var commentInArray in selectedClashResult.comments) list.Add(commentInArray);
            list.Add(comment);
            selectedClashResult.comments = list.ToArray();
        }
    }
}
