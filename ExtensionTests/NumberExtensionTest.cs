namespace ExtensionTests
{
    using CSharp.Extensions;
    using Xunit;

    public class NumberExtensionTests {

        [Fact]
        public static void NumberExistsInNumberArray() {
            var result = 1.In(new int[] {1, 2, 3});

            Assert.True(result);
        }

        [Fact]
        public static void NumberNotExistsInNumberArray() {
            var result = 1.In(new int[] {2, 3});

            Assert.False(result);
        }
    }
}