using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;

namespace NavisworksReport
{
    public partial class MainWindowModelService
    {
        private UIApplication app;
        private UIDocument uidoc;
        private Document doc;
        private RevitEvent revitEvent;

        public Document Document
        {
            get
            {
                return doc;
            }
        }

        public MainWindowModelService(UIApplication app)
        {
            this.app = app;
            uidoc = app.ActiveUIDocument;
            doc = uidoc.Document;
            revitEvent = new RevitEvent();
        }
    }
}
