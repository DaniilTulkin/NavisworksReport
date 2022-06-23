using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using System;

namespace NavisworksReport.Model
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class NavisworksReport : IExternalEventHandler
    {
        public void Execute(UIApplication app)
        {
            try
            {
                MainWindow mainWindow = new MainWindow(app);
                mainWindow.Show();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: Failed to run main window of the plugin.\n{ex.Message}");
            }
        }

        public string GetName() => nameof(NavisworksReport);
    }
}
