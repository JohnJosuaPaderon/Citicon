using Citicon.Data;
using Newtonsoft.Json;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;

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

        private static string AcceptedBySuggestionsLookupPath
        {
            get { return ConfigurationManager.AppSettings["AcceptedBy.SuggestionsLookup"]; }
        }
        private static string ReleasedBySuggestionLookupPath
        {
            get { return ConfigurationManager.AppSettings["ReleasedBy.SuggestionsLookup"]; }
        }
        private static string RequestedBySuggestionLookupPath
        {
            get { return ConfigurationManager.AppSettings["RequestedBy.SuggestionsLookup"]; }
        }
        public static string[] AcceptedBySuggests
        {
            get { return File.ReadAllLines(AcceptedBySuggestionsLookupPath); }
        }
        public static string[] ReleasedBySuggests
        {
            get { return File.ReadAllLines(AcceptedBySuggestionsLookupPath); }
        }
        public static string[] RequestedBySuggests
        {
            get { return File.ReadAllLines(RequestedBySuggestionLookupPath); }
        }
        public static void AppendAcceptedBySuggest(string suggests)
        {
            File.AppendAllText(AcceptedBySuggestionsLookupPath, $"\n{suggests}");
        }
        public static void AppendReleasedBySuggest(string suggests)
        {
            File.AppendAllText(ReleasedBySuggestionLookupPath, $"\n{suggests}");
        }
        public static void AppendRequestedBySuggest(string suggests)
        {
            File.AppendAllText(RequestedBySuggestionLookupPath, $"\n{suggests}");
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
            private static string GetCodePrefix(string name)
            {
                return ConfigurationManager.AppSettings[$"CodePrefix.{name}"];
            }
            public static string Supplier { get { return GetCodePrefix("Supplier"); } }
            public static string Branch { get { return GetCodePrefix("Branch"); } }
            public static string Classification { get { return GetCodePrefix("Classification"); } }
            public static string SubClassification { get { return GetCodePrefix("SubClassification"); } }
            public static string Company { get { return GetCodePrefix("Company"); } }
            public static string VehicleType { get { return GetCodePrefix("VehicleType"); } }
            public static string Item { get { return GetCodePrefix("Item"); } }
            public static string Expense { get { return GetCodePrefix("Expense"); } }
            public static string Bank { get { return GetCodePrefix("Bank"); } }
            public static string BankAccount { get { return GetCodePrefix("BankAccount"); } }
        }
        public static bool DebugMode
        {
            get { return bool.Parse(ConfigurationManager.AppSettings["DebugMode"]); }
        }
        public static string ConnectionString { get { return Getconfigx("connectionstring"); } }
        public static string AdministratorKey { get { return Getconfigx("administratorkey"); } }
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
        private static string ConfigDir
        {
            get
            {
                string directory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/__citiconconfigurations__";
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                return directory;
            }
        }
        private static string Getconfigx(string name)
        {
            string defaultFile = $@"{Environment.CurrentDirectory}/{name}.ini";
            string configFile = $@"{ConfigDir}/{name}.ini";
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
                string file = $@"{ConfigDir}/cryptokey.ini";
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

        public static T Clone<T>(T value)
        {
            var result = JsonConvert.SerializeObject(value);
            return JsonConvert.DeserializeObject<T>(result);
        }

        public static int ExcelColorConverter(string hex)
        {
            var colorConverter = new ColorConverter();
            return ExcelColorConverter(colorConverter.ConvertFromString(hex));
        }

        public static int ExcelColorConverter(object color)
        {
            return ColorTranslator.ToOle((Color)color);
        }

        public static DateTime GetDateTimeMean(IEnumerable<DateTime> dateTimes)
        {
            if (dateTimes.Any())
            {
                DateTime mean = default(DateTime);
                Dictionary<DateTime, int> meanCandidates = new Dictionary<DateTime, int>();
                foreach (var dateTime in dateTimes)
                {
                    var dateTimeDate = dateTime.Date;
                    if (!meanCandidates.ContainsKey(dateTimeDate))
                    {
                        meanCandidates.Add(dateTimeDate, 0);
                    }

                    meanCandidates[dateTimeDate]++;
                }

                return mean;
            }
            else
            {
                return default(DateTime);
            }
        }
    }
}
