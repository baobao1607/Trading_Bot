using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Bot
{
    public class Position
    {
        public double entry_price {  get; set; }
        public int quantity { get; set; }
        public DateTime entrytime { get; set; }
        public string symbol { get; set; }
        public Position()
        {

        }

        public Position(double entry_price, int quantity, DateTime entrytime, string symbol)
        {
            this.entry_price = entry_price;
            this.quantity = quantity;
            this.entrytime = entrytime;
            this.symbol = symbol;
        }



    }
}
