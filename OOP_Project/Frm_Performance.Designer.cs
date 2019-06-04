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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_activeTask = new System.Windows.Forms.TextBox();
            this.lisV_Apps = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lisV_Process = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.partion = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_endTask = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RAM_label = new System.Windows.Forms.Label();
            this.RAM_progressBar = new System.Windows.Forms.ProgressBar();
            this.Free_RAM_label = new System.Windows.Forms.Label();
            this.Used_RAM_label = new System.Windows.Forms.Label();
            this.Total_RAM_label = new System.Windows.Forms.Label();
            this.RAM_Percentage_label = new System.Windows.Forms.Label();
            this.NoOfCore_label = new System.Windows.Forms.Label();
            this.Manufacturer_label = new System.Windows.Forms.Label();
            this.CPU_Name_label = new System.Windows.Forms.Label();
            this.CPU_Percentage_label = new System.Windows.Forms.Label();
            this.CPU_Utilization_label = new System.Windows.Forms.Label();
            this.CPU_progressBar = new System.Windows.Forms.ProgressBar();
            this.Free_Space_label = new System.Windows.Forms.Label();
            this.Used_Space_label = new System.Windows.Forms.Label();
            this.Total_Space_label = new System.Windows.Forms.Label();
            this.Drive_Ready_label = new System.Windows.Forms.Label();
            this.Drive_Format_label = new System.Windows.Forms.Label();
            this.Drive_Type_label = new System.Windows.Forms.Label();
            this.Select_Drive_label = new System.Windows.Forms.Label();
            this.Disk_comboBox = new System.Windows.Forms.ComboBox();
            this.Disk_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Disk_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_activeTask);
            this.tabPage1.Controls.Add(this.lisV_Apps);
            this.tabPage1.Controls.Add(this.lisV_Process);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.partion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_endTask);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 566);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Active";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selected:";
            // 
            // txt_activeTask
            // 
            this.txt_activeTask.BackColor = System.Drawing.Color.White;
            this.txt_activeTask.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_activeTask.Location = new System.Drawing.Point(90, 414);
            this.txt_activeTask.Multiline = true;
            this.txt_activeTask.Name = "txt_activeTask";
            this.txt_activeTask.ReadOnly = true;
            this.txt_activeTask.Size = new System.Drawing.Size(309, 29);
            this.txt_activeTask.TabIndex = 14;
            // 
            // lisV_Apps
            // 
            this.lisV_Apps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lisV_Apps.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisV_Apps.Location = new System.Drawing.Point(10, 41);
            this.lisV_Apps.MultiSelect = false;
            this.lisV_Apps.Name = "lisV_Apps";
            this.lisV_Apps.Size = new System.Drawing.Size(389, 358);
            this.lisV_Apps.TabIndex = 17;
            this.lisV_Apps.UseCompatibleStateImageBehavior = false;
            this.lisV_Apps.View = System.Windows.Forms.View.Details;
            this.lisV_Apps.SelectedIndexChanged += new System.EventHandler(this.lisV_Apps_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Process Name";
            this.columnHeader2.Width = 165;
            // 
            // lisV_Process
            // 
            this.lisV_Process.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader3});
            this.lisV_Process.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisV_Process.Location = new System.Drawing.Point(418, 41);
            this.lisV_Process.MultiSelect = false;
            this.lisV_Process.Name = "lisV_Process";
            this.lisV_Process.Size = new System.Drawing.Size(327, 507);
            this.lisV_Process.TabIndex = 21;
            this.lisV_Process.UseCompatibleStateImageBehavior = false;
            this.lisV_Process.View = System.Windows.Forms.View.Details;
            this.lisV_Process.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Process Name";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Memory";
            this.columnHeader3.Width = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Proccess:";
            // 
            // partion
            // 
            this.partion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.partion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.partion.Location = new System.Drawing.Point(405, 28);
            this.partion.Name = "partion";
            this.partion.Size = new System.Drawing.Size(3, 520);
            this.partion.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apps:";
            // 
            // btn_endTask
            // 
            this.btn_endTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_endTask.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_endTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_endTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_endTask.Location = new System.Drawing.Point(6, 449);
            this.btn_endTask.Name = "btn_endTask";
            this.btn_endTask.Size = new System.Drawing.Size(393, 43);
            this.btn_endTask.TabIndex = 16;
            this.btn_endTask.Text = "End Task";
            this.btn_endTask.UseVisualStyleBackColor = true;
            this.btn_endTask.Click += new System.EventHandler(this.btn_endTask_Click);
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
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
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
            // groupBox2
            // abc
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
            // RAM_label
            // 
            this.RAM_label.AutoSize = true;
            this.RAM_label.Location = new System.Drawing.Point(15, 36);
            this.RAM_label.Name = "RAM_label";
            this.RAM_label.Size = new System.Drawing.Size(48, 20);
            this.RAM_label.TabIndex = 0;
            this.RAM_label.Text = "RAM:";
            // 
            // RAM_progressBar
            // 
            this.RAM_progressBar.Location = new System.Drawing.Point(19, 59);
            this.RAM_progressBar.Name = "RAM_progressBar";
            this.RAM_progressBar.Size = new System.Drawing.Size(288, 32);
            this.RAM_progressBar.TabIndex = 2;
            this.RAM_progressBar.Click += new System.EventHandler(this.RAM_progressBar_Click);
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
            chartArea2.Name = "ChartArea1";
            this.Disk_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Disk_chart.Legends.Add(legend2);
            this.Disk_chart.Location = new System.Drawing.Point(19, 25);
            this.Disk_chart.Name = "Disk_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "DiskUsage";
            this.Disk_chart.Series.Add(series2);
            this.Disk_chart.Size = new System.Drawing.Size(323, 224);
            this.Disk_chart.TabIndex = 9;
            this.Disk_chart.Text = "chart1";
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
            this.Activated += new System.EventHandler(this.Frm_Performance_Activated);
            this.Load += new System.EventHandler(this.Frm_Performance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Disk_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_activeTask;
        private System.Windows.Forms.ListView lisV_Apps;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lisV_Process;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel partion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_endTask;
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