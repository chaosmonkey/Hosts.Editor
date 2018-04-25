using System;
using System.Windows.Forms;
using ChaosMonkey.Guards;
using Hosts.Editor.Domain;
using Hosts.Editor.Windows;

namespace Hosts.Editor.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        public MainPresenter(IMainView view, IHostsFile hosts)
        {
            Guard.IsNotNull(view, nameof(view));
            Guard.IsNotNull(hosts, nameof(hosts));
            View = view ?? throw new ArgumentNullException(nameof(view));
            Hosts = hosts;
        }

        protected IMainView View { get; }

        protected IHostsFile Hosts { get; }

        public  string DefaultTitle = "Hosts Editor";

        public void Initialize()
        {
            if (Hosts.CheckIfDefaultFileExists())
            {
                Hosts.LoadFromDefaultLocation();
            }
            View.Content = Hosts.Content;
        }

        public void Save()
        {
            Hosts.Content = View.Content;
            Hosts.SaveToDefaultLocation();
        }

        public void ContentChanged()
        {
            View.HasChanges = true;
        }
    }
}