using Autodesk.Revit.UI;
using System;
using System.Windows.Input;

namespace NavisworksReport
{
    public partial class MainWindowViewModel : ModelBase
    {
        public Action CloseAction { get; set; }

        private MainWindowModelService MainWindowModelService;

        public MainWindowViewModel(UIApplication app)
        {
            MainWindowModelService = new MainWindowModelService(app);
        }

        public ICommand Ok => new RelayCommandWithoutParameter(OnOk);
        private void OnOk()
        {
            CloseAction();
        }

        public ICommand Cancel => new RelayCommandWithoutParameter(OnCancel);
        private void OnCancel()
        {
            CloseAction();
        }
    }
}
