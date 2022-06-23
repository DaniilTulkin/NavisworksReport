using System.Windows.Forms;
using System;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace NavisworksReport
{
    public class XML
    {
        private static string writeFilePath = string.Empty;
        private static string readFilePath = string.Empty;

        private static void GetFilePathToWrite()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                OverwritePrompt = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = ".xml files (*.xml)|*.xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                writeFilePath = saveFileDialog.FileName;
            }
        }

        private static void GetFilePathToRead()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = ".xml files (*.xml)|*.xml"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                readFilePath = openFileDialog.FileName;
            }
        }

        internal static void Write(exchange ex)
        {
            GetFilePathToWrite();
            if (string.IsNullOrEmpty(writeFilePath)) return;

            WriteImageRelativeHref(ex);            

            XmlSerializer serializer = new XmlSerializer(typeof(exchange));
            using (TextWriter writer = new StreamWriter(writeFilePath))
            {
                serializer.Serialize(writer, ex);
            }

            WriteImageAbsoluteHref(ex);
        }

        internal static exchange Read()
        {
            GetFilePathToRead();
            if (string.IsNullOrEmpty(readFilePath)) return null;

            XmlSerializer serializer = new XmlSerializer(typeof(exchange));
            using (Stream reader = new FileStream(readFilePath, FileMode.Open))
            {
                exchange ex = (exchange)serializer.Deserialize(reader);
                WriteImageAbsoluteHref(ex);
                
                return ex;
            }
        }

        private static void WriteImageRelativeHref(exchange ex)
        {
            foreach (exchangeBatchtestClashtest clashtest in ex.batchtest.clashtests)
            {
                foreach (exchangeBatchtestClashtestClashresultsClashresult clashresult in clashtest.clashresults.clashresult
                    ?? new exchangeBatchtestClashtestClashresultsClashresult[0])
                {
                    string imageRef = clashresult.href;
                    string[] splitedRef = imageRef.Split(new string[] { "\\" }, StringSplitOptions.None);
                    clashresult.href = $"{splitedRef[splitedRef.Length - 2]}\\{splitedRef[splitedRef.Length - 1]}";
                }
            }
        }

        private static void WriteImageAbsoluteHref(exchange ex)
        {
            foreach (exchangeBatchtestClashtest clashtest in ex.batchtest.clashtests)
            {
                foreach (exchangeBatchtestClashtestClashresultsClashresult clashresult in clashtest.clashresults.clashresult
                    ?? new exchangeBatchtestClashtestClashresultsClashresult[0])
                {
                    string imageRef = clashresult.href;
                    clashresult.href = Path.GetDirectoryName(readFilePath) + $"\\{imageRef}";
                }
            }
        }
    }
}
