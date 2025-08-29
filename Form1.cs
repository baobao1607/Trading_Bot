using ScottPlot;
using ScottPlot.ArrowShapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Trading_Bot
{
    public partial class Form1: Form
    {
        string base_path = @"C:\Users\baolam\source\repos\Trading_Bot\stock_data";
        string ticker_name = string.Empty;
        string file_path = string.Empty;
        public Simulation simulation;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void reset_view_Click(object sender, EventArgs e)
        {
            simulation.RefreshToLatest();
        }

        public void UpdateProfitLabel(double profit)
        {
            Profit_label.Text = $"Profit: {profit:F2}";
        }


        public void UpdateBalance(double balance)
        {
            label_balance.Text = $"Balance: {balance:F2}";
        }

        private void comboBox_Ticker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticker_name=comboBox_Ticker.Text;
        }

        private void button_LoadCSV_Click(object sender, EventArgs e)
        {
            if (ticker_name == string.Empty)
            {
                MessageBox.Show("Choose Ticker Name First");
                return;
            } 
            if (simulation != null)
            {
                simulation.Kill();
                simulation = null;
            }
            Ticker_plot.Plot.Clear();
            Ticker_plot.Refresh();
            string file_name = $"{ticker_name}_1min.csv";
            file_path = Path.Combine(base_path, file_name);
            simulation = new Simulation(Ticker_plot, file_path, this);
            comboBox_timeframe.SelectedIndex = 0;
            comboBox_speed.SelectedIndex = 1;

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            simulation.Resume();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            simulation.Pause();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            simulation.Kill();
            simulation = null;
            Ticker_plot.Plot.Clear();
            Ticker_plot.Refresh();
            Ticker_plot.Refresh();
            simulation = new Simulation(Ticker_plot,file_path,this);
            comboBox_timeframe.SelectedIndex = 0;
            comboBox_speed.SelectedIndex = 1;
        }

        private void comboBox_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (simulation != null)
            {
                string selected = comboBox_speed.SelectedItem.ToString();
                switch (selected)
                {
                    case "0.5x":
                        simulation.SetSpeed(2000);
                        break;
                    case "1x":
                        simulation.SetSpeed(1000);
                        break;
                    case "2x":
                        simulation.SetSpeed(500);
                        break;
                    case "4x":
                        simulation.SetSpeed(250);
                        break;
                }
            }
        }

        private void comboBox_timeframe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (simulation == null) return;

            int minutes = 1;
            switch (comboBox_timeframe.SelectedItem.ToString())
            {
                case "1m": minutes = 1; break;
                case "5m": minutes = 5; break;
                case "15m": minutes = 15; break;
                case "1h": minutes = 60; break;
                case "1d": minutes = 3600; break;
            }

            simulation.SetTimeframe(minutes);
        }
    }
}
