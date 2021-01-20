using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace TokenPrice.Core.Chainlink
{
    public partial class Models
    {
        [Function("getRoundData")]
        public class GetRoundData : FunctionMessage 
        {
            [Parameter("uint80", "_roundId", 1)]
            public BigInteger RoundId { get; set; }
        }
    }
}
