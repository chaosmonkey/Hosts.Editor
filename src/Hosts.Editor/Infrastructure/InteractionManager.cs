using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosts.Editor.Infrastructure
{
    public class InteractionManager : IInteractionManager
    {
        public DialogResult ShowDialog(string title, string message, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, title, buttons, icon);
        }
    }
}
