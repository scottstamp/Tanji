using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

using Sulakore;

namespace Tanji.Dialogs
{
    public partial class TanjiUpdater : Form
    {
        public static Version LocalVersion { get; private set; }
        public static Version RemoteVersion { get; private set; }
        public static string ReleaseNotesUrl { get; private set; }

        private const string TANJI_INFO_PATH = "http://pastebin.com/raw.php?i=JyFQ2msW";
        private const string RELEASE_PREFIX = "https://github.com/ArachisH/Tanji/releases/tag/v";

        static TanjiUpdater()
        {
            LocalVersion = new Version(Application.ProductVersion);
        }
        public TanjiUpdater()
        {
            InitializeComponent();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void YesBtn_Click(object sender, EventArgs e)
        {
            Process.Start(ReleaseNotesUrl);
            NoBtn_Click(sender, e);
        }

        public bool UpdateFound()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    webClient.Proxy = null;
                    webClient.Headers["User-Agent"] = SKore.ChromeAgent;

                    string version = webClient.DownloadString(TANJI_INFO_PATH);
                    RemoteVersion = new Version(version.Split('_')[0]);

                    ReleaseNotesUrl = RELEASE_PREFIX + RemoteVersion.ToString();
                    VersionTxt.Text = "Version: " + RemoteVersion.ToString();

                    return RemoteVersion > LocalVersion;
                }
            }
            catch (WebException) { return false; }
        }
    }
}