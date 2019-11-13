namespace CSharp.Extensions {
    public static class NumberExtensions {
        /// <summary>
        /// Checks int value to array of int values
        /// </summary>        
        /// <param name="intValues">Array of int values to compare</param>
        /// <returns>Return true if any int value matches</returns>
        public static bool In(this int value, params int[] intValues) {
            foreach (int otherValue in intValues)
                if (value == otherValue)
                    return true;

            return false;
        }
    }
}