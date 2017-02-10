using Citicon.Data;
using Sorschia.Queries;
using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace Citicon
{
    public static class Supports
    {
        public static bool OpenFileQuotationFile(string quotationNo)
        {
            var fileName = $@"{ConfigurationManager.AppSettings["Qoutation.SourceLocation"]}\{quotationNo}.doc";
            if (File.Exists(fileName))
            {
                Process.Start(fileName);
                return true;
            }

            return false;
        }

        public static void OpenRtf(string rtf)
        {
            var fileName = $@"{Environment.CurrentDirectory}\temp.rtf";
            using (var fileStream = File.Create(fileName))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(rtf);
                }
            }

            Process.Start(fileName);
        }

        public static Process TouchKeyBoardProcess { get; set; }

        public static void OpenTouchKeyboard()
        {
            TouchKeyBoardProcess = null;
            TouchKeyBoardProcess = Process.Start(@"C:\Program Files\Common Files\Microsoft Shared\Ink\TabTip.exe");
        }

        public static void CloseTouchKeyboard()
        {
            TouchKeyBoardProcess?.Kill();
            TouchKeyBoardProcess = null;
        }

        private static string acceptedBySuggestionsLookupPath
        {
            get { return ConfigurationManager.AppSettings["AcceptedBy.SuggestionsLookup"]; }
        }
        private static string releasedBySuggestionLookupPath
        {
            get { return ConfigurationManager.AppSettings["ReleasedBy.SuggestionsLookup"]; }
        }
        private static string requestedBySuggestionLookupPath
        {
            get { return ConfigurationManager.AppSettings["RequestedBy.SuggestionsLookup"]; }
        }
        public static string[] AcceptedBySuggests
        {
            get { return File.ReadAllLines(acceptedBySuggestionsLookupPath); }
        }
        public static string[] ReleasedBySuggests
        {
            get { return File.ReadAllLines(acceptedBySuggestionsLookupPath); }
        }
        public static string[] RequestedBySuggests
        {
            get { return File.ReadAllLines(requestedBySuggestionLookupPath); }
        }
        public static void AppendAcceptedBySuggest(string suggests)
        {
            File.AppendAllText(acceptedBySuggestionsLookupPath, $"\n{suggests}");
        }
        public static void AppendReleasedBySuggest(string suggests)
        {
            File.AppendAllText(releasedBySuggestionLookupPath, $"\n{suggests}");
        }
        public static void AppendRequestedBySuggest(string suggests)
        {
            File.AppendAllText(requestedBySuggestionLookupPath, $"\n{suggests}");
        }
        public static DateTime SystemDate
        {
            get
            {
                var value = default(DateTime);
                using (var query = new MySqlQuery(ConnectionString, "SELECT NOW();", CommandType.Text))
                {
                    DateTime.TryParse(query.GetValue().ToString(), out value);
                }
                return value;
            }
        }
        public struct CodePrefixes
        {
            private static string getCodePrefix(string name)
            {
                return ConfigurationManager.AppSettings[$"CodePrefix.{name}"];
            }
            public static string Supplier { get { return getCodePrefix("Supplier"); } }
            public static string Branch { get { return getCodePrefix("Branch"); } }
            public static string Classification { get { return getCodePrefix("Classification"); } }
            public static string SubClassification { get { return getCodePrefix("SubClassification"); } }
            public static string Company { get { return getCodePrefix("Company"); } }
            public static string VehicleType { get { return getCodePrefix("VehicleType"); } }
            public static string Item { get { return getCodePrefix("Item"); } }
            public static string Expense { get { return getCodePrefix("Expense"); } }
            public static string Bank { get { return getCodePrefix("Bank"); } }
            public static string BankAccount { get { return getCodePrefix("BankAccount"); } }
        }
        public static bool DebugMode
        {
            get { return bool.Parse(ConfigurationManager.AppSettings["DebugMode"]); }
        }
        public static string ConnectionString { get { return getconfigx("connectionstring"); } }
        public static string AdministratorKey { get { return getconfigx("administratorkey"); } }
        public static Module AdministrativeModule
        {
            get
            {
                return new Module
                {
                    Id = 1,
                    Code = "MOD1-0000",
                    Description = "ADMINISTRATOR"
                };
            }
        }
        private static string configDir
        {
            get
            {
                string directory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/__citiconconfigurations__";
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                return directory;
            }
        }
        private static string getconfigx(string name)
        {
            string defaultFile = $@"{Environment.CurrentDirectory}/{name}.ini";
            string configFile = $@"{configDir}/{name}.ini";
            if (!File.Exists(configFile))
            {
                if (File.Exists(defaultFile)) File.WriteAllText(configFile, Encrypt(File.ReadAllText(defaultFile)));
                else { File.WriteAllText(defaultFile, ""); throw new FileNotFoundException(name); }
            }
            return Decrypt(File.ReadAllText(configFile));
        }
        private static string CryptoKey
        {
            get
            {
                string file = $@"{configDir}/cryptokey.ini";
                if (!File.Exists(file)) { File.WriteAllText(file, ""); throw new FileNotFoundException("Crypto key"); }
                return $"{File.ReadAllText(file).Replace(" ", "").ToUpper()}.sh";
            }
        }
        public static string Encrypt(string text)
        {
            return Sorschia.Supports.Encrypt(CryptoKey, true, text);
        }
        public static string Decrypt(string text)
        {
            return Sorschia.Supports.Decrypt(CryptoKey, true, text);
        }
    }
}
