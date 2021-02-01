using System.Numerics;

namespace TokenPrice.Web.Data
{
    public static class EthereumiInfo
    {

        public static string Name { get; set; } = "Ethereum";
        public static string Symbol { get; set; } = "ETH";
        public static string Addresss { get; set; } = "0x0";
        public static decimal LastPriceEth { get; set; } = 0m;
        public static  BigInteger TotalSupply { get; set; } = new BigInteger(114370210.03);

    }
}
