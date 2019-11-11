namespace CSharp.Extensions {
    public static class NumberExtensions {
        /// <summary>
        /// Checks string object's value to array of string values
        /// </summary>        
        /// <param name="stringValues">Array of string values to compare</param>
        /// <returns>Return true if any string value matches</returns>
        public static bool In(this int value, params int[] intValues) {
            foreach (int otherValue in intValues)
                if (value == otherValue)
                    return true;

            return false;
        }
    }
}