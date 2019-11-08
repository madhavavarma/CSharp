namespace CSharp.Extensions {
    public static class StringExtensions {
        /// <summary>
        /// Checks string object's value to array of string values
        /// </summary>        
        /// <param name="stringValues">Array of string values to compare</param>
        /// <returns>Return true if any string value matches</returns>
        public static bool In(this string value, params string[] stringValues) {
            foreach (string otherValue in stringValues)
                if (string.Compare(value, otherValue) == 0)
                    return true;

            return false;
        }
    }
}