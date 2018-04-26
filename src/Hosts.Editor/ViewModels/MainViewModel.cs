namespace Hosts.Editor.ViewModels
{
    public class MainViewModel : Bindable
    {
        private string _content;

        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                Set(ref _content, value); 
            }
        }

        public bool CanSave { get; set; }

        public bool HasChanges { get; set; }
    }
}