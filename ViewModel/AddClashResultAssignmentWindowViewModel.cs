using System;
using System.Windows.Input;

namespace NavisworksReport
{
    public class AddClashResultAssignmentWindowViewModel : ModelBase
    {
        public Action CloseAction { get; set; }

        private string assignedTo;
        public string AssignedTo
        {
            get
            {
                return assignedTo;
            }
            set
            {
                assignedTo = value;
                OnPropertyChanged("AssignedTo");
            }
        }

        private string comment = string.Empty;
        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
                OnPropertyChanged("Comment");
            }
        }

        public ICommand Ok => new RelayCommandWithoutParameter(OnOk);
        private void OnOk()
        {
            CloseAction();
        }

        public ICommand Cancel => new RelayCommandWithoutParameter(OnCancel);
        private void OnCancel()
        {
            AssignedTo = string.Empty;
            Comment = string.Empty;
            CloseAction();
        }
    }
}
