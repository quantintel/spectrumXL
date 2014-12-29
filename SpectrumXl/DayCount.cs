/*
 * Copyright (c) 2014  Paul Bernard
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Spectrum Finance is based in part on:
 *        QuantLib. http://quantlib.org/
 *
 */

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

        [ExcelFunction(
            Name = "SP.DC.ACT360.YF",
            Description = "day count fraction using Act/360 method",
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
                SingleDoubleValue response = api.actual360yf(fromdate, todate);
                return (long)response.value;
            }
            catch (Exception e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }



        [ExcelFunction(
            Name = "SP.DC.ACT365F",
            Description = "day count using Act/365F method",
            Category = "Spectrum Financial - Day Count",
            IsVolatile = true)]
        public static object dayCount360F(
             [ExcelArgument(Description = "serial number of start date")] long fromdate,
             [ExcelArgument(Description = "serial number of end date")] long todate)
        {
            try
            {
                DaycountApi api = new DaycountApi();
                api.setBasePath(host);
                SingleLongValue response = api.actual365f(fromdate, todate);
                return (long)response.value;
            }
            catch (Exception e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }


        [ExcelFunction(
            Name = "SP.DC.ACT365F.YF",
            Description = "day count fraction using Act/365F method",
            Category = "Spectrum Financial - Day Count",
            IsVolatile = true)]
        public static object dayCount360F(
             [ExcelArgument(Description = "serial number of start date")] long fromdate,
             [ExcelArgument(Description = "serial number of end date")] long todate)
        {
            try
            {
                DaycountApi api = new DaycountApi();
                api.setBasePath(host);
                SingleDoubleValue response = api.actual365fyf(fromdate, todate);
                return (long)response.value;
            }
            catch (Exception e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }

        [ExcelFunction(
                 Name = "SP.DC.ACT365NL",
                 Description = "day count using Act/365NL method",
                 Category = "Spectrum Financial - Day Count",
                 IsVolatile = true)]
        public static object dayCount360NL(
             [ExcelArgument(Description = "serial number of start date")] long fromdate,
             [ExcelArgument(Description = "serial number of end date")] long todate)
        {
            try
            {
                DaycountApi api = new DaycountApi();
                api.setBasePath(host);
                SingleLongValue response = api.actual365nl(fromdate, todate);
                return (long)response.value;
            }
            catch (Exception e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }



        [ExcelFunction(
         Name = "SP.DC.ACT365NL.YF",
         Description = "day count fraction using Act/365NL method",
         Category = "Spectrum Financial - Day Count",
         IsVolatile = true)]
        public static object dayCount360NL(
             [ExcelArgument(Description = "serial number of start date")] long fromdate,
             [ExcelArgument(Description = "serial number of end date")] long todate)
        {
            try
            {
                DaycountApi api = new DaycountApi();
                api.setBasePath(host);
                SingleDoubleValue response = api.actual365nlyf(fromdate, todate);
                return (long)response.value;
            }
            catch (Exception e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }


        [ExcelFunction(
         Name = "SP.DC.ACT365L",
         Description = "day count using Act/365L method",
         Category = "Spectrum Financial - Day Count",
         IsVolatile = true)]
        public static object dayCount360L(
             [ExcelArgument(Description = "serial number of start date")] long fromdate,
             [ExcelArgument(Description = "serial number of end date")] long todate)
        {
            try
            {
                DaycountApi api = new DaycountApi();
                api.setBasePath(host);
                SingleLongValue response = api.actual365l(fromdate, todate);
                return (long)response.value;
            }
            catch (Exception e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }

        [ExcelFunction(
             Name = "SP.DC.ACT365L.YF",
             Description = "day count fraction using Act/365L method",
             Category = "Spectrum Financial - Day Count",
             IsVolatile = true)]
        public static object dayCount360L(
             [ExcelArgument(Description = "serial number of start date")] long fromdate,
             [ExcelArgument(Description = "serial number of end date")] long todate)
        {
            try
            {
                DaycountApi api = new DaycountApi();
                api.setBasePath(host);
                SingleDoubleValue response = api.actual365lyf(fromdate, todate);
                return (long)response.value;
            }
            catch (Exception e)
            {
                return ExcelError.ExcelErrorValue;
            }

        }



    }
}
