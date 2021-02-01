using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Nethereum.Web3;

namespace TokenPrice.Core.Erc20
{
    public class Erc20
    {
        public Web3 Web { get; set; }
        public Erc20(Web3 web3)
        {
            Web = web3;
        }
        public async Task<BigInteger> GeTotalSupplyAsync(string contract)
        {
            var descriptionOfFunction = new Models.TotalSupplyOfFunction();
            var contractQueryHandler = Web.Eth.GetContractQueryHandler<Models.TotalSupplyOfFunction>();
            return await contractQueryHandler.QueryAsync<BigInteger>(contract, descriptionOfFunction);
        }
        public async Task<BigInteger> GetDecimalsAsync(string contract)
        {
            var decimalOfFunction = new Models.DecimalOfFunction();
            var contractQueryHandler = Web.Eth.GetContractQueryHandler<Models.DecimalOfFunction>();
            return await contractQueryHandler.QueryAsync<BigInteger>(contract, decimalOfFunction);
        }
        public async Task<string> GetSymbolAsync(string contract)
        {
            var symbolOfFunction = new Models.SymbolOfFunction();
            var contractQueryHandler = Web.Eth.GetContractQueryHandler<Models.SymbolOfFunction>();
            return await contractQueryHandler.QueryAsync<string>(contract, symbolOfFunction);
        }

        public async Task<string> GetNameAsync(string contract,string alternativeName)
        {
            var DescriptionFunctionMessage = new Models.NameOfFunction();
            var DescriptionHandler = Web.Eth.GetContractQueryHandler<Models.NameOfFunction>();
            try
            {
                return await DescriptionHandler.QueryAsync<string>(contract, DescriptionFunctionMessage);
            }
            catch (Exception e)
            {
                return alternativeName;
            }
        }
    }
}
