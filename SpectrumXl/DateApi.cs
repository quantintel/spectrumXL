using System;
using System.Collections.Generic;
using Org.Quantintel.Spectrum;
using Org.Quantintel.Spectrum.Model;
namespace Org.Quantintel.Spectrum.Api
{
    public class DateApi
    {
        string basePath;
        private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

        public DateApi(String basePath = "http://localhost:9000")
        {
            this.basePath = basePath;
        }

        public ApiInvoker getInvoker()
        {
            return apiInvoker;
        }

        // Sets the endpoint base url for the services being accessed
        public void setBasePath(string basePath)
        {
            this.basePath = basePath;
        }

        // Gets the endpoint base url for the services being accessed
        public String getBasePath()
        {
            return basePath;
        }

        /// <summary>
        /// month for the date provided 
        /// </summary>
        /// <param name="serialNumber">date serial number</param>
        /// <returns></returns>
        public string dtMonth(long? serialNumber)
        {
            // create path and map variables
            var path = "/date/{serialNumber}/month".Replace("{format}", "json").Replace("{" + "serialNumber" + "}", apiInvoker.escapeString(serialNumber.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (serialNumber == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// year of the serial number provided 
        /// </summary>
        /// <param name="serialNumber">date serial number</param>
        /// <returns></returns>
        public string dtYear(long? serialNumber)
        {
            // create path and map variables
            var path = "/date/{serialNumber}/year".Replace("{format}", "json").Replace("{" + "serialNumber" + "}", apiInvoker.escapeString(serialNumber.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (serialNumber == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// returns whether the current year is a leap year. 
        /// </summary>
        /// <returns></returns>
        public string isLeapYear()
        {
            // create path and map variables
            var path = "/date/today/isLeapYear".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// returns whether the date provided is within a leap year. 
        /// </summary>
        /// <returns></returns>
        public string dtstrIsLeapYear()
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/isLeapYear".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// month for the current date 
        /// </summary>
        /// <returns></returns>
        public string month()
        {
            // create path and map variables
            var path = "/date/today/month".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// today's date 
        /// </summary>
        /// <param name="serialNumber">date serial number</param>
        /// <returns></returns>
        public string simpleFmt(long? serialNumber)
        {
            // create path and map variables
            var path = "/date/{serialNumber}/mmddyyyy".Replace("{format}", "json").Replace("{" + "serialNumber" + "}", apiInvoker.escapeString(serialNumber.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (serialNumber == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// month for the date provided 
        /// </summary>
        /// <returns></returns>
        public string dtstrMonth()
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/month".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// day of the month for the date provided 
        /// </summary>
        /// <returns></returns>
        public string dtstrDayOfMonth()
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/dayOfMonth".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// returns whether the date provided is within a leap year. 
        /// </summary>
        /// <param name="serialNumber">date serial number</param>
        /// <returns></returns>
        public string dtIsLeapYear(long? serialNumber)
        {
            // create path and map variables
            var path = "/date/{serialNumber}/isLeapYear".Replace("{format}", "json").Replace("{" + "serialNumber" + "}", apiInvoker.escapeString(serialNumber.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (serialNumber == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// day of the current year 
        /// </summary>
        /// <returns></returns>
        public string dayOfYear()
        {
            // create path and map variables
            var path = "/date/today/dayOfYear".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// today's date in SimpleFormat returns the current date formatted in SimpleFormat
        /// </summary>
        /// <returns></returns>
        public string todaySimpleFmt()
        {
            // create path and map variables
            var path = "/date/today/mmddyyyy".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// day of year for the date provided 
        /// </summary>
        /// <returns></returns>
        public string dtstrDayOfYear()
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/dayOfYear".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// the current day of the week 
        /// </summary>
        /// <returns></returns>
        public string weekday()
        {
            // create path and map variables
            var path = "/date/today/weekday".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// the day of the week for the corresponding dd, mm, yyyy indicated 
        /// </summary>
        /// <returns></returns>
        public string dtstrWeekday()
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/weekday".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// date for the mm dd and yy indicated. 
        /// </summary>
        /// <returns></returns>
        public string dtstrYear()
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/year".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// day of the month for the current date. 
        /// </summary>
        /// <returns></returns>
        public string dayOfMonth()
        {
            // create path and map variables
            var path = "/date/today/dayOfMonth".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// year of the current date 
        /// </summary>
        /// <returns></returns>
        public string year()
        {
            // create path and map variables
            var path = "/date/today/year".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// day of year for the date provided 
        /// </summary>
        /// <param name="serialNumber">date serial number</param>
        /// <returns></returns>
        public string dtDayOfYear(long? serialNumber)
        {
            // create path and map variables
            var path = "/date/{serialNumber}/dayOfYear".Replace("{format}", "json").Replace("{" + "serialNumber" + "}", apiInvoker.escapeString(serialNumber.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (serialNumber == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// day of the month for the date provided 
        /// </summary>
        /// <param name="serialNumber">date serial number</param>
        /// <returns></returns>
        public string dtDayOfMonth(long? serialNumber)
        {
            // create path and map variables
            var path = "/date/{serialNumber}/dayOfMonth".Replace("{format}", "json").Replace("{" + "serialNumber" + "}", apiInvoker.escapeString(serialNumber.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (serialNumber == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// today's serial number returns serial number of current date
        /// </summary>
        /// <returns></returns>
        public long? today()
        {
            // create path and map variables
            var path = "/date/today/serialNumber".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(long?) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as long?;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (long?)ApiInvoker.deserialize(response, typeof(long?));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// the day of the week associated with the serial number provided 
        /// </summary>
        /// <param name="serialNumber">date serial number</param>
        /// <returns></returns>
        public string dtWeekday(long? serialNumber)
        {
            // create path and map variables
            var path = "/date/{serialNumber}/weekday".Replace("{format}", "json").Replace("{" + "serialNumber" + "}", apiInvoker.escapeString(serialNumber.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (serialNumber == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(string) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as string;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (string)ApiInvoker.deserialize(response, typeof(string));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
    }
}

