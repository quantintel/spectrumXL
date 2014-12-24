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

using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Org.Quantintel.Spectrum;
using Org.Quantintel.Spectrum.Api;
using Org.Quantintel.Spectrum.Model;
using ExcelDna.Integration.CustomUI;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace SpectrumXl
{
    [ComVisible(true)]
    public class QuantIntelRibbon : ExcelRibbon
    {
        public void RefreshCmd(IRibbonControl control)
        {
            MessageBox.Show("Refresh Done!");
        }
    }

    public class SpectrumXl
    {
        static string host = "http://192.168.1.4:9000";

        /// <summary>
        /// Returns the serial number of the current date.
        /// </summary>
        /// <param name="o"></param>
        /// <returns>serial number of current date.</returns>
        [ExcelFunction(
            Name="SP.DATE.TODAY", 
            Description = "Today's Serial Number",
            Category = "Spectrum Financial - Ser. # for Today",
            IsVolatile=true)]
        public static object today(object o)
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

        /// <summary>
        /// Returns the mmddyyyy formated version of the current date.
        /// </summary>
        /// <returns>mmddyyyy formated current date.</returns>
        [ExcelFunction(
            Name="SP.DATE.TODAYSF",
            Description = "Today's date in simple format: mmddyyyy",
            Category = "Spectrum Financial - mmddyyyy for today",
            IsVolatile = true)]
        public static object todaySimpleFmt()
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

        /// <summary>
        /// Given a serial number returns the mmddyyyy formatted version.
        /// </summary>
        /// <param name="num">serial number of required date.</param>
        /// <returns>mmddyyyy version of the date indicated by the serial number provided.</returns>
        [ExcelFunction(
            Name="SP.DATE.SIMPLEFMT",
            Description = "Given a date's serial number return: mmddyyyy",
            Category = "Spectrum Financial - mmddyyyy for Ser. #")]
        public static object simpleFmt(long num)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.simpleFmt(num);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        /// <summary>
        /// Returns the current day of the week.
        /// </summary>
        /// <returns>Todays day of the week.</returns>
        [ExcelFunction(
            Name="SP.DATE.WEEKDAY",
            Description = "Today's day of the week.",
            Category = "Spectrum Financial - Weekday for today")]
        public static object weekday()
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.weekday();
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        /// <summary>
        /// Day of the week for the given serial number.
        /// </summary>
        /// <param name="number">serial number</param>
        /// <returns>Day of the week.</returns>
        [ExcelFunction(
            Name="SP.DATE.WEEKDAYDT",
            Description="",
            Category = "Spectrum Financial - Weekday for Ser. #")]
        public static object dtWeekday(long number){
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtWeekday(number);
                return response.value;
            }
            catch (ApiException e)
            {
                
                return ExcelError.ExcelErrorValue;
            }
        }

         [ExcelFunction(
            Name = "SP.DATE.WEEKDAYSTR",
            Description = "Returns the day of the week: MONDAY, TUESDAY, etc.",
            Category = "Spectrum Financial - Weekday for mm/dd/yyyy provided")]
        public static object dtstrWeekday(
             [ExcelArgument(Description = "Month 1-12")]
             int mm,
             [ExcelArgument(Description = "Day of Month 1-31")]
             int dd,
             [ExcelArgument(Description = "Year example: 2014")]
             int yy)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtstrWeekday(mm, dd, yy);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }


    }
}
