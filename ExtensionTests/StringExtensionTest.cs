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
            var result = "Hello".In(new String[] {"Hi", "Hello", "Hola"});

            Assert.True(result);
        }

        [Fact]
        public void StringNotExistsInStringArray()
        {
            var result = "Hello".In(new String[] {"Hi", "Hola"});

            Assert.False(result);
        }
    }
}
