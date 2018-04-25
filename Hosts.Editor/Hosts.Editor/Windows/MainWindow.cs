using System.Windows.Forms;
using Hosts.Editor.Domain;
using Hosts.Editor.Presenters;

namespace Hosts.Editor.Windows
{
    public partial class MainWindow : Form, IMainView
    {
        public MainWindow()
        {
            InitializeComponent();
            Presenter = new MainPresenter(this, new HostsFile(new FileManager()));
        }

        protected IMainPresenter Presenter { get; }

        public string Content
        {
            get => ContentTextBox.Text;
            set => ContentTextBox.Text = value;
        }

        private bool _hasChanges = false;
        public bool HasChanges
        {
            get
            {
                return _hasChanges;
            }
            set
            {
                _hasChanges = value;
                FileSaveMenuItem.Enabled = _hasChanges;
                Text = 
            }
        }

        private void MainWindow_Shown(object sender, System.EventArgs e)
        {
            Presenter.Initialize();
        }

        private void FileSaveMenuItem_Click(object sender, System.EventArgs e)
        {
            Presenter.Save();
        }
    }
}
