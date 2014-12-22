using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.Quantintel.Spectrum;

namespace SpectrumXl
{
    public class SpectrumXl
    {
        static string host = "192.168.1.4:9000";


        [ExcelFunction(Description = "Today's Serial Number",
            Category = "Spectrum Financial - Date")]
        public static object SFTODAY()
        {
            try
            {
                ApiInvoker client = new ApiInvoker();

                String response = client.invokeAPI(host,
                    "/date/today/serialNumber",
                    "GET",
                    null, null, null, null);
                // TODO: marshal/unmarshal fetch value
                return Convert.ToDouble(response);
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
            
        }

        [ExcelFunction(Description = "Today's date in simple format: mmddyyy",
            Category = "Spectrum Financial - Date")]
        public static object SFTODAYSF()
        {
            try
            {
                ApiInvoker client = new ApiInvoker();

                String response = client.invokeAPI(host,
                    "/date/today/mmddyyyy",
                    "GET",
                    null, null, null, null);
                // TODO: marshal/unmarshal fetch value
                return response;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }

        [ExcelFunction(Description = "Given a date's serial number return: mmddyyy",
            Category = "Spectrum Financial - Date")]
        public static object SFSIMPLEFMT(long num)
        {
            try
            {
                ApiInvoker client = new ApiInvoker();

                String response = client.invokeAPI(host,
                    "/date/" + Convert.ToString(num) + "/mmddyyyy",
                    "GET",
                    null, null, null, null);
                // TODO: marshal/unmarshal fetch value
                return response;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }

        [ExcelFunction(Description = "Today's day of the week.",
            Category = "Spectrum Financial - Date")]
        public static object SFWEEKDAY()
        {
            try
            {
                ApiInvoker client = new ApiInvoker();

                String response = client.invokeAPI(host,
                    "/date/today/weekday",
                    "GET",
                    null, null, null, null);
                // TODO: marshal/unmarshal fetch value
                return response;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }



    }
}
