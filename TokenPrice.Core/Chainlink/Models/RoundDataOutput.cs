using Nethereum.ABI.FunctionEncoding.Attributes;
using System.Numerics;

namespace TokenPrice.Core.Chainlink
{
    public partial class Models
    {
        [FunctionOutput]
        public class RoundDataOfOutputDTO : IFunctionOutputDTO
        {
            [Parameter("uint80", "roundId", 1)]
            public BigInteger RoundId { get; set; }

            [Parameter("uint256", "answer", 2)]
            public BigInteger Answer { get; set; }

            [Parameter("uint256", "startedAt", 3)]
            public long StartedAt { get; set; }

            [Parameter("uint256", "updatedAt", 4)]
            public long UpdatedAt { get; set; }

            [Parameter("uint80", "answeredInRound", 5)]
            public BigInteger AnsweredInRound { get; set; }
        }
    }
}
