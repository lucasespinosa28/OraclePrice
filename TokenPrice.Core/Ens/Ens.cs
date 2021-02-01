using Nethereum.Web3;
using System;
using Nethereum.ENS;
using System.Threading.Tasks;

namespace PriceOracle.Core
{
    public class Ens
    { 
        public ENSService EnsService { get; set; }
        public Ens(Web3 Web3)
        {
            EnsService = new ENSService(Web3);
        }
        public async Task<string> GetAddress(string token, string currency = "Eth") => await EnsService.ResolveAddressAsync($"{token}-{currency}.data.eth");
    }
}
