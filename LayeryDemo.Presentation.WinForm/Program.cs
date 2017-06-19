using LayeryDemo.IoCContainer;
using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace LayeryDemo.Presentation.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = IoCMappingContainer.GetInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<frmMain>());
        }
    }
}
