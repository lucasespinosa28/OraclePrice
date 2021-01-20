using static TokenPrice.Core.Utils;
using System;
using Xunit;


namespace Utils
{
    public partial class ConvertTest
    {
        [Fact]
        public void UnixToDateTimeTest()
        {
            long Date = 1610989440;
            Assert.Equal("18/01/2021 17:04:00 +00:00", UnixToDateTime(Date).ToString());
        }
    }
}
