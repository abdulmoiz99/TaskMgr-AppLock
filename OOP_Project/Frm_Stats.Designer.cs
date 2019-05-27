namespace OOP_Project
{
    partial class Frm_Stats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_ScreenTimeMonth = new System.Windows.Forms.Label();
            this.lab_ScreenTimeToday = new System.Windows.Forms.Label();
            this.lisV_Apps = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Daily = new System.Windows.Forms.Button();
            this.btn_Monthly = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lab_ScreenTimeMonth);
            this.groupBox2.Controls.Add(this.lab_ScreenTimeToday);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(758, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Screen Time";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.panel1.Location = new System.Drawing.Point(364, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 35);
            this.panel1.TabIndex = 4;
            // 
            // lab_ScreenTimeMonth
            // 
            this.lab_ScreenTimeMonth.AutoSize = true;
            this.lab_ScreenTimeMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.lab_ScreenTimeMonth.Location = new System.Drawing.Point(486, 29);
            this.lab_ScreenTimeMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ScreenTimeMonth.Name = "lab_ScreenTimeMonth";
            this.lab_ScreenTimeMonth.Size = new System.Drawing.Size(104, 23);
            this.lab_ScreenTimeMonth.TabIndex = 3;
            this.lab_ScreenTimeMonth.Text = "This Month";
            // 
            // lab_ScreenTimeToday
            // 
            this.lab_ScreenTimeToday.AutoSize = true;
            this.lab_ScreenTimeToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.lab_ScreenTimeToday.Location = new System.Drawing.Point(107, 29);
            this.lab_ScreenTimeToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ScreenTimeToday.Name = "lab_ScreenTimeToday";
            this.lab_ScreenTimeToday.Size = new System.Drawing.Size(72, 23);
            this.lab_ScreenTimeToday.TabIndex = 1;
            this.lab_ScreenTimeToday.Text = "Today:";
            // 
            // lisV_Apps
            // 
            this.lisV_Apps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lisV_Apps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lisV_Apps.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisV_Apps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lisV_Apps.Location = new System.Drawing.Point(79, 361);
            this.lisV_Apps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lisV_Apps.MultiSelect = false;
            this.lisV_Apps.Name = "lisV_Apps";
            this.lisV_Apps.Size = new System.Drawing.Size(498, 209);
            this.lisV_Apps.TabIndex = 18;
            this.lisV_Apps.UseCompatibleStateImageBehavior = false;
            this.lisV_Apps.View = System.Windows.Forms.View.Details;
            this.lisV_Apps.SelectedIndexChanged += new System.EventHandler(this.lisV_Apps_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Usage";
            this.columnHeader2.Width = 100;
            // 
            // btn_Daily
            // 
            this.btn_Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Daily.Location = new System.Drawing.Point(241, 34);
            this.btn_Daily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Daily.Name = "btn_Daily";
            this.btn_Daily.Size = new System.Drawing.Size(99, 38);
            this.btn_Daily.TabIndex = 2;
            this.btn_Daily.Text = "Daily";
            this.btn_Daily.UseVisualStyleBackColor = true;
            this.btn_Daily.Click += new System.EventHandler(this.btn_Daily_Click);
            // 
            // btn_Monthly
            // 
            this.btn_Monthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Monthly.Location = new System.Drawing.Point(349, 34);
            this.btn_Monthly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Monthly.Name = "btn_Monthly";
            this.btn_Monthly.Size = new System.Drawing.Size(110, 38);
            this.btn_Monthly.TabIndex = 3;
            this.btn_Monthly.Text = "Monthly";
            this.btn_Monthly.UseVisualStyleBackColor = true;
            this.btn_Monthly.Click += new System.EventHandler(this.btn_Monthly_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.lisV_Apps);
            this.groupBox1.Controls.Add(this.btn_Daily);
            this.groupBox1.Controls.Add(this.btn_Monthly);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 578);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "App Usage";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 88);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Time";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(720, 265);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // Frm_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Stats";
            this.Load += new System.EventHandler(this.Frm_Stats_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lab_ScreenTimeMonth;
        private System.Windows.Forms.Label lab_ScreenTimeToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lisV_Apps;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_Daily;
        private System.Windows.Forms.Button btn_Monthly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}