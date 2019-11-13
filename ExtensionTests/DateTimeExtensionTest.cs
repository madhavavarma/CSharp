namespace CSharp.ExtensionTests {

    using System;
    using Xunit;
    using CSharp.Extensions;

    public class DateTimeExtensionTest {
        
        [Fact]
        public void DateExistsBetween() 
        {
            var result = DateTime.Now.Between(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
            Assert.True(result);
        }
    }
}