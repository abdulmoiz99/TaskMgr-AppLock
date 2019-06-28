namespace OOP_Project
{
    partial class Frm_Performance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Free_Space_label = new System.Windows.Forms.Label();
            this.Used_Space_label = new System.Windows.Forms.Label();
            this.Total_Space_label = new System.Windows.Forms.Label();
            this.Drive_Ready_label = new System.Windows.Forms.Label();
            this.Drive_Format_label = new System.Windows.Forms.Label();
            this.Drive_Type_label = new System.Windows.Forms.Label();
            this.Select_Drive_label = new System.Windows.Forms.Label();
            this.Disk_comboBox = new System.Windows.Forms.ComboBox();
            this.Disk_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoOfCore_label = new System.Windows.Forms.Label();
            this.Manufacturer_label = new System.Windows.Forms.Label();
            this.CPU_Name_label = new System.Windows.Forms.Label();
            this.CPU_Percentage_label = new System.Windows.Forms.Label();
            this.CPU_Utilization_label = new System.Windows.Forms.Label();
            this.CPU_progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Free_RAM_label = new System.Windows.Forms.Label();
            this.Used_RAM_label = new System.Windows.Forms.Label();
            this.Total_RAM_label = new System.Windows.Forms.Label();
            this.RAM_Percentage_label = new System.Windows.Forms.Label();
            this.RAM_progressBar = new System.Windows.Forms.ProgressBar();
            this.RAM_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Disk_chart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Performance";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Free_Space_label);
            this.groupBox3.Controls.Add(this.Used_Space_label);
            this.groupBox3.Controls.Add(this.Total_Space_label);
            this.groupBox3.Controls.Add(this.Drive_Ready_label);
            this.groupBox3.Controls.Add(this.Drive_Format_label);
            this.groupBox3.Controls.Add(this.Drive_Type_label);
            this.groupBox3.Controls.Add(this.Select_Drive_label);
            this.groupBox3.Controls.Add(this.Disk_comboBox);
            this.groupBox3.Controls.Add(this.Disk_chart);
            this.groupBox3.Location = new System.Drawing.Point(17, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(734, 258);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disk";
            // 
            // Free_Space_label
            // 
            this.Free_Space_label.AutoSize = true;
            this.Free_Space_label.Location = new System.Drawing.Point(360, 208);
            this.Free_Space_label.Name = "Free_Space_label";
            this.Free_Space_label.Size = new System.Drawing.Size(96, 20);
            this.Free_Space_label.TabIndex = 17;
            this.Free_Space_label.Text = "Free Space:";
            // 
            // Used_Space_label
            // 
            this.Used_Space_label.AutoSize = true;
            this.Used_Space_label.Location = new System.Drawing.Point(360, 178);
            this.Used_Space_label.Name = "Used_Space_label";
            this.Used_Space_label.Size = new System.Drawing.Size(101, 20);
            this.Used_Space_label.TabIndex = 16;
            this.Used_Space_label.Text = "Used Space:";
            // 
            // Total_Space_label
            // 
            this.Total_Space_label.AutoSize = true;
            this.Total_Space_label.Location = new System.Drawing.Point(360, 148);
            this.Total_Space_label.Name = "Total_Space_label";
            this.Total_Space_label.Size = new System.Drawing.Size(97, 20);
            this.Total_Space_label.TabIndex = 15;
            this.Total_Space_label.Text = "Total Space:";
            // 
            // Drive_Ready_label
            // 
            this.Drive_Ready_label.AutoSize = true;
            this.Drive_Ready_label.Location = new System.Drawing.Point(360, 58);
            this.Drive_Ready_label.Name = "Drive_Ready_label";
            this.Drive_Ready_label.Size = new System.Drawing.Size(103, 20);
            this.Drive_Ready_label.TabIndex = 14;
            this.Drive_Ready_label.Text = "Drive Ready:";
            // 
            // Drive_Format_label
            // 
            this.Drive_Format_label.AutoSize = true;
            this.Drive_Format_label.Location = new System.Drawing.Point(360, 88);
            this.Drive_Format_label.Name = "Drive_Format_label";
            this.Drive_Format_label.Size = new System.Drawing.Size(106, 20);
            this.Drive_Format_label.TabIndex = 13;
            this.Drive_Format_label.Text = "Drive Format:";
            // 
            // Drive_Type_label
            // 
            this.Drive_Type_label.AutoSize = true;
            this.Drive_Type_label.Location = new System.Drawing.Point(360, 118);
            this.Drive_Type_label.Name = "Drive_Type_label";
            this.Drive_Type_label.Size = new System.Drawing.Size(89, 20);
            this.Drive_Type_label.TabIndex = 12;
            this.Drive_Type_label.Text = "Drive Type:";
            // 
            // Select_Drive_label
            // 
            this.Select_Drive_label.AutoSize = true;
            this.Select_Drive_label.Location = new System.Drawing.Point(360, 25);
            this.Select_Drive_label.Name = "Select_Drive_label";
            this.Select_Drive_label.Size = new System.Drawing.Size(101, 20);
            this.Select_Drive_label.TabIndex = 11;
            this.Select_Drive_label.Text = "Select Drive:";
            // 
            // Disk_comboBox
            // 
            this.Disk_comboBox.FormattingEnabled = true;
            this.Disk_comboBox.Location = new System.Drawing.Point(493, 22);
            this.Disk_comboBox.Name = "Disk_comboBox";
            this.Disk_comboBox.Size = new System.Drawing.Size(200, 28);
            this.Disk_comboBox.TabIndex = 10;
            this.Disk_comboBox.Text = "Please select a drive...";
            this.Disk_comboBox.SelectedIndexChanged += new System.EventHandler(this.Disk_comboBox_SelectedIndexChanged_1);
            // 
            // Disk_chart
            // 
            this.Disk_chart.BorderSkin.BackColor = System.Drawing.Color.Silver;
            this.Disk_chart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Disk_chart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.Disk_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Disk_chart.Legends.Add(legend1);
            this.Disk_chart.Location = new System.Drawing.Point(19, 25);
            this.Disk_chart.Name = "Disk_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelBorderWidth = 0;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "DiskUsage";
            this.Disk_chart.Series.Add(series1);
            this.Disk_chart.Size = new System.Drawing.Size(323, 224);
            this.Disk_chart.TabIndex = 9;
            this.Disk_chart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoOfCore_label);
            this.groupBox2.Controls.Add(this.Manufacturer_label);
            this.groupBox2.Controls.Add(this.CPU_Name_label);
            this.groupBox2.Controls.Add(this.CPU_Percentage_label);
            this.groupBox2.Controls.Add(this.CPU_Utilization_label);
            this.groupBox2.Controls.Add(this.CPU_progressBar);
            this.groupBox2.Location = new System.Drawing.Point(387, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU Usage";
            // 
            // NoOfCore_label
            // 
            this.NoOfCore_label.AutoSize = true;
            this.NoOfCore_label.Location = new System.Drawing.Point(6, 205);
            this.NoOfCore_label.Name = "NoOfCore_label";
            this.NoOfCore_label.Size = new System.Drawing.Size(104, 20);
            this.NoOfCore_label.TabIndex = 11;
            this.NoOfCore_label.Text = "No. of Cores:";
            // 
            // Manufacturer_label
            // 
            this.Manufacturer_label.AutoSize = true;
            this.Manufacturer_label.Location = new System.Drawing.Point(6, 165);
            this.Manufacturer_label.Name = "Manufacturer_label";
            this.Manufacturer_label.Size = new System.Drawing.Size(115, 20);
            this.Manufacturer_label.TabIndex = 10;
            this.Manufacturer_label.Text = "Manufacturer:";
            // 
            // CPU_Name_label
            // 
            this.CPU_Name_label.AutoSize = true;
            this.CPU_Name_label.Location = new System.Drawing.Point(6, 125);
            this.CPU_Name_label.Name = "CPU_Name_label";
            this.CPU_Name_label.Size = new System.Drawing.Size(57, 20);
            this.CPU_Name_label.TabIndex = 9;
            this.CPU_Name_label.Text = "Name:";
            // 
            // CPU_Percentage_label
            // 
            this.CPU_Percentage_label.AutoSize = true;
            this.CPU_Percentage_label.Location = new System.Drawing.Point(323, 59);
            this.CPU_Percentage_label.Name = "CPU_Percentage_label";
            this.CPU_Percentage_label.Size = new System.Drawing.Size(29, 20);
            this.CPU_Percentage_label.TabIndex = 8;
            this.CPU_Percentage_label.Text = "0%";
            // 
            // CPU_Utilization_label
            // 
            this.CPU_Utilization_label.AutoSize = true;
            this.CPU_Utilization_label.Location = new System.Drawing.Point(28, 36);
            this.CPU_Utilization_label.Name = "CPU_Utilization_label";
            this.CPU_Utilization_label.Size = new System.Drawing.Size(117, 20);
            this.CPU_Utilization_label.TabIndex = 7;
            this.CPU_Utilization_label.Text = "CPU Utilization:";
            // 
            // CPU_progressBar
            // 
            this.CPU_progressBar.Location = new System.Drawing.Point(29, 59);
            this.CPU_progressBar.Name = "CPU_progressBar";
            this.CPU_progressBar.Size = new System.Drawing.Size(288, 32);
            this.CPU_progressBar.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Free_RAM_label);
            this.groupBox1.Controls.Add(this.Used_RAM_label);
            this.groupBox1.Controls.Add(this.Total_RAM_label);
            this.groupBox1.Controls.Add(this.RAM_Percentage_label);
            this.groupBox1.Controls.Add(this.RAM_progressBar);
            this.groupBox1.Controls.Add(this.RAM_label);
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ram Usage";
            // 
            // Free_RAM_label
            // 
            this.Free_RAM_label.AutoSize = true;
            this.Free_RAM_label.Location = new System.Drawing.Point(6, 205);
            this.Free_RAM_label.Name = "Free_RAM_label";
            this.Free_RAM_label.Size = new System.Drawing.Size(84, 20);
            this.Free_RAM_label.TabIndex = 9;
            this.Free_RAM_label.Text = "Free RAM:";
            // 
            // Used_RAM_label
            // 
            this.Used_RAM_label.AutoSize = true;
            this.Used_RAM_label.Location = new System.Drawing.Point(6, 165);
            this.Used_RAM_label.Name = "Used_RAM_label";
            this.Used_RAM_label.Size = new System.Drawing.Size(89, 20);
            this.Used_RAM_label.TabIndex = 8;
            this.Used_RAM_label.Text = "Used RAM:";
            // 
            // Total_RAM_label
            // 
            this.Total_RAM_label.AutoSize = true;
            this.Total_RAM_label.Location = new System.Drawing.Point(6, 125);
            this.Total_RAM_label.Name = "Total_RAM_label";
            this.Total_RAM_label.Size = new System.Drawing.Size(85, 20);
            this.Total_RAM_label.TabIndex = 7;
            this.Total_RAM_label.Text = "Total RAM:";
            // 
            // RAM_Percentage_label
            // 
            this.RAM_Percentage_label.AutoSize = true;
            this.RAM_Percentage_label.Location = new System.Drawing.Point(313, 59);
            this.RAM_Percentage_label.Name = "RAM_Percentage_label";
            this.RAM_Percentage_label.Size = new System.Drawing.Size(29, 20);
            this.RAM_Percentage_label.TabIndex = 6;
            this.RAM_Percentage_label.Text = "0%";
            // 
            // RAM_progressBar
            // 
            this.RAM_progressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RAM_progressBar.Location = new System.Drawing.Point(19, 59);
            this.RAM_progressBar.Name = "RAM_progressBar";
            this.RAM_progressBar.Size = new System.Drawing.Size(288, 32);
            this.RAM_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RAM_progressBar.TabIndex = 2;
            // 
            // RAM_label
            // 
            this.RAM_label.AutoSize = true;
            this.RAM_label.Location = new System.Drawing.Point(15, 36);
            this.RAM_label.Name = "RAM_label";
            this.RAM_label.Size = new System.Drawing.Size(48, 20);
            this.RAM_label.TabIndex = 0;
            this.RAM_label.Text = "RAM:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 566);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "App History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 599);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Performance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Performance";
            this.Load += new System.EventHandler(this.Frm_Performance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Disk_chart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Free_RAM_label;
        private System.Windows.Forms.Label Used_RAM_label;
        private System.Windows.Forms.Label Total_RAM_label;
        private System.Windows.Forms.Label RAM_Percentage_label;
        private System.Windows.Forms.ProgressBar RAM_progressBar;
        private System.Windows.Forms.Label RAM_label;
        private System.Windows.Forms.Label NoOfCore_label;
        private System.Windows.Forms.Label Manufacturer_label;
        private System.Windows.Forms.Label CPU_Name_label;
        private System.Windows.Forms.Label CPU_Percentage_label;
        private System.Windows.Forms.Label CPU_Utilization_label;
        private System.Windows.Forms.ProgressBar CPU_progressBar;
        private System.Windows.Forms.Label Free_Space_label;
        private System.Windows.Forms.Label Used_Space_label;
        private System.Windows.Forms.Label Total_Space_label;
        private System.Windows.Forms.Label Drive_Ready_label;
        private System.Windows.Forms.Label Drive_Format_label;
        private System.Windows.Forms.Label Drive_Type_label;
        private System.Windows.Forms.Label Select_Drive_label;
        private System.Windows.Forms.ComboBox Disk_comboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart Disk_chart;
    }
}