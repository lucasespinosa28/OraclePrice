using Nethereum.Web3;
using System;
using System.Numerics;


namespace TokenPrice.Core
{
    public partial class Utils
    {
        public static long DatetimeToUnix(DateTimeOffset number) => number.ToUnixTimeSeconds();
    }
}
