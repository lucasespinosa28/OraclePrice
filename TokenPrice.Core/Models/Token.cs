using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TokenPrice.Core.Models
{
    public class Token
    {
        public bool Open { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal PriceUsd { get; set; }
        public decimal PriceEth { get; set; }
        public decimal Liquidity { get; set; }
        public decimal StableBorrow { get; set; }
        public decimal VariableBorrow { get; set; }
        public BigInteger TotalSupply { get; set; }
        public string OracleAddress { get; set; }
        public BigInteger Decimals { get; set; }
    }
}
