using static TokenPrice.Core.Utils;
using System;
using Xunit;


namespace Utils
{
    public partial class ConvertTest
    {
        [Fact]
        public void DatetimeToUnixTest()
        {
            var Now = DateTimeOffset.Parse("18/01/2021 2:04pm -03:00");
            Assert.Equal("1610989440", DatetimeToUnix(Now).ToString());
        }
    }
}
