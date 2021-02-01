using TokenPrice.Core;
using TokenPrice.Core.Test;
using Xunit;


namespace Chainlink
{
    public class GetDescriptionAsyncTest
    {
        [Fact]
        public async void TestAaveDescription()
        {
            var price = new TokenPrice.Core.Chainlink.Oracle
            {
                Web3 = Neth.GetWeb3
            };
            var data = await price.GetDescriptionAsync("0xDC530D9457755926550b59e8ECcdaE7624181557");
            Assert.Equal("LINK", data[0]);
            Assert.Equal("ETH", data[1]);
        }
    }
}
