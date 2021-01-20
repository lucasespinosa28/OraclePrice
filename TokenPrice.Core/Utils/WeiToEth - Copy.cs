using Nethereum.Web3;
using System.Numerics;


namespace TokenPrice.Core
{
    public partial class Utils
    {
        public static decimal WeiToEth(BigInteger number) => Web3.Convert.FromWei(number);
    }
}
