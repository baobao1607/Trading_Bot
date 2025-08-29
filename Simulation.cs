using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trading_Bot
{
    public class Simulation
    {
        List<Ticker> list_of_ticker = new List<Ticker>();
        List<OHLC> list_of_OHLC = new List<OHLC>();
        private int tickerIndex = 0;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private FormsPlot formsplot;
        private Trading_Bot bot;
        private Form1 mainForm;
        private bool current_view;
        private double lastSetXMin, lastSetXMax;
        private double lastSetYMin, lastSetYMax;
        public int time_interval { get; set; }
        private int timeframeMinutes = 1;
        private ScottPlot.Multiplot multiplot;
        private ScottPlot.Plot pricePlot;
        private ScottPlot.Plot volumePlot;
        private List<double> list_of_volumes;

        public  Simulation (FormsPlot plot, string file_path, Form1 form)
        {
            list_of_volumes = new List<double>(); 
            this.mainForm = form;
            this.formsplot = plot;
            this.list_of_ticker = Build_List_Of_Ticker(file_path);
            Istrategy strat = new SimpleStopTakeProfitStrategy();
            bot = new Trading_Bot(10000, form.UpdateProfitLabel, form.UpdateBalance, strat);
            AddNextTicker();
            Feed_bot();
            Initialize_plot();
            InitializeTimer();
        }


        public void Feed_bot()
        {
            Ticker current_ticker = list_of_ticker[tickerIndex - 1];
            bot.New_OHLC(current_ticker);
        }


        public void SetTimeframe(int minutes)
        {
            timeframeMinutes = minutes;
        }


        public void SetSpeed(int timeinterval)
        {
            if (timer != null)
            {
                timer.Interval = timeinterval;
            }
        }


        private void AddNextTicker()
        {
            if (tickerIndex >= list_of_ticker.Count)
                return;
            var t = list_of_ticker[tickerIndex++];
            var ticker_OHLC = new OHLC(
                open: (double)t.open,
                high: (double)t.high,
                low: (double)t.low,
                close: (double)t.close,
                start: t.date,
                span: TimeSpan.FromMinutes(1)
            );
            list_of_OHLC.Add(ticker_OHLC);
            list_of_volumes.Add((double)t.Volume);
        }


        private void InitializeTimer()
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AddNextTicker();
            Feed_bot();

            if (list_of_OHLC.Count < 1)
                return;

            if (current_view && HasUserChangedView())
                current_view = false;

            pricePlot.Clear();
            volumePlot.Clear();

            var (chartOHLC, chartVolumes) = AggregateForChart();

            if (current_view)
            {

                var last5 = chartOHLC.Skip(Math.Max(0, chartOHLC.Count - 5)).ToList();
                pricePlot.Add.Candlestick(last5);

                double padding = 0.001;
                double xMin = last5.First().DateTime.ToOADate() - padding;
                double xMax = last5.Last().DateTime.ToOADate() + padding * 2;
                double yMin = last5.Min(t => t.Low) - 0.2;
                double yMax = last5.Max(t => t.High) + 0.2;


                pricePlot.Axes.SetLimits(xMin, xMax, yMin, yMax);


                volumePlot.Axes.SetLimitsX(xMin, xMax);

                double[] xs = last5.Select(o => o.DateTime.ToOADate()).ToArray();
                double[] ys = chartVolumes.Skip(Math.Max(0, chartVolumes.Count - 5)).ToArray();

                double barWidth = TimeSpan.FromMinutes(timeframeMinutes).TotalDays * 0.8;

                var bars = xs.Zip(ys, (x, y) => new ScottPlot.Bar()
                {
                    Position = x,
                    Value = y,
                    ValueBase = 0,
                    FillColor = Colors.SteelBlue,
                    Size = barWidth
                }).ToArray();

                volumePlot.Add.Bars(bars);

                lastSetXMin = xMin;
                lastSetXMax = xMax;
                lastSetYMin = yMin;
                lastSetYMax = yMax;
            }
            else
            {

                pricePlot.Add.Candlestick(chartOHLC);

                var currentLimits = pricePlot.Axes.GetLimits();
                pricePlot.Axes.SetLimits(currentLimits);

                volumePlot.Axes.SetLimitsX(currentLimits.Left, currentLimits.Right);

                double[] xs = chartOHLC.Select(o => o.DateTime.ToOADate()).ToArray();
                double[] ys = chartVolumes.Select(v => (double)v).ToArray();

                double barWidth = TimeSpan.FromMinutes(timeframeMinutes).TotalDays * 0.8;

                var bars = xs.Zip(ys, (x, y) => new ScottPlot.Bar()
                {
                    Position = x,
                    Value = y,
                    ValueBase = 0,
                    FillColor = Colors.SteelBlue,
                    Size = barWidth
                }).ToArray();

                volumePlot.Add.Bars(bars);
            }

            formsplot.Refresh();

            if (tickerIndex >= list_of_ticker.Count)
                timer.Stop();
        }



        public (List<OHLC> ohlcs, List<double> volumes) AggregateForChart()
        {
            var aggregated = new List<OHLC>();
            var aggregatedVolumes = new List<double>();
            int tf = timeframeMinutes;

            for (int i = 0; i < list_of_OHLC.Count; i += tf)
            {
                var group = list_of_OHLC.Skip(i).Take(tf).ToList();
                if (group.Count == 0) break;

                var ohlc = new OHLC(
                    open: group.First().Open,
                    high: group.Max(t => t.High),
                    low: group.Min(t => t.Low),
                    close: group.Last().Close,
                    start: group.First().DateTime,
                    span: TimeSpan.FromMinutes(tf)
                );
                aggregated.Add(ohlc);

                double vol = list_of_volumes.Skip(i).Take(tf).Sum();
                aggregatedVolumes.Add(vol);
            }
            return (aggregated,aggregatedVolumes);
        }


        public void Kill()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
        }


        public void Pause()
        {
            if (timer != null)
            {
                timer.Stop();
            }
        }


        public void Resume()
        {
            if (timer != null && !timer.Enabled)
            {
                timer.Start();
            }
        }


        public void Initialize_plot()
        {

            multiplot = new ScottPlot.Multiplot();
            multiplot.AddPlots(2);
            pricePlot = multiplot.Subplots.GetPlot(0);
            volumePlot = multiplot.Subplots.GetPlot(1);
            pricePlot.Add.Candlestick(list_of_OHLC);
            double[] xs = list_of_OHLC.Select(o=>o.DateTime.ToOADate()).ToArray();
            double[] ys = list_of_volumes.Select(v => (double)v).ToArray();

            volumePlot.Add.Bars(xs, ys);
            multiplot.SharedAxes.ShareX(multiplot.GetPlots());

            pricePlot.Title("Price");
            volumePlot.Title("Volume");
            pricePlot.Axes.DateTimeTicksBottom();
            volumePlot.Axes.DateTimeTicksBottom();

            formsplot.Plot.Clear();
            formsplot.Multiplot = multiplot;

            formsplot.Refresh();
            var last5 = list_of_OHLC.Skip(Math.Max(0, list_of_OHLC.Count - 5)).ToList();

            double padding = 0.001;
            lastSetXMin = last5.First().DateTime.ToOADate() - padding;
            lastSetXMax = last5.Last().DateTime.ToOADate() + padding;
            lastSetYMin = last5.Min(t => t.Low) - 0.2;
            lastSetYMax = last5.Max(t => t.High) + 0.2;

            pricePlot.Axes.SetLimits(lastSetXMin, lastSetXMax, lastSetYMin, lastSetYMax);
            volumePlot.Axes.SetLimitsX(lastSetXMin, lastSetXMax);
            current_view = true;


        }


        public List<Ticker> Build_List_Of_Ticker(string file_path)
        {
            string symbol = ExtractSymbol(file_path);
            var list_of_ticker = new List<Ticker>();
            var lines = File.ReadAllLines(file_path).Skip(1);
            foreach (var line in lines)
            {
                Ticker ticker = new Ticker(line, symbol);
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                list_of_ticker.Add(ticker);
            }
            return list_of_ticker;
        }


        public void RefreshToLatest()
        {
            if (list_of_OHLC.Count < 1)
                return;

            var last5 = list_of_OHLC.Skip(Math.Max(0, list_of_OHLC.Count - 5)).ToList();

            double padding = 0.001;

            double xMin = last5.First().DateTime.ToOADate() - padding;
            double xMax = last5.Last().DateTime.ToOADate() + padding;

            pricePlot.Axes.SetLimitsX(xMin, xMax);
            volumePlot.Axes.SetLimitsX(xMin, xMax);

            double yMin = last5.Min(t => t.Low) - 0.2;
            double yMax = last5.Max(t => t.High) + 0.2;
            pricePlot.Axes.SetLimitsY(yMin, yMax);

            formsplot.Refresh();

            lastSetXMin = xMin;
            lastSetXMax = xMax;
            lastSetYMin = yMin;
            lastSetYMax = yMax;
            current_view = true;
        }



        public static String ExtractSymbol (string filepath)
        {
            string filename = System.IO.Path.GetFileName(filepath);
            string[] parts = filename.Split('_');
            return parts[0];
        }


        private bool HasUserChangedView()
        {
            var limits = pricePlot.Axes.GetLimits();
            const double tolerance = 1e-6;
            bool xChanged = Math.Abs(limits.Left - lastSetXMin) > tolerance || Math.Abs(limits.Right - lastSetXMax) > tolerance;
            bool yChanged = Math.Abs(limits.Bottom - lastSetYMin) > tolerance || Math.Abs(limits.Top - lastSetYMax) > tolerance;
            return xChanged || yChanged;
        }


    }
}
