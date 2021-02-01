using PriceOracle.Core;
using PriceOracle.Core.Test;
using Xunit;


namespace TokenInfoTest
{
    public class TokenInfoTest
    {
        public TokenInfo Token { get; set; } = new TokenInfo
        {
            Web3 = Neth.GetWeb3
        };
        [Fact]
        public async void TokenNameTest()
        {
            var name = await Token.GetNameAsync("0x514910771af9ca656af840dff83e8264ecf986ca");
            Assert.Equal("ChainLink Token", name);
        }
        [Fact]
        public async void TokenSymbolTest()
        {
            var symbol = await Token.GetSymbolAsync("0x514910771af9ca656af840dff83e8264ecf986ca");
            Assert.Equal("LINK", symbol);
        }
        [Fact]
        public async void TokenDecimalslTest()
        {
            var Decimals = await Token.GetDecimalsAsync("0x514910771af9ca656af840dff83e8264ecf986ca");
            Assert.Equal(18, Decimals);
        }
        [Fact]
        public async void TokenTotalSupplyTest()
        {
            var TotalSupply = await Token.GetTotalSupplyAsync("0x514910771af9ca656af840dff83e8264ecf986ca",18);
            Assert.True(TotalSupply > 0);
        }
    }
}
