using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

using Sulakore;

namespace Tanji.Dialogs
{
    public partial class TanjiUpdater : Form
    {
        private Version _remoteVers;
        private string _downloadPath;

        private readonly Version _localVers;

        private const string AppInfoPath = "http://pastebin.com/raw.php?i=JyFQ2msW";

        public TanjiUpdater()
        {
            InitializeComponent();

            _localVers = new Version(Application.ProductVersion);
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void YesBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                using (var webClient = new WebClient())
                {

                    string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + Path.GetFileName(Uri.UnescapeDataString(_downloadPath.Replace('+', ' ')));
                    webClient.DownloadFile(_downloadPath, fileName);
                }
            }
            catch (WebException)
            {
                const string DownloadFailed = "Unable to download the newest version of Tanji; Would you like to open up the webpage containing the download?";
                if (MessageBox.Show(DownloadFailed, Main.TanjiError, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    DetailsBtn_Click(sender, e);
            }
            finally
            {
                Cursor = Cursors.Default;
                Close();
            }
        }
        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            const string DBTanjiThread = "http://arachish.github.io/Tanji/";
            Process.Start(DBTanjiThread);
        }

        public bool UpdateFound()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    webClient.Proxy = null;
                    webClient.Headers["User-Agent"] = SKore.ChromeAgent;
                    string[] info = webClient.DownloadString(AppInfoPath).Split('_');
                    _remoteVers = new Version(info[0]);
                    _downloadPath = info[1];

                    return _remoteVers > _localVers;
                }
            }
            catch (WebException) { return false; }
        }
    }
}