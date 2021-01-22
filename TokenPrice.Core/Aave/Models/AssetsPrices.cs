using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace TokenPrice.Core.Aave
{
    public partial class Models
    {
        [Function("getAssetsPrices")]
        public class AssetsPrices : FunctionMessage
        { 
            [Parameter("address[]", "assets", 1)]
            public string[] Address { get; set; }
        }
    }
}
