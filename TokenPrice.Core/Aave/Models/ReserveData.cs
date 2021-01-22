using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace TokenPrice.Core.Aave
{
    public partial class Models
    {
        [Function("getReserveData")]
        public class ReserveData : FunctionMessage
        { 
            [Parameter("address","asset",1)]
            public string Address { get; set; }
        }
    }
}
