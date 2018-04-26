using ChaosMonkey.Guards;
using Hosts.Editor.Domain;
using Hosts.Editor.ViewModels;

namespace Hosts.Editor.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        public MainPresenter(IHostsFile hosts)
        {
            Guard.IsNotNull(hosts, nameof(hosts));
            Hosts = hosts;
            Model = new MainViewModel();
        }

        protected IHostsFile Hosts { get; }

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
            Hosts.SaveToDefaultLocation();
            Model.HasChanges = false;
        }
    }
}