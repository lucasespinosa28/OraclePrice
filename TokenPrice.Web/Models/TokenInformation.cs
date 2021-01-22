namespace TokenPrice.Web.Models
{
    public class TokenInformation
    {
        public string Name { get; set; }
        //public string Addresss { get; set; }
        public decimal LastPriceEth { get; set; }
        //public BigInteger LastPriceUsd { get; set; }
        //public List<(DateTimeOffset, BigInteger)> HistoricalPrice { get; set; } = null;
    }
}
