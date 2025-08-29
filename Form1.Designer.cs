namespace Trading_Bot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ticker_plot = new ScottPlot.WinForms.FormsPlot();
            this.reset_view = new System.Windows.Forms.Button();
            this.Profit_label = new System.Windows.Forms.Label();
            this.label_timeframe = new System.Windows.Forms.Label();
            this.comboBox_timeframe = new System.Windows.Forms.ComboBox();
            this.label_speed_control = new System.Windows.Forms.Label();
            this.comboBox_speed = new System.Windows.Forms.ComboBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Ticker = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_RSI = new System.Windows.Forms.CheckBox();
            this.button_LoadCSV = new System.Windows.Forms.Button();
            this.checkBox_SMA = new System.Windows.Forms.CheckBox();
            this.checkBox_EMA = new System.Windows.Forms.CheckBox();
            this.checkBox_MACD = new System.Windows.Forms.CheckBox();
            this.label_balance = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ticker_plot
            // 
            this.Ticker_plot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ticker_plot.DisplayScale = 0F;
            this.Ticker_plot.Location = new System.Drawing.Point(9, 118);
            this.Ticker_plot.Margin = new System.Windows.Forms.Padding(2);
            this.Ticker_plot.Name = "Ticker_plot";
            this.Ticker_plot.Size = new System.Drawing.Size(1520, 570);
            this.Ticker_plot.TabIndex = 0;
            // 
            // reset_view
            // 
            this.reset_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_view.ForeColor = System.Drawing.Color.Red;
            this.reset_view.Location = new System.Drawing.Point(469, 74);
            this.reset_view.Margin = new System.Windows.Forms.Padding(2);
            this.reset_view.Name = "reset_view";
            this.reset_view.Size = new System.Drawing.Size(175, 30);
            this.reset_view.TabIndex = 1;
            this.reset_view.Text = "Reset View";
            this.reset_view.UseVisualStyleBackColor = true;
            this.reset_view.Click += new System.EventHandler(this.reset_view_Click);
            // 
            // Profit_label
            // 
            this.Profit_label.Location = new System.Drawing.Point(855, 72);
            this.Profit_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Profit_label.Name = "Profit_label";
            this.Profit_label.Size = new System.Drawing.Size(185, 34);
            this.Profit_label.TabIndex = 2;
            this.Profit_label.Text = "PROFIT";
            this.Profit_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_timeframe
            // 
            this.label_timeframe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_timeframe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timeframe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_timeframe.Location = new System.Drawing.Point(1208, 0);
            this.label_timeframe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_timeframe.Name = "label_timeframe";
            this.label_timeframe.Size = new System.Drawing.Size(138, 69);
            this.label_timeframe.TabIndex = 9;
            this.label_timeframe.Text = "Timeframe";
            this.label_timeframe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_timeframe
            // 
            this.comboBox_timeframe.DropDownHeight = 120;
            this.comboBox_timeframe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_timeframe.FormattingEnabled = true;
            this.comboBox_timeframe.IntegralHeight = false;
            this.comboBox_timeframe.Items.AddRange(new object[] {
            "1m",
            "5m",
            "15m",
            "1h",
            "1d"});
            this.comboBox_timeframe.Location = new System.Drawing.Point(1208, 74);
            this.comboBox_timeframe.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_timeframe.Name = "comboBox_timeframe";
            this.comboBox_timeframe.Size = new System.Drawing.Size(137, 28);
            this.comboBox_timeframe.TabIndex = 8;
            this.comboBox_timeframe.Text = "Timeframe";
            this.comboBox_timeframe.SelectedIndexChanged += new System.EventHandler(this.comboBox_timeframe_SelectedIndexChanged);
            // 
            // label_speed_control
            // 
            this.label_speed_control.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_speed_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speed_control.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_speed_control.Location = new System.Drawing.Point(1044, 0);
            this.label_speed_control.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_speed_control.Name = "label_speed_control";
            this.label_speed_control.Size = new System.Drawing.Size(160, 69);
            this.label_speed_control.TabIndex = 7;
            this.label_speed_control.Text = "Speed";
            this.label_speed_control.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_speed
            // 
            this.comboBox_speed.DropDownHeight = 120;
            this.comboBox_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_speed.FormattingEnabled = true;
            this.comboBox_speed.IntegralHeight = false;
            this.comboBox_speed.Items.AddRange(new object[] {
            "0.5x",
            "1x",
            "2x",
            "4x"});
            this.comboBox_speed.Location = new System.Drawing.Point(1044, 74);
            this.comboBox_speed.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_speed.Name = "comboBox_speed";
            this.comboBox_speed.Size = new System.Drawing.Size(158, 28);
            this.comboBox_speed.TabIndex = 6;
            this.comboBox_speed.Text = "Speed";
            this.comboBox_speed.SelectedIndexChanged += new System.EventHandler(this.comboBox_speed_SelectedIndexChanged);
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.Red;
            this.button_reset.Location = new System.Drawing.Point(855, 2);
            this.button_reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(185, 48);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_pause
            // 
            this.button_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pause.ForeColor = System.Drawing.Color.Red;
            this.button_pause.Location = new System.Drawing.Point(648, 2);
            this.button_pause.Margin = new System.Windows.Forms.Padding(2);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(203, 48);
            this.button_pause.TabIndex = 4;
            this.button_pause.Text = "PAUSE";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.ForeColor = System.Drawing.Color.Red;
            this.button_Start.Location = new System.Drawing.Point(469, 2);
            this.button_Start.Margin = new System.Windows.Forms.Padding(2);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(175, 48);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "RESUME";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(206, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ticker Control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Ticker
            // 
            this.comboBox_Ticker.DropDownHeight = 120;
            this.comboBox_Ticker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Ticker.FormattingEnabled = true;
            this.comboBox_Ticker.IntegralHeight = false;
            this.comboBox_Ticker.Items.AddRange(new object[] {
            "AAPL",
            "AMZN",
            "GOOGL",
            "IBM",
            "META",
            "MSFT",
            "TSLA"});
            this.comboBox_Ticker.Location = new System.Drawing.Point(206, 74);
            this.comboBox_Ticker.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Ticker.Name = "comboBox_Ticker";
            this.comboBox_Ticker.Size = new System.Drawing.Size(259, 28);
            this.comboBox_Ticker.TabIndex = 1;
            this.comboBox_Ticker.Text = "Ticker";
            this.comboBox_Ticker.SelectedIndexChanged += new System.EventHandler(this.comboBox_Ticker_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox_RSI, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_LoadCSV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reset_view, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_timeframe, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_speed, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Ticker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_reset, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_pause, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_timeframe, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_SMA, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_EMA, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_MACD, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.Profit_label, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Start, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_speed_control, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_balance, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1540, 106);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // checkBox_RSI
            // 
            this.checkBox_RSI.AutoSize = true;
            this.checkBox_RSI.Location = new System.Drawing.Point(1350, 2);
            this.checkBox_RSI.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_RSI.Name = "checkBox_RSI";
            this.checkBox_RSI.Size = new System.Drawing.Size(44, 17);
            this.checkBox_RSI.TabIndex = 5;
            this.checkBox_RSI.Text = "RSI";
            this.checkBox_RSI.UseVisualStyleBackColor = true;
            // 
            // button_LoadCSV
            // 
            this.button_LoadCSV.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_LoadCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_LoadCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoadCSV.Location = new System.Drawing.Point(2, 2);
            this.button_LoadCSV.Margin = new System.Windows.Forms.Padding(2);
            this.button_LoadCSV.Name = "button_LoadCSV";
            this.button_LoadCSV.Size = new System.Drawing.Size(200, 68);
            this.button_LoadCSV.TabIndex = 0;
            this.button_LoadCSV.Text = "Load_CSV";
            this.button_LoadCSV.UseVisualStyleBackColor = false;
            this.button_LoadCSV.Click += new System.EventHandler(this.button_LoadCSV_Click);
            // 
            // checkBox_SMA
            // 
            this.checkBox_SMA.AutoSize = true;
            this.checkBox_SMA.Location = new System.Drawing.Point(1403, 2);
            this.checkBox_SMA.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_SMA.Name = "checkBox_SMA";
            this.checkBox_SMA.Size = new System.Drawing.Size(49, 17);
            this.checkBox_SMA.TabIndex = 10;
            this.checkBox_SMA.Text = "SMA";
            this.checkBox_SMA.UseVisualStyleBackColor = true;
            // 
            // checkBox_EMA
            // 
            this.checkBox_EMA.AutoSize = true;
            this.checkBox_EMA.Location = new System.Drawing.Point(1350, 74);
            this.checkBox_EMA.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_EMA.Name = "checkBox_EMA";
            this.checkBox_EMA.Size = new System.Drawing.Size(49, 17);
            this.checkBox_EMA.TabIndex = 11;
            this.checkBox_EMA.Text = "EMA";
            this.checkBox_EMA.UseVisualStyleBackColor = true;
            // 
            // checkBox_MACD
            // 
            this.checkBox_MACD.AutoSize = true;
            this.checkBox_MACD.Location = new System.Drawing.Point(1403, 74);
            this.checkBox_MACD.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_MACD.Name = "checkBox_MACD";
            this.checkBox_MACD.Size = new System.Drawing.Size(57, 17);
            this.checkBox_MACD.TabIndex = 12;
            this.checkBox_MACD.Text = "MACD";
            this.checkBox_MACD.UseVisualStyleBackColor = true;
            // 
            // label_balance
            // 
            this.label_balance.Location = new System.Drawing.Point(648, 72);
            this.label_balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(203, 32);
            this.label_balance.TabIndex = 13;
            this.label_balance.Text = "BALANCE";
            this.label_balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 736);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Ticker_plot);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.WinForms.FormsPlot Ticker_plot;
        private System.Windows.Forms.Button reset_view;
        private System.Windows.Forms.Label Profit_label;
        private System.Windows.Forms.ComboBox comboBox_Ticker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_timeframe;
        private System.Windows.Forms.ComboBox comboBox_timeframe;
        private System.Windows.Forms.Label label_speed_control;
        private System.Windows.Forms.ComboBox comboBox_speed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox_RSI;
        private System.Windows.Forms.CheckBox checkBox_SMA;
        private System.Windows.Forms.CheckBox checkBox_EMA;
        private System.Windows.Forms.CheckBox checkBox_MACD;
        private System.Windows.Forms.Button button_LoadCSV;
        private System.Windows.Forms.Label label_balance;
    }
}

