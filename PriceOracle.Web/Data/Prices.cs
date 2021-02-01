using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceOracle.Web.Data
{
    public partial class TokenPrices
    {
        public class Prices
        {
            public decimal Eth { get; set; }
            public decimal Usd { get; set; }
        }
        public static Dictionary<string, Prices> data = new Dictionary<string, Prices>();
    }
}
