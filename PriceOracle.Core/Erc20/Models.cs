using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace PriceOracle.Core.Erc20
{
    public class Models
    {
        [Function("totalSupply", "uint256")]
        public class TotalSupplyOfFunction : FunctionMessage { }

        [Function("decimals", "uint256")]
        public class DecimalOfFunction : FunctionMessage { }

        [Function("symbol", "string")]
        public class SymbolOfFunction : FunctionMessage { }

        [Function("name", "string")]
        public class NameOfFunction : FunctionMessage
        {
        }
    }
}
