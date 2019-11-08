using System;
using Xunit;

namespace ExtensionTests
{
    using CSharp.Extensions;
    using Xunit;

    public class StringTest
    {
        [Fact]
        public void StringExistsInStringArray()
        {
            var result = StringExtensions.In("Hello", new String[] {"Hi", "Hello", "Hola"});

            Assert.True(result);
        }
    }
}
