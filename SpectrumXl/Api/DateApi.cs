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
        public SingleStringValue dtMonth(long? serialNumber)
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
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue dtYear(long? serialNumber)
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
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue isLeapYear()
        {
            // create path and map variables
            var path = "/date/today/isLeapYear".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        /// <param name="mm">mm - month</param>
        /// <param name="dd">dd - day of month</param>
        /// <param name="yy">yy - yyyy year</param>
        /// <returns></returns>
        public SingleStringValue dtstrIsLeapYear(int? mm, int? dd, int? yy)
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/isLeapYear".Replace("{format}", "json").Replace("{" + "mm" + "}", apiInvoker.escapeString(mm.ToString())).Replace("{" + "dd" + "}", apiInvoker.escapeString(dd.ToString())).Replace("{" + "yy" + "}", apiInvoker.escapeString(yy.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (mm == null || dd == null || yy == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue month()
        {
            // create path and map variables
            var path = "/date/today/month".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue simpleFmt(long? serialNumber)
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
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        /// <param name="mm">mm - month</param>
        /// <param name="dd">dd - day of month</param>
        /// <param name="yy">yy - yyyy year</param>
        /// <returns></returns>
        public SingleStringValue dtstrMonth(int? mm, int? dd, int? yy)
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/month".Replace("{format}", "json").Replace("{" + "mm" + "}", apiInvoker.escapeString(mm.ToString())).Replace("{" + "dd" + "}", apiInvoker.escapeString(dd.ToString())).Replace("{" + "yy" + "}", apiInvoker.escapeString(yy.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (mm == null || dd == null || yy == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        /// <param name="mm">mm - month</param>
        /// <param name="dd">dd - day of month</param>
        /// <param name="yy">yy - yyyy year</param>
        /// <returns></returns>
        public SingleStringValue dtstrDayOfMonth(int? mm, int? dd, int? yy)
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/dayOfMonth".Replace("{format}", "json").Replace("{" + "mm" + "}", apiInvoker.escapeString(mm.ToString())).Replace("{" + "dd" + "}", apiInvoker.escapeString(dd.ToString())).Replace("{" + "yy" + "}", apiInvoker.escapeString(yy.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (mm == null || dd == null || yy == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue dtIsLeapYear(long? serialNumber)
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
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue dayOfYear()
        {
            // create path and map variables
            var path = "/date/today/dayOfYear".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue todaySimpleFmt()
        {
            // create path and map variables
            var path = "/date/today/mmddyyyy".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        /// <param name="mm">mm - month</param>
        /// <param name="dd">dd - day of month</param>
        /// <param name="yy">yy - yyyy year</param>
        /// <returns></returns>
        public SingleStringValue dtstrDayOfYear(int? mm, int? dd, int? yy)
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/dayOfYear".Replace("{format}", "json").Replace("{" + "mm" + "}", apiInvoker.escapeString(mm.ToString())).Replace("{" + "dd" + "}", apiInvoker.escapeString(dd.ToString())).Replace("{" + "yy" + "}", apiInvoker.escapeString(yy.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (mm == null || dd == null || yy == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue weekday()
        {
            // create path and map variables
            var path = "/date/today/weekday".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        /// <param name="mm">mm - month</param>
        /// <param name="dd">dd - day of month</param>
        /// <param name="yy">yy - yyyy year</param>
        /// <returns></returns>
        public SingleStringValue dtstrWeekday(int? mm, int? dd, int? yy)
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/weekday".Replace("{format}", "json").Replace("{" + "mm" + "}", apiInvoker.escapeString(mm.ToString())).Replace("{" + "dd" + "}", apiInvoker.escapeString(dd.ToString())).Replace("{" + "yy" + "}", apiInvoker.escapeString(yy.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (mm == null || dd == null || yy == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        /// <param name="mm">mm - month</param>
        /// <param name="dd">dd - day of month</param>
        /// <param name="yy">yy - yyyy year</param>
        /// <returns></returns>
        public SingleStringValue dtstrYear(int? mm, int? dd, int? yy)
        {
            // create path and map variables
            var path = "/date/{mm}/{dd}/{yyyy}/year".Replace("{format}", "json").Replace("{" + "mm" + "}", apiInvoker.escapeString(mm.ToString())).Replace("{" + "dd" + "}", apiInvoker.escapeString(dd.ToString())).Replace("{" + "yy" + "}", apiInvoker.escapeString(yy.ToString()));

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            // verify required params are set
            if (mm == null || dd == null || yy == null)
            {
                throw new ApiException(400, "missing required params");
            }
            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue dayOfMonth()
        {
            // create path and map variables
            var path = "/date/today/dayOfMonth".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue year()
        {
            // create path and map variables
            var path = "/date/today/year".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue dtDayOfYear(long? serialNumber)
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
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleStringValue dtDayOfMonth(long? serialNumber)
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
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
        public SingleLongValue today()
        {
            // create path and map variables
            var path = "/date/today/serialNumber".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(SingleLongValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleLongValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleLongValue)ApiInvoker.deserialize(response, typeof(SingleLongValue));
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
        public SingleStringValue dtWeekday(long? serialNumber)
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
                if (typeof(SingleStringValue) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as SingleStringValue;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (SingleStringValue)ApiInvoker.deserialize(response, typeof(SingleStringValue));
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
