using Nethereum.Web3;
using Nethereum.Web3.Accounts;

namespace TokenPrice.Core
{
    public class Connect
    {
        public static Web3 Web3 { get; set; } = new Web3("https://mainnet.infura.io/v3/");
    }
}
