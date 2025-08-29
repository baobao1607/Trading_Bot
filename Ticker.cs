using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Bot
{
    public class Ticker
    {
        public DateTime date { get; set; }
        public double open { get; set; }
        public double high { get; set; }

        public double low { get; set; }

        public double close { get; set; }

        public long Volume { get; set; }

        public string Symbol { get; set; }

        public Ticker()
        {

        }

        public Ticker(string row_of_data, string name)
        {
            var parts = row_of_data.Split(',');
            this.Symbol = name;
            this.date = DateTime.Parse(parts[0]);
            this.open = Double.Parse(parts[1]);
            this.high = Double.Parse(parts[2]);
            this.low = Double.Parse(parts[3]);
            this.close = Double.Parse(parts[4]);
            this.Volume = long.Parse(parts[5]);
        }
    }
    }
