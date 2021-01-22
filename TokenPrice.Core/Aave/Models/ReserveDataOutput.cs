using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace TokenPrice.Core.Aave
{
    public partial class Models
    {
        [FunctionOutput]
        public class ReserveDataOutput : IFunctionOutputDTO
        { 
            [Parameter("uint256", "availableLiquidity", 1)]
            public BigInteger AvailableLiquidity { get; set; }

            [Parameter("uint256", "totalStableDebt", 2)]
            public BigInteger TotalStableDebt { get; set; }

            [Parameter("uint256", "totalVariableDebt", 3)]
            public BigInteger TotalVariableDebt { get; set; }

            [Parameter("uint256", "liquidityRate", 4)]
            public BigInteger LiquidityRate { get; set; }

            [Parameter("uint256", "variableBorrowRate", 5)]
            public BigInteger VariableBorrowRate { get; set; }

            [Parameter("uint256", "stableBorrowRate", 6)]
            public BigInteger StableBorrowRate { get; set; }

            [Parameter("uint256", "averageStableBorrowRate", 7)]
            public BigInteger AverageStableBorrowRate { get; set; }
            [Parameter("uint256", "liquidityIndex", 8)]
            public BigInteger LiquidityIndex { get; set; }

            [Parameter("uint256", "variableBorrowIndex", 8)]
            public BigInteger VariableBorrowIndex { get; set; }
            [Parameter("uint40", "lastUpdateTimestamp", 9)]
            public BigInteger LastUpdateTimestamp { get; set; }
        }
    }
}
