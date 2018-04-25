using System;
using Hosts.Editor.Domain;
using Hosts.Editor.Windows;

namespace Hosts.Editor.Presenters
{
    public class MainPresenter
    {
        public MainPresenter(IMainView view)
        {
            View = view ?? throw new ArgumentNullException(nameof(view));
        }

        protected IMainView View { get; }

        public void Initialize()
        {
            View.Content = HostsFile.DefaultLocation;
        }
    }
}