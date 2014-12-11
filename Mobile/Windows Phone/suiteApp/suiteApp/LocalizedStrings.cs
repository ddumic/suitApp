using suiteApp.Resources;

namespace suiteApp
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }

        public static byte[] AESkey;
        public static byte[] AESIV;
        public static string publicKey;
    }
}