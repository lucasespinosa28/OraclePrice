using System;
using System.Numerics;
using System.Threading.Tasks;
using Nethereum.ENS;
using Nethereum.Web3;


namespace PriceOracle.Core
{
    public partial class Utils
    {
        public static async Task<string> EnsToAddress(Web3 web3,string url)
        {
            var ensService = new ENSService(web3);
            return await ensService.ResolveAddressAsync(url);
        }
    }
}
