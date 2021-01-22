using System;


namespace TokenPrice.Core
{
    public partial class Utils
    {
        public static DateTimeOffset UnixToDateTime(long number) => DateTimeOffset.FromUnixTimeSeconds(number);
    }
}
