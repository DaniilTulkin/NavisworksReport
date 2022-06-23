using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NavisworksReport
{
    public partial class MainWindowViewModel : ModelBase
    {
        #region datagrid property

        public static readonly DependencyProperty ReportDataGridProperty = DependencyProperty
            .RegisterAttached("ReportDataGrid", typeof(DataGrid), typeof(MainWindowViewModel), new FrameworkPropertyMetadata(OnReportDataGridChanged));

        public static void SetReportDataGrid(DependencyObject element, DataGrid value)
        {
            element.SetValue(ReportDataGridProperty, value);
        }

        public static DataGrid GetReportDataGrid(DependencyObject element)
        {
            return (DataGrid)element.GetValue(ReportDataGridProperty);
        }

        private static DataGrid reportDataGrid = null;
        private static void OnReportDataGridChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            reportDataGrid = d as DataGrid;
        }

        #endregion

        private ObservableCollection<exchangeBatchtestClashtest> reports;
        public ObservableCollection<exchangeBatchtestClashtest> Reports
        {
            get
            {
                return reports;
            }
            set
            {
                reports = value;
                OnPropertyChanged("Reports");
            }
        }

        private exchangeBatchtestClashtest selectedReport;
        public exchangeBatchtestClashtest SelectedReport
        {
            get
            {
                return selectedReport;
            }
            set
            {
                selectedReport = value;
                OnPropertyChanged("SelectedReport");
                OnPropertyChanged("ReportSummaryClashInformation");
            }
        }

        private string selectedReportName = "Нет текущей проверки";
        public string SelectedReportName
        {
            get
            {
                return selectedReportName;
            }
            set
            {
                selectedReportName = value;
                OnPropertyChanged("SelectedReportName");
            }
        }

        private string lastExecution;
        public string LastExecution
        {
            get
            {
                return lastExecution;
            }
            set
            {
                lastExecution = value;
                OnPropertyChanged("LastExecution");
            }
        }

        private string reportSummaryClashInformation;
        public string ReportSummaryClashInformation
        {
            get
            {
                int i0 = 0, i1 = 0, i2 = 0;
                if (SelectedReport != null)
                {
                    i0 = SelectedReport.summary.total;
                    i1 = SelectedReport.summary.total - SelectedReport.summary.approved - SelectedReport.summary.resolved;
                    i2 = SelectedReport.summary.approved + SelectedReport.summary.resolved;
                }

                reportSummaryClashInformation = $"Конфликты - Всего: {i0} (открытые: {i1} закрытые: {i2})";
                return reportSummaryClashInformation;
            }
            set
            {
                reportSummaryClashInformation = value;
                OnPropertyChanged("ReportSummaryClashInformation");
            }
        }

        private List<string> uploadOptions = new List<string> { "Текущая проверка", "Все проверки"};
        public List<string> UploadOptions
        {
            get
            {
                return uploadOptions;
            }
        }

        private string selectedUploadOption = "Текущая проверка";
        public string SelectedUploadOption
        {
            get
            {
                return selectedUploadOption;
            }
            set
            {
                selectedUploadOption = value;
                OnPropertyChanged("SelectedUploadOption");
            }
        }

        public ICommand LoadReport => new RelayCommandWithoutParameter(OnLoadReport);
        private void OnLoadReport()
        {
            Reports = MainWindowModelService.LoadReport(Reports);
        }

        public ICommand UploadReport => new RelayCommandWithoutParameter(OnUploadReport);
        private void OnUploadReport()
        {
            MainWindowModelService.UploadReport(Reports, SelectedReport, SelectedUploadOption);
        }

        public ICommand DeleteReport => new RelayCommandWithoutParameter(OnDeleteReport);
        private void OnDeleteReport()
        {
            if (SelectedReport == null) return;
            Reports.Remove(SelectedReport);
        }

        public ICommand SelectedReportChanged => new RelayCommandWithoutParameter(OnSelectedReportChanged);
        private void OnSelectedReportChanged()
        
        {
            if (SelectedReport == null) return;
            SelectedReportName = SelectedReport.name;
            LastExecution = MainWindowModelService.LastExecution(SelectedReport);
            ClashResults = MainWindowModelService.ClashResults(SelectedReport);
        }
    }
}
