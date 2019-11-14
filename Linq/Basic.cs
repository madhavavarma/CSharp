namespace CSharp.Linq
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Basic 
    {
        public static IEnumerable<int> GetHighScores(int[] scores)
        {
            scores = scores != null ? scores : new int[] {97, 80, 42, 92};

            var highScores = scores.Where(score => score > 90 ).Select(score => score);

            return highScores;
         }
    }
}