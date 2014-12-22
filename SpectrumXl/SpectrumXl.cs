using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.Quantintel.Spectrum;
using Org.Quantintel.Spectrum.Api;
using Org.Quantintel.Spectrum.Model;

namespace SpectrumXl
{
    public class SpectrumXl
    {
        static string host = "http://192.168.1.4:9000";


        [ExcelFunction(IsVolatile=true, Description = "Today's Serial Number",
            Category = "Spectrum Financial - Date")]
        public static object SFTODAY(object o)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleLongValue response = dtApi.today();
                return (long)response.value;
            }
            catch (Exception e)
            {
                return ExcelError.ExcelErrorValue;
            }
                       
        }

        [ExcelFunction(IsVolatile = true, Description = "Today's date in simple format: mmddyyy",
            Category = "Spectrum Financial - Date")]
        public static object SFTODAYSF()
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.todaySimpleFmt();
                return response.value;
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
