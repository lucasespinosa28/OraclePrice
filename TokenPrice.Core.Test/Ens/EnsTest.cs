using TokenPrice.Core;
using TokenPrice.Core.Test;
using Xunit;


namespace EnsTest
{
    public class EnsTest
    {
        [Fact]
        public async void TestAnddress1parm()
        {
            var Ens = new Ens(Neth.GetWeb3);
            var address = await Ens.GetAddress("Link");
            Assert.Equal("0xdc530d9457755926550b59e8eccdae7624181557", address);
        }
        [Fact]
        public async void TestAnddress2parm()
        {
            var Ens = new Ens(Neth.GetWeb3);
            var address = await Ens.GetAddress("aave","usd");
            Assert.Equal("0x547a514d5e3769680Ce22B2361c10Ea13619e8a9".ToLower(), address);
        }

    }
}
