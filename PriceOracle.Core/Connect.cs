﻿using Nethereum.Web3;
using Nethereum.Web3.Accounts;

namespace PriceOracle.Core
{
    public class Connect
    {
        public static Web3 Web3 { get; set; } = new Web3("https://mainnet.infura.io/v3/ee20058d36674d109fd4d0df4e5e1112");
    }
}
