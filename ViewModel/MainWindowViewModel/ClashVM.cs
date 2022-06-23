using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace NavisworksReport
{
    public partial class MainWindowViewModel : ModelBase
    {
        #region datagrid property

        public static readonly DependencyProperty ClashDataGridProperty = DependencyProperty
            .RegisterAttached("ClashDataGrid", typeof(DataGrid), typeof(MainWindowViewModel), new FrameworkPropertyMetadata(OnClashDataGridChanged));

        public static void SetClashDataGrid(DependencyObject element, DataGrid value)
        {
            element.SetValue(ClashDataGridProperty, value);
        }

        public static DataGrid GetClashDataGrid(DependencyObject element)
        {
            return (DataGrid)element.GetValue(ClashDataGridProperty);
        }

        private static DataGrid clashDataGrid = null;
        private static void OnClashDataGridChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            clashDataGrid = d as DataGrid;
        }

        #endregion

        private ObservableCollection<exchangeBatchtestClashtestClashresultsClashresult> clashResults;
        public ObservableCollection<exchangeBatchtestClashtestClashresultsClashresult> ClashResults
        {
            get
            {
                return clashResults;
            }
            set
            {
                clashResults = value;
                OnPropertyChanged("ClashResults");
            }
        }

        private exchangeBatchtestClashtestClashresultsClashresult selectedClashResult;
        public exchangeBatchtestClashtestClashresultsClashresult SelectedClashResult
        {
            get
            {
                return selectedClashResult;
            }
            set
            {
                selectedClashResult = value;
                OnPropertyChanged("SelectedClashResult");
            }
        }

        private List<string> clashResultStatuses = new List<string> { "Создать",
                                                                      "Активн.",
                                                                      "Исправлено",
                                                                      "Подтверждено",
                                                                      "Проанализировано"};
        public List<string> ClashResultStatuses
        {
            get
            {
                return clashResultStatuses;
            }
        }

        private bool selectionOfElementOneIsEnable;
        public bool SelectionOfElementOneIsEnable
        {
            get
            {
                return selectionOfElementOneIsEnable;
            }
            set
            {
                selectionOfElementOneIsEnable = value;
                OnPropertyChanged("SelectionOfElementOneIsEnable");
            }
        }

        private bool selectionOfElementTwoIsEnable;
        public bool SelectionOfElementTwoIsEnable
        {
            get
            {
                return selectionOfElementTwoIsEnable;
            }
            set
            {
                selectionOfElementTwoIsEnable = value;
                OnPropertyChanged("SelectionOfElementTwoIsEnable");
            }
        }

        private exchangeBatchtestClashtestClashresultsClashresultComment[] comments;
        public exchangeBatchtestClashtestClashresultsClashresultComment[] Comments
        {
            get
            {
                return comments;
            }
            set
            {
                comments = value;
                OnPropertyChanged("Comments");
            }
        }

        private exchangeBatchtestClashtestClashresultsClashresultComment selectedComment;
        public exchangeBatchtestClashtestClashresultsClashresultComment SelectedComment
        {
            get
            {
                return selectedComment;
            }
            set
            {
                selectedComment = value;
                OnPropertyChanged("SelectedComment");
            }
        }

        private double viewCubeSize = 2.001;
        public double ViewCubeSize
        {
            get
            {
                return viewCubeSize;
            }
            set
            {
                viewCubeSize = value;
                OnPropertyChanged("ViewCubeSize");
            }
        }

        public ICommand SelectedClashResultChanged => new RelayCommandWithoutParameter(OnSelectedClashResultChanged);
        private void OnSelectedClashResultChanged()

        {
            if (SelectedClashResult == null) return;
            if (SelectedClashResult.clashobjects?.Length > 0)
            {
                SelectionOfElementOneIsEnable = MainWindowModelService.Document.Title.Contains(
                Path.GetFileNameWithoutExtension(SelectedClashResult.clashobjects[0].pathlink[2]));
                if (SelectedClashResult.clashobjects?.Length > 1)
                {
                    SelectionOfElementTwoIsEnable = MainWindowModelService.Document.Title.Contains(
                        Path.GetFileNameWithoutExtension(SelectedClashResult.clashobjects[1].pathlink[2]));
                }
            }
            Comments = SelectedClashResult.comments;
        }

        public ICommand ClashResultStatusChanged => new RelayCommandWithoutParameter(OnClashResultStatusChanged);
        private void OnClashResultStatusChanged()
        {
            if (SelectedClashResult == null) return;
            MainWindowModelService.ClashResultStatusChanged(SelectedReport, SelectedClashResult);
            reportDataGrid.Items.Refresh();
            OnPropertyChanged("ReportSummaryClashInformation");
        }

        public ICommand AddClashResultAssignment => new RelayCommandWithoutParameter(OnAddClashResultAssignment);
        private void OnAddClashResultAssignment()
        {
            if (SelectedClashResult == null) return;
            MainWindowModelService.AddClashResultAssignment(SelectedClashResult);
            Comments = SelectedClashResult.comments;
            clashDataGrid.Items.Refresh();
        }

        public ICommand DeleteClashResultAssignment => new RelayCommandWithoutParameter(OnDeleteClashResultAssignment);
        private void OnDeleteClashResultAssignment()
        {
            if (SelectedClashResult == null) return;
            MainWindowModelService.DeleteClashResultAssignment(SelectedClashResult);
            Comments = SelectedClashResult.comments;
            clashDataGrid.Items.Refresh();
        }

        public ICommand SelectElementOne => new RelayCommandWithoutParameter(OnSelectElementOne);
        private void OnSelectElementOne()
        {
            if (SelectedClashResult == null) return;
            MainWindowModelService.SelectElement(SelectedClashResult.clashobjects[0]);
        }

        public ICommand SelectElementTwo => new RelayCommandWithoutParameter(OnSelectElementTwo);
        private void OnSelectElementTwo()
        {
            if (SelectedClashResult == null) return;
            MainWindowModelService.SelectElement(SelectedClashResult.clashobjects[1]);
        }

        public ICommand AddComment => new RelayCommandWithoutParameter(OnAddComment);
        private void OnAddComment()
        {
            if (SelectedClashResult == null) return;
            MainWindowModelService.AddComment(SelectedClashResult);
            Comments = SelectedClashResult.comments;
            clashDataGrid.Items.Refresh();
        }

        public ICommand DeleteComment => new RelayCommandWithoutParameter(OnDeleteComment);
        private void OnDeleteComment()
        {
            if (SelectedComment == null) return;
            SelectedClashResult.comments = Comments.Where(x => x.id != selectedComment.id).ToArray();
            Comments = SelectedClashResult.comments;
            clashDataGrid.Items.Refresh();
        }

        public ICommand FocusClashResultPoint => new RelayCommandWithoutParameter(OnFocusClashResultPoint);
        private void OnFocusClashResultPoint()
        {
            if (selectedClashResult == null) return;
            MainWindowModelService.FocusClashResultPoint(SelectedClashResult, ViewCubeSize);
        }
    }

    public class CreatedDateToDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IFormatProvider dateTimeCulture = new CultureInfo("ru-Ru", true);
            if (value is exchangeBatchtestClashtestClashresultsClashresultCreateddate)
            {
                exchangeBatchtestClashtestClashresultsClashresultCreateddateDate 
                    date = ((exchangeBatchtestClashtestClashresultsClashresultCreateddate)value).date;
                DateTime dateTime = new DateTime(date.year, date.month, 
                    date.day, date.hour, date.minute, date.second).AddHours(3);
                return dateTime.ToString("G", dateTimeCulture);
            }
            else if (value is exchangeBatchtestClashtestClashresultsClashresultCommentCreateddate)
            {
                exchangeBatchtestClashtestClashresultsClashresultCommentCreateddateDate 
                    date = ((exchangeBatchtestClashtestClashresultsClashresultCommentCreateddate)value).date;
                DateTime dateTime = new DateTime(date.year, date.month, 
                    date.day, date.hour, date.minute, date.second).AddHours(3);
                return dateTime.ToString("G", dateTimeCulture);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class FileNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string fileName = (string)value;
            return Path.GetFileNameWithoutExtension(fileName);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
