using TokenPrice.Core;
using TokenPrice.Core.Test;
using System.Numerics;
using Xunit;


namespace Chainlink
{
    public class GetReserveDataAsyncTest
    {
        [Fact]
        public async void GetRoundDataAsync()
        {
            var price = new TokenPrice.Core.Chainlink.Oracle
            {
                Web3 = neth.web3
            };
            var roundId = BigInteger.Parse("18446744073709553596");
            var data = await price.GetRoundDataAsync("0x6Df09E975c830ECae5bd4eD9d90f3A95a4f88012", roundId);
            Assert.NotNull(data);
            Assert.NotEqual(0, data.Answer);
            Assert.NotEqual(0, data.RoundId);
            Assert.NotEqual(0, data.UpdatedAt);
        }
    }
}
