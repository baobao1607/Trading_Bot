using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Bot
{

    public enum Signal {None, EnterLong, ExitLong}
    public interface Istrategy
    {
        Signal Generate(Ticker t, Trading_Bot bot);
    }
}
