using System.Windows.Forms;
using Hosts.Editor.Presenters;

namespace Hosts.Editor.Windows
{
    public partial class MainWindow : Form, IMainView
    {
        public MainWindow()
        {
            InitializeComponent();
            Presenter = new MainPresenter(this);
        }

        protected MainPresenter Presenter { get; }

        public string Content
        {
            get => ContentTextBox.Text;
            set => ContentTextBox.Text = value;
        }

        private void MainWindow_Shown(object sender, System.EventArgs e)
        {
            Presenter.Initialize();
        }
    }
}
