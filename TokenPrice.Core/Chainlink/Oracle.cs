using System;
using System.Collections.Generic;
using TokenPrice.Core.Chainlink;
using System.Text;
using System.Numerics;
using static TokenPrice.Core.Chainlink.Models;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System.Threading.Tasks;

namespace TokenPrice.Core.Chainlink
{
    public class Oracle
    {
        public Web3 Web3 { get; set; }
        public async Task<RoundDataOfOutputDTO> GetLastRoundDataAsync(string contractAddress)
        {
            var priceHandler = Web3.Eth.GetContractQueryHandler<LatestRoundData>();
            var priceOfFunctionMessage = new LatestRoundData() { };
            return await priceHandler.QueryDeserializingToObjectAsync<RoundDataOfOutputDTO>(priceOfFunctionMessage, contractAddress);
        }
        public async Task<RoundDataOfOutputDTO> GetRoundDataAsync(string contractAddress, string roundId)
        {
            var priceHandler = Web3.Eth.GetContractQueryHandler<GetRoundData>();
            var priceOfFunctionMessage = new GetRoundData()
            {
                RoundId = BigInteger.Parse(roundId)
            };
            return await priceHandler.QueryDeserializingToObjectAsync<RoundDataOfOutputDTO>(priceOfFunctionMessage, contractAddress);
        }
        public async Task<string[]> GetDescriptionAsync(string contractAddress)
        {
            var descriptionOfFunctionMessage = new DescriptionOfFunction()
            {
            };
            var descriptionHandler = Web3.Eth.GetContractQueryHandler<DescriptionOfFunction>();
            string description = await descriptionHandler.QueryAsync<string>(contractAddress, descriptionOfFunctionMessage);
            return description.Replace(" ", "").Split("/");
        }
    }
}

//public static Tuple<string, string>[] Token = {
//    Tuple.Create("", "0x5f4eC3Df9cbd43714FE2740f5E3616155c5b8419"),
//    Tuple.Create("0x7fc66500c84a76ad7e9c93437bfc5ac33e2ddae9", "0x6Df09E975c830ECae5bd4eD9d90f3A95a4f88012"),
//    Tuple.Create("0x6b175474e89094c44da98b954eedeac495271d0f", "0x22B58f1EbEDfCA50feF632bD73368b2FdA96D541"),
//    Tuple.Create("0x9f8f72aa9304c8b593d555f12ef6589cc3a579a2", "0x24551a8Fb2A7211A25a17B1481f043A8a8adC7f2"),
//    Tuple.Create("0xdac17f958d2ee523a2206206994597c13d831ec7", "0xEe9F2375b4bdF6387aa8265dD4FB8F16512A1d46"),

//    Tuple.Create("0x0d8775f648430679a709e98d2b0cb6250d2887ef", "0x0d16d4528239e9ee52fa531af613AcdB23D88c94"),
//    Tuple.Create("0x0f5d2fb29fb7d3cfee444a200298f468908cc942", "0x82A44D92D6c329826dc557c5E1Be6ebeC5D5FeB9"),
//    Tuple.Create("0x6b175474e89094c44da98b954eedeac495271d0f", "0x22B58f1EbEDfCA50feF632bD73368b2FdA96D541"),
//    Tuple.Create("0xf629cbd94d3791c9250152bd8dfbdf380e2a3b9c", "0x24D9aB51950F3d62E9144fdC2f3135DAA6Ce8D1B"),
//    Tuple.Create("0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48", "0xEe9F2375b4bdF6387aa8265dD4FB8F16512A1d46"),
//};
