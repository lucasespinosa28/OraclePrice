using System;
using Nethereum.Web3;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts.CQS;
using Nethereum.Util;
using Nethereum.Web3.Accounts;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Contracts;
using Nethereum.Contracts.Extensions;
using System.Numerics;

namespace TokenPrice.Core
{
    public class Web3Connect
    {
        string url = "https://mainnet.infura.io/v3/6c7c3d0d23e74d2f8e0631662c50af95";
        string privateKey = "334274fca6ad64d523d9dee7c8e98d54d5cfc23f28eb4f811a8238f6fc13fd11";
        var account = new Account(privateKey);
        var web3 = new Web3(account, url);

    }
}
