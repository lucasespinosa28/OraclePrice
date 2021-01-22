using System;


namespace TokenPrice.Core
{
    public partial class Utils
    {
        public static long DatetimeToUnix(DateTimeOffset number) => number.ToUnixTimeSeconds();
    }
}
