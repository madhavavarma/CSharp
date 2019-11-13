namespace CSharp.Extensions {

    using System;

    public static class DateTimeExtensions {

        ///<summary>
        /// Checks DateTime between fromDate and toDate
        ///</summary>
        ///<param name="fromDate">From Date</param>
        ///<param name="toDate">To Date</param>
        ///<returns>Returns true if date is between fromDate and toDate</returns>
        public static bool Between(this DateTime dateTime, DateTime fromDate, DateTime toDate) {
            return dateTime.CompareTo(fromDate) >= 0 && dateTime.CompareTo(toDate) <= 0;
        }

    }
}