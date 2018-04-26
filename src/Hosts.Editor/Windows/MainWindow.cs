using System.Windows.Forms;
using ChaosMonkey.Guards;
using Hosts.Editor.Presenters;

namespace Hosts.Editor.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow(IMainPresenter presenter)
        {
            Guard.IsNotNull(presenter, nameof(presenter));
            InitializeComponent();

            Presenter = presenter;
            Bindings.DataSource = Presenter.Model;
        }

        protected IMainPresenter Presenter { get; }

        private void MainWindow_Shown(object sender, System.EventArgs e)
        {
            Presenter.Initialize();
        }

        private void FileSaveMenuItem_Click(object sender, System.EventArgs e)
        {
            Presenter.Save();
        }

        private void MainMenu_DropDownOpened(object sender, System.EventArgs e)
        {
            switch((sender as ToolStripMenuItem)?.Name)
            {
                case "FileMenuItem":
                    FileSaveMenuItem.Enabled = Presenter.Model.HasChanges;
                    break;
            }
        }
    }
}
