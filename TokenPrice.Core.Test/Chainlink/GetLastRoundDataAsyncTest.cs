using PriceOracle.Core;
using PriceOracle.Core.Test;
using Xunit;


namespace Chainlink
{
    public class GetLastRoundDataAsyncTest
    {
        [Fact]
        public async void LastRoundDataHasData()
        {
            var price = new PriceOracle.Core.Chainlink.Oracle
            {
                Web3 = Neth.GetWeb3
            };

            var data = await price.GetLastRoundDataAsync("0xDC530D9457755926550b59e8ECcdaE7624181557");
            Assert.NotNull(data);
            Assert.NotEqual(0, data.Answer);
            Assert.NotEqual(0, data.RoundId);
            Assert.NotEqual(0, data.UpdatedAt);
        }
    }
}
