using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace TokenPrice.Web.Class
{
    public class Ether
    {
        [Function("description", "string")]
        public class DescriptionOfFunction : FunctionMessage { }
        //public static async Task<Nethereum.Hex.HexTypes.HexBigInteger> testAsync()
        //{
        //    var web3 = new Web3("");
        //    return await web3.Eth.Mining.Hashrate.SendRequestAsync();


        //}
    }
}
