namespace CSharp.LinqTests
{
    using System;
    using Xunit;
    using CSharp.Linq;

    public class BasicTests
    {
        [Fact]
        public void GetHighScores_ReturnsHighScores()
        {
            var scores = new int[] { 100, 22, 23 };

            var result = Basic.GetHighScores(scores);

            Assert.Single(result);
        }
    }
}