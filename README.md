spectrumXL
==========

SpectrumXl is an Excel Addin which provides a set User Defined Functions (UDF's)
that can be invoked from a Spreadsheet. 

Currently the Addin support the following functions:

* SP.DATE.TODAY() - Returns today's serial number*
* SP.DATE.TODAYSF() - Returns today's date in mm/dd/yyyy format
* SP.DATE.WEEKDAY() - Returns current weekday: MONDAY, TUESDAY, etc.
* SP.DATE.YEAR() - Returns the current year.
* SP.DATE.MONTH() - Returns the current month.
* SP.DATE.DAYOFMONTH() - Returns the current day of the month.
* SP.DATE.DAYOFYEAR() - Returns the current day of the year.
* SP.DATE.DAYINLY() - Returns TRUE if the current year is a leap year, otherwise false.
* SP.DATE.SN(12,27,2014) - Returns the serial number of the mm, dd, yyyy indicated.
* SP.DATE.SN.SIMPLEFMT(B12) - Returns the mm/dd/yyyy formatted date of the serial number provided.
* SP.DATE.SN.WEEKDAY(B12) - Returns the weekday of the serial number provided.
* SP.DATE.SN.YEAR(B12) - Returns the year of the serial number provided.
* SP.DATE.SN.MONTH(B12) - Returns the month of the serial number provided.
* SP.DATE.SN.DAYOFMONTH(B12) - Returns the day of the month of the serial number provided.
* SP.DATE.SN.DAYOFYR(B12) - Returns the day of the year of the serial number provided.
* SP.DATE.SN.ISLY(B12) - Returns TRUE if the date of the serial number provided is a leap year, otherwise FALSE.
* SP.DATE.MDY.WEEKDAY(12,26,2014) - Returns the weekday of the mm, dd, yyyy provided.
* SP.DATE.MDY.YEAR(12,26,2014) - Returns the year of the mm, dd, yyyy provided (added for consistency purposes only)
* SP.DATE.MDY.MONTH(12,26,2014) - Returns the month of the mm, dd, yyyy provided.
* SP.DATE.MDY.DAYOFMONTH(12,26,2014) - Returns the the day of the month for the mm, dd, yyyy provided (added for consistency purposes only)
* SP.DATE.MDY.DAYOFYR(12,26,2014)- Returns the day of the year for the mm, dd, yyyy provided.
* SP.DATE.MDY.ISLEAPYR(12,26,2014)- Returns TRUE if the mm, dd, yyyy is within a leap year, otherwise FALSE
* SP.DATE.INCR() - returns the serial number of the next date.
* SP.DATE.DECR() - returns the serial number of the previous date.
* SP.DATE.INCRBY(2) - returns the serial number of the date after the serial number indicated.
* SP.DATE.DECRBY(2) - returns the serial number of the date prior to the serial number indicated.
* SP.DC.ACT360(42000,42001) - Day count using ACT360 method.
* SP.DC.ACT360.YF(42000,42002) - Day count fraction using the ACT360 method.
* SP.DC.ACT365F(42000, 42001) - Day count using the ACT365F method.
* SP.DC.ACT365F.YF(42000, 42001) - Day count fraction using the ACT365F method.
* SP.DC.ACT365L(42000, 42001) - Day count method using the ACT365L method
* SP.DC.ACT365L.YF(42000, 42001) - Day count fraction using the ACT365L method.
* SP.DC.ACT365NL(42000, 42001) - Day count method using the ACT365NL method.
* SP.DC.ACT365NL.YF(42000, 42001) - Day count fraction using the ACT365NL method

*serial number - is a date represented as an integer value representing the number of day that have passed since 1900-Jan-0
