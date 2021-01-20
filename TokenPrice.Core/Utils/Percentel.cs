using Nethereum.Web3;
using System;
using System.Numerics;


namespace TokenPrice.Core
{
    public partial class Utils
    {
        public static decimal Percentage(decimal AtualPrice, decimal OldPrice)
        {
            var subtraction = AtualPrice - OldPrice;
            if (subtraction < 0)
            {
                return subtraction / Math.Abs(AtualPrice) * 100;
            }
            else
            {
                return subtraction / Math.Abs(OldPrice) * 100;
            }
        }
    }
}
