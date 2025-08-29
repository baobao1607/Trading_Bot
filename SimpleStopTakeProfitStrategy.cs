using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Bot
{
    public class SimpleStopTakeProfitStrategy: Istrategy
    {
        public Signal Generate(Ticker t, Trading_Bot bot)
        {
            double price = t.close;

            if (!bot.HasOpenPosition())
            {
                return Signal.EnterLong;
            }
            else
            {
                double entry = bot.currentPosition().entry_price;
                if (price >= entry * 1.0002 || price <= entry * 0.998)
                    return Signal.ExitLong;
            }

            return Signal.None;
        }
    }
}
