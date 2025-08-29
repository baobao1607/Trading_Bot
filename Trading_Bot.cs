using ScottPlot.Finance;
using ScottPlot.Plottables;
using ScottPlot.Rendering.RenderActions;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Bot
{
    public class Trading_Bot
    {
        private double cash_balance;
        Position position;
        Dictionary<string, Trade> tradeHistory;
        List<Ticker> list_of_past_ticker;
        Trade trade;
        private Action<double> reportProfit;
        private Action<double> reportBalance;
        private double total_profit = 0;
        private Istrategy strategy;

        public Trading_Bot(double initial_cash_balance, Action<double> reportProfit, Action<double> reportBalance, Istrategy strategy)
        {
            this.cash_balance = initial_cash_balance;
            this.reportProfit = reportProfit;
            this.reportBalance = reportBalance;
            this.position = null;
            this.tradeHistory = new Dictionary<string, Trade>();
            this.list_of_past_ticker = new List<Ticker>();
            this.trade = null;
            this.strategy = strategy;
        }

        public void New_OHLC(Ticker new_ticker)
        {
            list_of_past_ticker.Add(new_ticker);

            Signal signal = strategy.Generate(new_ticker, this);

            if (signal == Signal.EnterLong && position == null)
                Buy(new_ticker.close, new_ticker.date, new_ticker.Symbol);

            else if (signal == Signal.ExitLong && position != null)
                Sell(new_ticker.close, new_ticker.date, new_ticker.Symbol);
        }



        public void Buy(double price, DateTime time, string symbol)
        {
            if (position != null) return;

            int quantity = (int)Math.Floor(cash_balance / price);
            if (quantity <= 0) return;

            double cost = quantity * price;
            cash_balance -= cost;

            position = new Position(price, quantity, time, symbol);
        }

        public void Sell(double price, DateTime time, string symbol)
        {
            if (position == null) return;
            Execute(price, time, symbol);
        }

        public void Execute(double exit_price, DateTime exit_time, string symbol)
        {
            int quantity = position.quantity;
            double proceeds = exit_price * quantity;
            double entry_price = position.entry_price;
            double profit = (exit_price - entry_price) * quantity;

            total_profit += profit;
            cash_balance += proceeds;

            trade = new Trade(symbol, position.entrytime, exit_time, entry_price, exit_price, quantity);
            string key = $"{symbol}-{position.entrytime:yyyyMMdd-HHmmss}";
            tradeHistory[key] = trade;

            position = null;

            reportProfit?.Invoke(total_profit);
            reportBalance?.Invoke(cash_balance);
        }

        public bool HasOpenPosition()
        {
            return position != null;
        }


        public Position currentPosition()
        {
            return position;
        }


    }
}
