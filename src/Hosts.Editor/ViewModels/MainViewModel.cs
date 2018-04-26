namespace Hosts.Editor.ViewModels
{
    public class MainViewModel : Bindable
    {
        private const string DefaultWindowTitle = "Hosts Editor";
        private string _content;
        private bool _hasChanges;

        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                if (Set(ref _content, value))
                {
                    HasChanges = true;
                }
            }
        }
        
        public bool HasChanges
        {
            get
            {
                return _hasChanges;
            }
            set
            {
                if (Set(ref _hasChanges, value))
                {
                    OnPropertyChanged("WindowText");
                }
            }
        }

        public string WindowText => (HasChanges) ? $"{DefaultWindowTitle} *" : DefaultWindowTitle;
    }
}