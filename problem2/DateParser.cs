using System;

namespace Refactoring
{
    public class DateParser
    {
        private string dateAndTimeString;
        //private static Dictionary<string, TimeZoneInfo> KNOWN_TIME_ZONES = new Dictionary<string, TimeZoneInfo>();


        /**
         * Takes a date in ISO 8601 format and returns a date
         *
         * @param dateAndTimeString - should be in format ISO 8601 format
         *                          examples -
         *                          2012-06-17 is 17th June 2012 - 00:00 in UTC TimeZone
         *                          2012-06-17TZ is 17th June 2012 - 00:00 in UTC TimeZone
         *                          2012-06-17T15:00Z is 17th June 2012 - 15:00 in UTC TimeZone
         */
        public DateParser(string dateAndTimeString)
        {
            this.dateAndTimeString = dateAndTimeString;
        }

        public DateTime parse() 
        {
            int year, month, date, hour, minute;

            try {
                string yearString = dateAndTimeString.Substring(0, 4);
                year = int.Parse(yearString);
            } catch (ArgumentOutOfRangeException) {
                throw new Exception("Year string is less than 4 characters");
            } catch (FormatException) {
                throw new Exception("Year is not an integer");
            }
            if (year < 2000 || year > 2013)
                throw new Exception("Year cannot be less than 2000 or more than 2012");

            try {
                string monthString = dateAndTimeString.Substring(5, 2);
                month = int.Parse(monthString);
            } catch (ArgumentOutOfRangeException) {
                throw new Exception("Month string is less than 2 characters");
            } catch (FormatException) {
                throw new Exception("Month is not an integer");
            }
            if (month < 1 || month > 12)
                throw new Exception("Month cannot be less than 1 or more than 12");

            try {
                string dateString = dateAndTimeString.Substring(8, 2);
                date = int.Parse(dateString);
            } catch (ArgumentOutOfRangeException) {
                throw new Exception("Date string is less than 2 characters");
            } catch (FormatException) {
                throw new Exception("Date is not an integer");
            }
            if (date < 1 || date > 31)
                throw new Exception("Date cannot be less than 1 or more than 31");

            try {
                string hourString = dateAndTimeString.Substring(11, 2);
                hour = int.Parse(hourString);
            } catch (ArgumentOutOfRangeException) {
                throw new Exception("Hour string is less than 2 characters");
            } catch (FormatException) {
                throw new Exception("Hour is not an integer");
            }
            if (hour < 0 || hour > 23)
                throw new Exception("Hour cannot be less than 0 or more than 23");

            try {
                string minuteString = dateAndTimeString.Substring(14, 2);
                minute = int.Parse(minuteString);
            } catch (ArgumentOutOfRangeException) {
                throw new Exception("Minute string is less than 2 characters");
            } catch (FormatException) {
                throw new Exception("Minute is not an integer");
            }
            if (minute < 0 || minute > 59)
                throw new Exception("Minute cannot be less than 0 or more than 59");

           return new DateTime(year, month, date, hour, minute, 0);
        }
    }
}