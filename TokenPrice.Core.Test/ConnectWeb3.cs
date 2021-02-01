using System;
using System.Collections.Generic;
using System.Text;
using Nethereum.Web3;
namespace TokenPrice.Core.Test
{
    public class Neth
    {
        public static Web3 GetWeb3 { get; set; } = new Web3("https://mainnet.infura.io/v3/");
    }
}
