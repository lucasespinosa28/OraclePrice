using System.Collections.Generic;
using System.Numerics;

namespace TokenPrice.Core.Chainlink
{
    public partial class Models
    {
        public static Dictionary<BigInteger, RoundDataOfOutputDTO> LatestRoundDataPerTimestamp { get; set; } = new Dictionary<BigInteger, RoundDataOfOutputDTO>();
    }
}
