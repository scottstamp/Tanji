using System;
using System.IO;
using System.Xml.Serialization;

namespace Tanji.Utilities
{
    [Serializable]
    public class TanjiSettings
    {
        private static readonly XmlSerializer _xmlSerializer;
        private const string TANJI_SETTINGS_FILENAME = "tanji_settings.xml";

        private static TanjiSettings _settings;
        public static TanjiSettings Global
        {
            get { return _settings; }
        }

        public bool IsAlwaysOnTop { get; set; }
        public bool ShouldCloseOnDisconnect { get; set; }

        static TanjiSettings()
        {
            _settings = new TanjiSettings();
            _xmlSerializer = new XmlSerializer(Global.GetType());
        }

        public static void Save()
        {
            using (var textWriter = new StreamWriter(TANJI_SETTINGS_FILENAME))
                _xmlSerializer.Serialize(textWriter, Global);
        }
        public static void Load()
        {
            if (!File.Exists(TANJI_SETTINGS_FILENAME)) return;
            using (var stream = new FileStream(TANJI_SETTINGS_FILENAME, FileMode.Open, FileAccess.Read, FileShare.Read))
                _settings = (TanjiSettings)_xmlSerializer.Deserialize(stream);
        }
    }
}