using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace TokenPrice.Core.Aave
{
    public partial class Models
    {
        [FunctionOutput]
        public class AssetsPricesOutput : IFunctionOutputDTO
        { 
            [Parameter("uint256[]","",1)]
            public BigInteger[] PricesInEth { get; set; }

        }
    }
}
