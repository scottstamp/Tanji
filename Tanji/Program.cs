using System;
using System.Windows.Forms;
using System.Security.Principal;

using Sulakore.Communication;

namespace Tanji
{
    static class Program
    {
        private const string MUST_RUN_AS_ADMIN
            = "Tanji must be ran with administrative privileges; If you are not being prompted to run as admin, make sure your UAC settings are properly adjusted.";

        [STAThread]
        static void Main(string[] args)
        {
            Eavesdropper.Terminate();

            var windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show(MUST_RUN_AS_ADMIN, "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool debugging = false;
            foreach (string command in args)
            {
                switch (command.Split(' ')[0])
                {
                    case "/debug": debugging = true; break;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(debugging));
        }
    }
}