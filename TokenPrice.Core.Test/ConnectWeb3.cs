using System;
using System.Collections.Generic;
using System.Text;
using Nethereum.Web3;
namespace TokenPrice.Core.Test
{
    public class neth
    {
        public static Web3 web3 { get; set; } = new Web3("https://mainnet.infura.io/v3/0");
    }
}
