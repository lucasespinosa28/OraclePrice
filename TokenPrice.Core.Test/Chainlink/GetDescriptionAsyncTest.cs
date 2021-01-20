using Nethereum.Web3;
using TokenPrice.Core;
using Xunit;


namespace Chainlink
{
    public class GetDescriptionAsyncTest
    {
        [Fact]
        public async void TokenAndBase()
        {
            var price = new TokenPrice.Core.Chainlink.Oracle
            {
                Web3 = Connect.Web3("334274fca6ad64d523d9dee7c8e98d54d5cfc23f28eb4f811a8238f6fc13fd11", "")
            };
            var data = await price.GetDescriptionAsync("0xDC530D9457755926550b59e8ECcdaE7624181557");
            Assert.Equal("LINK",data[0]);
            Assert.Equal("ETH",data[1]);
        }
    }
}
