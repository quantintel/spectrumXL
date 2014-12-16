using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectrumXl
{
    public class SpectrumXL
    {
        [ExcelFunction(Description = "Today's Serial Number",
            Category = "Spectrum Financial - Date")]
        public static double SFTODAY()
        {
            return 0.0;
        }

        [ExcelFunction(Description = "Today's date in simple format: mmddyyy",
            Category = "Spectrum Financial - Date")]
        public static string SFTODAYSF()
        {
            return "";
        }

        [ExcelFunction(Description = "Given a date's serial number return: mmddyyy",
            Category = "Spectrum Financial - Date")]
        public static string SFSIMPLEFMT(long num)
        {
            return "";
        }

        [ExcelFunction(Description = "Today's day of the week.",
            Category = "Spectrum Financial - Date")]
        public static string SFWEEKDAY()
        {
            return "";
        }



    }
}
