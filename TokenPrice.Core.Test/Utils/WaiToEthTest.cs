using System.Numerics;
using Xunit;
using static TokenPrice.Core.Utils;


namespace Utils
{
    public partial class ConvertTest
    {
        public class WaiToEth
        {
            [Fact]
            public void Eth10()
            {
                BigInteger Eth = new BigInteger(1e19);
                Assert.Equal(10M, WeiToEth(Eth));
            }
            [Fact]
            public void Eth1()
            {
                BigInteger Eth = new BigInteger(1e18);
                Assert.Equal(1M, WeiToEth(Eth));
            }
            [Fact]
            public void Eth01()
            {
                BigInteger Eth = new BigInteger(1e17);
                Assert.Equal(0.1M, WeiToEth(Eth));
            }
            [Fact]
            public void Eth001()
            {
                BigInteger Eth = new BigInteger(1e16);
                Assert.Equal(0.01M, WeiToEth(Eth));
            }
        }
    }
}
