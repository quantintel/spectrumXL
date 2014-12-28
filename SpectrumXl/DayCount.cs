using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelDna.Integration;
using Org.Quantintel.Spectrum;
using Org.Quantintel.Spectrum.Api;
using Org.Quantintel.Spectrum.Model;

namespace SpectrumXl
{
    public class DayCount
    {

        public static string host = "http://localhost:9000";

        /// <summary>
        /// Returns day count between two days using the Actual/360 method
        /// </summary>
        /// <param name="o"></param>
        /// <returns>day count</returns>
        [ExcelFunction(
            Name = "SP.DC.ACT360",
            Description = "day count using Act/360 method",
            Category = "Spectrum Financial - Day Count",
            IsVolatile = true)]
        public static object dayCount360(
             [ExcelArgument(Description = "serial number of start date")] long fromdate,
             [ExcelArgument(Description = "serial number of end date")] long todate)
        {
            try
            {
                DaycountApi api = new DaycountApi();
                api.setBasePath(host);
                SingleLongValue response = api.actual360(fromdate, todate);
                return (long)response.value;
            }
            catch (Exception e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }
    }
}
