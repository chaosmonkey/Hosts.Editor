using System.Windows.Forms;

namespace Hosts.Editor.Infrastructure
{
    public interface IInteractionManager
    {
        DialogResult ShowDialog(string title, string message, MessageBoxIcon icon = MessageBoxIcon.Asterisk, MessageBoxButtons buttons = MessageBoxButtons.OK);
    }
}