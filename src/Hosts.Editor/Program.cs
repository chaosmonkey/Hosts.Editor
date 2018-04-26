using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hosts.Editor.Infrastructure;
using Hosts.Editor.Windows;

namespace Hosts.Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var resolver = new DependencyResolver();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var window = resolver.Resolve<MainWindow>();
            Application.Run(window);
        }
    }
}
