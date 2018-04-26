using ChaosMonkey.Guards;
using Hosts.Editor.Domain;
using Hosts.Editor.Infrastructure;
using Hosts.Editor.ViewModels;

namespace Hosts.Editor.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        public MainPresenter(IHostsFile hosts, IInteractionManager interactions)
        {
            Guard.IsNotNull(hosts, nameof(hosts));
            Guard.IsNotNull(interactions, nameof(interactions));
            Hosts = hosts;
            Interactions = interactions;
            Model = new MainViewModel();
        }

        protected IHostsFile Hosts { get; }

        protected IInteractionManager Interactions { get; }

        public MainViewModel Model { get; set; }

        public void Initialize()
        {
            if (Hosts.DefaultFileExists)
            {
                Hosts.LoadFromDefaultLocation();
            }
            Model.Content = Hosts.Content;
            Model.HasChanges = false;
        }

        public void Save()
        {
            Hosts.Content = Model.Content;
            Hosts.SaveToDefaultLocation();
            Model.HasChanges = false;
        }

        public bool Close()
        {
            bool allowClose = true;
            if (Model.HasChanges)
            {
                var result = Interactions.ShowDialog("Pending Changes", "You have pending, unsaved changes.  Would you like to save them?", 
                                                                            System.Windows.Forms.MessageBoxIcon.Question, 
                                                                            System.Windows.Forms.MessageBoxButtons.YesNoCancel);
                if(result == System.Windows.Forms.DialogResult.Yes)
                {
                    Save();
                }
                allowClose = result != System.Windows.Forms.DialogResult.Cancel;
            }
            return allowClose;
        }
    }
}