using Hosts.Editor.ViewModels;

namespace Hosts.Editor.Presenters
{
    public interface IMainPresenter
    {
        MainViewModel Model { get; set; }

        void Initialize();
    }
}