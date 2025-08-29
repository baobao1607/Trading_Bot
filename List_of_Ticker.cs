using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Bot
{
    public class List_of_Ticker
    {
        public List<Ticker> list_of_ticker = new List<Ticker>();


        public List_of_Ticker()
        {

        }

        public List_of_Ticker(string file_path)
        {
            var lines = File.ReadAllLines(file_path).Skip(1);
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                else
                {
                    list_of_ticker.Add(new Ticker(line));
                }
            }
        }
    }
}
