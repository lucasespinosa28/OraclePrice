using Xunit;
using static TokenPrice.Core.Utils;


namespace Utils
{
    public partial class ConvertTest
    {
        public class PercentelTest
        {
            [Fact]
            public void Negative()
            {
                var percentel = Percentage(3M, 3.3M);
                Assert.Equal(-10.00M, percentel);
            }
            [Fact]
            public void Positive()
            {
                var percentel = Percentage(5.5M, 5M);
                Assert.Equal(10.00M, percentel);
            }

        }
    }
}
