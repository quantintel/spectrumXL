
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
    public class Date
    {

        public static string host = "http://localhost:9000";

        /// <summary>
        /// Returns the serial number of the current date.
        /// </summary>
        /// <param name="o"></param>
        /// <returns>serial number of current date.</returns>
        [ExcelFunction(
            Name = "SP.DATE.TODAY",
            Description = "Today's Serial Number",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object today()
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

        [ExcelFunction(
            Name = "SP.DATE.SN",
            Description = "Serial number of the date indicated.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object serialNumber(
             [ExcelArgument(Description = "Month 1-12")] int mm,
             [ExcelArgument(Description = "Day 1-31")] int dd,
             [ExcelArgument(Description = "Year")] int year)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleLongValue response = dtApi.serialNumber(mm, dd, year);
                return (long)response.value;
            }
            catch (Exception e)
            {
                return e.Message;
                //return ExcelError.ExcelErrorValue;
            }
        }

        /// <summary>
        /// Returns the mmddyyyy formated version of the current date.
        /// </summary>
        /// <returns>mmddyyyy formated current date.</returns>
        [ExcelFunction(
            Name = "SP.DATE.TODAYSF",
            Description = "Today's date in simple format: mmddyyyy",
            Category = "Spectrum Financial - DATE",
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


        [ExcelFunction(
            Name = "SP.DATE.WEEKDAY",
            Description = "Today's day of the week: MONDAY, TUESDAY, ...",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
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

        [ExcelFunction(
            Name = "SP.DATE.YEAR",
            Description = "The current year.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object year()
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.year();
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
           Name = "SP.DATE.MONTH",
           Description = "The current month.",
           Category = "Spectrum Financial - DATE",
           IsVolatile = true)]
        public static object month()
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.month();
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.DAYOFMONTH",
            Description = "The current month.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object dayOfMonth()
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dayOfMonth();
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
             Name = "SP.DATE.DAYOFYEAR",
             Description = "The current day of the year.",
             Category = "Spectrum Financial - DATE",
             IsVolatile = true)]
        public static object dayOfYear()
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dayOfYear();
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }
        [ExcelFunction(
            Name = "SP.DATE.DAYINLY",
            Description = "Is today in a leap year.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object isLeapYear()
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.isLeapYear();
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
            Name = "SP.DATE.SN.SIMPLEFMT",
            Description = "Given a date's serial number return: mmddyyyy",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object simpleFmt(
            [ExcelArgument(Description = "date serial number")] long num)
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


        [ExcelFunction(
             Name = "SP.DATE.SN.WEEKDAY",
             Description = "Given a date's serial number return weekday.",
             Category = "Spectrum Financial - DATE",
             IsVolatile = true)]
        public static object dtWeekday(
           [ExcelArgument(Description = "date serial number")] long num)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtWeekday(num);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
             Name = "SP.DATE.SN.YEAR",
             Description = "Given a date's serial number return year.",
             Category = "Spectrum Financial - DATE",
             IsVolatile = true)]
        public static object dtYear(
           [ExcelArgument(Description = "date serial number")] long num)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtYear(num);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.SN.MONTH",
            Description = "Given a date's serial number return month",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object dtMonth(
            [ExcelArgument(Description = "date serial number")] long num)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtMonth(num);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
             Name = "SP.DATE.SN.DAYOFMONTH",
             Description = "Given a date's serial number return day of month",
             Category = "Spectrum Financial - DATE",
             IsVolatile = true)]
        public static object dtDayOfMonth(
                [ExcelArgument(Description = "date serial number")] long num)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtDayOfMonth(num);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.SN.DAYOFYR",
            Description = "Given a date's serial number return year.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object dtDayOfYear(
            [ExcelArgument(Description = "date serial number")] long num)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtDayOfYear(num);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.SN.ISLY",
            Description = "Given a date's serial number return if leap year.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object dtIsLeapYear(
            [ExcelArgument(Description = "date serial number")] long num)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtIsLeapYear(num);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }





        [ExcelFunction(
           Name = "SP.DATE.MDY.WEEKDAY",
           Description = "Returns the day of the week: MONDAY, TUESDAY, etc.",
           Category = "Spectrum Financial - DATE",
           IsVolatile = true)]
        public static object dtstrWeekday(
             [ExcelArgument(Description = "Month 1-12")]
             int mm,
             [ExcelArgument(Description = "Day of Month 1-31")]
             int dd,
             [ExcelArgument(Description = "Year example: 2014")]
             int yyyy)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtstrWeekday(mm, dd, yyyy);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.MDY.YEAR",
            Description = "Returns the year.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object dtstrYear(
             [ExcelArgument(Description = "Month 1-12")]
             int mm,
             [ExcelArgument(Description = "Day of Month 1-31")]
             int dd,
             [ExcelArgument(Description = "Year example: 2014")]
             int yyyy)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtstrYear(mm, dd, yyyy);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.MDY.MONTH",
            Description = "Returns the month.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object dtstrMonth(
             [ExcelArgument(Description = "Month 1-12")]
             int mm,
             [ExcelArgument(Description = "Day of Month 1-31")]
             int dd,
             [ExcelArgument(Description = "Year example: 2014")]
             int yyyy)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtstrMonth(mm, dd, yyyy);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.MDY.DAYOFMONTH",
            Description = "Returns the day of the month",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object dtstrDayOfMonth(
             [ExcelArgument(Description = "Month 1-12")]
             int mm,
             [ExcelArgument(Description = "Day of Month 1-31")]
             int dd,
             [ExcelArgument(Description = "Year example: 2014")]
             int yyyy)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtstrDayOfMonth(mm, dd, yyyy);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.MDY.DAYOFYR",
            Description = "Returns the day of the year.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object dtstrDayOfYear(
             [ExcelArgument(Description = "Month 1-12")]
             int mm,
             [ExcelArgument(Description = "Day of Month 1-31")]
             int dd,
             [ExcelArgument(Description = "Year example: 2014")]
             int yyyy)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtstrDayOfYear(mm, dd, yyyy);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.MDY.ISLEAPYR",
            Description = "Returns if the date provided is in a leap year.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object dtstrIsLeapYear(
             [ExcelArgument(Description = "Month 1-12")]
             int mm,
             [ExcelArgument(Description = "Day of Month 1-31")]
             int dd,
             [ExcelArgument(Description = "Year example: 2014")]
             int yyyy)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleStringValue response = dtApi.dtstrIsLeapYear(mm, dd, yyyy);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.INCR",
            Description = "Increment the current days serial number by one.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object incr()
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleLongValue response = dtApi.incr();
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.DECR",
            Description = "Decrements the current days serial number by one.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object decr()
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleLongValue response = dtApi.decr();
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.INCRBY",
            Description = "Increments the current days serial number by the number of days indicated.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object incr(
             [ExcelArgument(Description = "Number of days to increment")] int serialNumber)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleLongValue response = dtApi.incrBy(serialNumber);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

        [ExcelFunction(
            Name = "SP.DATE.DECRBY",
            Description = "Decrements the current days serial number by the number of days indicatred.",
            Category = "Spectrum Financial - DATE",
            IsVolatile = true)]
        public static object decr(
             [ExcelArgument(Description = "Number of days to decrement")] int serialNumber)
        {
            try
            {
                DateApi dtApi = new DateApi();
                dtApi.setBasePath(host);
                SingleLongValue response = dtApi.decrBy(serialNumber);
                return response.value;
            }
            catch (ApiException e)
            {
                return ExcelError.ExcelErrorValue;
            }
        }

    }
}
