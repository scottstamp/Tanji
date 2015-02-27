using System;
using System.Windows.Forms;
using System.Security.Principal;

using Sulakore.Communication;

namespace Tanji
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Eavesdropper.Terminate();

            #region Run As Administrator Check
            var windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                const string MustRunAsAdmin = "Tanji must be ran with administrative privileges; If you are not being prompted to run as admin, make sure your UAC settings are properly adjusted.";
                MessageBox.Show(MustRunAsAdmin, Tanji.Main.TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

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