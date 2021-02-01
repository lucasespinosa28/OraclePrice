using System;


namespace PriceOracle.Core
{
    public partial class Utils
    {
        public static DateTimeOffset UnixToDateTime(long number) => DateTimeOffset.FromUnixTimeSeconds(number);
    }
}
