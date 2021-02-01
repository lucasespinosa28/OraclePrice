using Nethereum.Web3;
using System;
using TokenPrice.Core;

namespace ConsoleApp1
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var web3  = new Web3("https://mainnet.infura.io/v3/02d86dbe025647f9b912fad4d9e82397");
            var AssetsPrices = new GetAave
            {
                Web3 = web3
            };
            var tokensAddress = new string[] { "0xdAC17F958D2ee523a2206206994597C13D831ec7", "0x6b175474e89094c44da98b954eedeac495271d0f", "0x0000000000085d4780B73119b644AE5ecd22b376" };
            
            var result = await AssetsPrices.GetAssetsPricesAsync("0xA50ba011c48153De246E5192C8f9258A2ba79Ca9", tokensAddress);

            Console.WriteLine(result.PricesInEth);;

        }
    }
}
