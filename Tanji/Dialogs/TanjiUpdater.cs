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

        public const string TANJI_PAGE = "http://arachish.github.io/Tanji/";
        public const string RELEASE_PAGE = "https://github.com/ArachisH/Tanji/releases/";

        private const string TANJI_INFO_PATH = "http://pastebin.com/raw.php?i=JyFQ2msW";

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

                    ReleaseNotesUrl = RELEASE_PAGE + "tag/v" + RemoteVersion.ToString();
                    VersionTxt.Text = "Version: " + RemoteVersion.ToString();

                    return RemoteVersion > LocalVersion;
                }
            }
            catch (WebException) { return false; }
        }
    }
}