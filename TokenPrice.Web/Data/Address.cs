using System.Collections.Generic;

namespace TokenPrice.Web.Data
{
    public partial class Database
    {

        public static List<(string, string)> AddressAndContract { get; set; } = new List<(string, string)>
        {
           // ("", "0x5f4eC3Df9cbd43714FE2740f5E3616155c5b8419"),
            ("0xdAC17F958D2ee523a2206206994597C13D831ec7", "0x6Df09E975c830ECae5bd4eD9d90f3A95a4f88012"),
            ("0x6b175474e89094c44da98b954eedeac495271d0f", "0x24551a8Fb2A7211A25a17B1481f043A8a8adC7f2"),
            ("0x0000000000085d4780B73119b644AE5ecd22b376", "0xEe9F2375b4bdF6387aa8265dD4FB8F16512A1d46"),
          
        };
        //var tokensAddress = new string[] { "0xdAC17F958D2ee523a2206206994597C13D831ec7", "0x6b175474e89094c44da98b954eedeac495271d0f", "0x0000000000085d4780B73119b644AE5ecd22b376" };
    }
}
