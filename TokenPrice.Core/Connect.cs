using Nethereum.Web3;
using Nethereum.Web3.Accounts;

namespace TokenPrice.Core
{
    public class Connect
    {
        //string url = "";
        //string privateKey = "334274fca6ad64d523d9dee7c8e98d54d5cfc23f28eb4f811a8238f6fc13fd11";
        public static Web3 Web3(string privateKey, string url) => new Web3(new Account(privateKey), url);



    }
}
