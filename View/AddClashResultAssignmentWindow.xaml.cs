using System;
using System.Windows;
using System.Windows.Input;

namespace NavisworksReport
{
    /// <summary>
    /// Interaction logic for AddCommentWindow.xaml
    /// </summary>
    public partial class AddClashResultAssignmentWindow : Window, IDisposable
    {
        public AddClashResultAssignmentWindowViewModel viewModel;
        public AddClashResultAssignmentWindow()
        {
            InitializeComponent();
            viewModel = new AddClashResultAssignmentWindowViewModel();
            DataContext = viewModel;

            if (viewModel.CloseAction == null) viewModel.CloseAction = new Action(this.Close);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        public void Dispose()
        {

        }
    }
}
