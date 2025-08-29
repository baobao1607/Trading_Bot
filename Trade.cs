using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Trading_Bot
{
    public class Trade
    {
        public string Symbol { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }

        public double EntryPrice { get; set; }
        public double ExitPrice { get; set; }

        public int Quantity { get; set; }

        public double Profit { get; set; }

        public Trade()
        {

        }

        public Trade(string symbol, DateTime entryTime, DateTime exitTime, double entryPrice, double exitPrice, int quantity)
        {
            Symbol = symbol;
            EntryTime = entryTime;
            ExitTime = exitTime;
            EntryPrice = entryPrice;
            ExitPrice = exitPrice;
            Quantity = quantity;
            Profit = ( ExitPrice - EntryPrice ) * quantity;
        }
    }
}
