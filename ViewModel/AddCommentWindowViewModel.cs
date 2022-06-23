using System;
using System.Windows.Input;

namespace NavisworksReport
{
    public class AddCommentWindowViewModel : ModelBase
    {
        public Action CloseAction { get; set; }

        private string comment;
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
            Comment = string.Empty;
            CloseAction();
        }
    }
}
