using System;
using System.Numerics;


namespace TokenPrice.Core
{
    public partial class Utils
    {
        public static decimal Percentage(BigInteger number)
        {
            var lastNumber = number.ToString("D27").Remove(4);
            return decimal.Parse($"{lastNumber[0]}{lastNumber[1]},{lastNumber[2]}{lastNumber[3]}");
        }
    }
}
