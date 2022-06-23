using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NavisworksReport
{
    public partial class MainWindowModelService
    {
        internal ObservableCollection<exchangeBatchtestClashtest> LoadReport(ObservableCollection<exchangeBatchtestClashtest> reports)
        {
            if (reports == null) reports = new ObservableCollection<exchangeBatchtestClashtest>();

            exchange ex = null;
            try
            {
                ex = XML.Read();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Текст ошибки: {e.Message}.",
                            "Ошибка загрузки отчёта",
                            MessageBoxButtons.OK);
            }
            if (ex == null) return reports;

            foreach (exchangeBatchtestClashtest clashtest in ex.batchtest.clashtests) reports.Add(clashtest);
            return reports;
        }

        internal void UploadReport(ObservableCollection<exchangeBatchtestClashtest> reports, 
                                   exchangeBatchtestClashtest selectedReport, 
                                   string selectedUploadOption)
        {
            exchange ex = new exchange();
            ex.batchtest = new exchangeBatchtest();
            switch (selectedUploadOption)
            {
                case "Текущая проверка":
                    if (selectedReport == null) return;
                    ex.batchtest.clashtests = new exchangeBatchtestClashtest[] { selectedReport };
                    break;
                case "Все проверки":
                    if (!reports.Any()) return;
                    ex.batchtest.clashtests = reports.ToArray();
                    break;
                default:
                    break;
            }

            XML.Write(ex);
        }

        internal string LastExecution(exchangeBatchtestClashtest selectedReport)
        {
            List<DateTime> dateTimes = new List<DateTime>();
            IFormatProvider culture = new CultureInfo("ru-Ru", true);

            foreach (exchangeBatchtestClashtestClashresultsClashgroup clashgroup in 
                selectedReport.clashresults.clashgroup ?? new exchangeBatchtestClashtestClashresultsClashgroup[0])
            {
                exchangeBatchtestClashtestClashresultsClashgroupCreateddateDate date = clashgroup?.createddate?.date;
                if (date == null) continue;

                DateTime dateTime = new DateTime(date.year, date.month, date.day, date.hour, date.minute, date.second).AddHours(3);
                dateTimes.Add(dateTime);
            }
            foreach (exchangeBatchtestClashtestClashresultsClashresult clashresult in 
                selectedReport.clashresults.clashresult ?? new exchangeBatchtestClashtestClashresultsClashresult[0])
            {
                exchangeBatchtestClashtestClashresultsClashresultCreateddateDate date = clashresult?.createddate?.date;
                if (date == null) continue;

                DateTime dateTime = new DateTime(date.year, date.month, date.day, date.hour, date.minute, date.second).AddHours(3);
                dateTimes.Add(dateTime);
            }

            if (!dateTimes.Any()) return "";
            return "Последнее выполнение: " + dateTimes.OrderBy(x => x.Date).First().ToString("F", culture);
        }
    }
}
