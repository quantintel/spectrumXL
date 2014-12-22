using System;
using System.Collections.Generic;
using Org.Quantintel.Spectrum;
using Org.Quantintel.Spectrum.Model;
namespace Org.Quantintel.Spectrum.Api
{
    public class AdminApi
    {
        string basePath;
        private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

        public AdminApi(String basePath = "http://localhost:9000")
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
        /// Pings service 
        /// </summary>
        /// <returns></returns>
        public string ping()
        {
            // create path and map variables
            var path = "/admin/ping".Replace("{format}", "json");

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
        /// Returns health report on this JVM 
        /// </summary>
        /// <returns></returns>
        public Health getHealth()
        {
            // create path and map variables
            var path = "/admin/health".Replace("{format}", "json");

            // query params
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, object>();

            try
            {
                if (typeof(Health) == typeof(byte[]))
                {
                    var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    return ((object)response) as Health;
                }
                else
                {
                    var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
                    if (response != null)
                    {
                        return (Health)ApiInvoker.deserialize(response, typeof(Health));
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

