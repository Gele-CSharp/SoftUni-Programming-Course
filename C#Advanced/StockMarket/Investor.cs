using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        private List<Stock> portfolio;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            portfolio = new List<Stock>();
        }

        public string FullName { get; private set; }

        public string EmailAddress { get; private set; }

        public decimal MoneyToInvest { get; private set; }

        public string BrokerName { get; private set; }

        public int Count { get; set; }


        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest - stock.PricePerShare >= 0)
            {
                portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
                Count++;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            if (portfolio.Select(p=> p.CompanyName).Contains(companyName) == false)
            {
                return $"{companyName} does not exist.".ToString();
            }

            Stock stockToSell = portfolio.Where(p => p.CompanyName == companyName).FirstOrDefault();

            if (stockToSell.PricePerShare > sellPrice)
            {
                return $"Cannot sell {companyName}.".ToString();
            }

            portfolio.Remove(stockToSell);
            MoneyToInvest += sellPrice;
            Count--;
            return $"{companyName} was sold.".ToString();
        }

        public Stock FindStock(string companyName)
        {
            Stock stock = portfolio.Where(p => p.CompanyName == companyName).FirstOrDefault();
            return stock;
        }

        public Stock FindBiggestCompany()
        {
            Stock biggestMarketCapitalization = portfolio.OrderByDescending(p => p.MarketCapitalization).FirstOrDefault();
            return biggestMarketCapitalization;
        }

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");

            foreach (var stock in portfolio)
            {
                sb.AppendLine(stock.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
