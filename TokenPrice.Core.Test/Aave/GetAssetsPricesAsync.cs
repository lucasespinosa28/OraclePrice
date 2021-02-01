using PriceOracle.Core;
using PriceOracle.Core.Test;
using System.Numerics;
using Xunit;


namespace Aave
{
    public class GetAssetsPricesAsync
    {
        [Fact]
        public async void TestValid()
        {
            var AssetsPrices = new GetAave
            {
                Web3 = Neth.GetWeb3
            };
            var tokensAddress = new string[] { "0xdAC17F958D2ee523a2206206994597C13D831ec7", "0x6b175474e89094c44da98b954eedeac495271d0f", "0x0000000000085d4780B73119b644AE5ecd22b376" };
            var result = await AssetsPrices.GetAssetsPricesAsync("0xA50ba011c48153De246E5192C8f9258A2ba79Ca9", tokensAddress);
            Assert.NotNull(result.PricesInEth);
        }
    }
}
