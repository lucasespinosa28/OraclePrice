using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.Text;
using TokenPrice.Core.Aave;
using System.Threading.Tasks;
using System.Numerics;

namespace TokenPrice.Core
{
    public partial class GetAave
    {
        public Web3 Web3 { get; set; }
        public async Task<Models.ReserveDataOutput> GetReserveDataAsync(string contractAddress,string tokenAddresss)
        {
            var ReserveDataHandler = Web3.Eth.GetContractQueryHandler<Models.ReserveData>();
            var ReserveDataOfFunctionMessage = new Models.ReserveData() { Address = tokenAddresss };
            return await ReserveDataHandler.QueryDeserializingToObjectAsync<Models.ReserveDataOutput>(ReserveDataOfFunctionMessage, contractAddress);
        }
        public async Task<BigInteger[]> GetAssetsPricesAsync(string contractAddress, string[] tokenAddresss)
        {
            var AssetsPricesHandler = Web3.Eth.GetContractQueryHandler<Models.AssetsPrices>();
            var AssetsPricesFunctionMessage = new Models.AssetsPrices() { Address = tokenAddresss };
            return await AssetsPricesHandler.QueryAsync<BigInteger[]>(contractAddress, AssetsPricesFunctionMessage);
        }
    }
}
