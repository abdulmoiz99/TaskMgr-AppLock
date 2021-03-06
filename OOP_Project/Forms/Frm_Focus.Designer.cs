﻿namespace OOP_Project
{
    partial class Frm_Focus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Focus));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_MostUsedApps = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.rdo_sec = new System.Windows.Forms.RadioButton();
            this.rdo_hour = new System.Windows.Forms.RadioButton();
            this.rdo_min = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lab_appName = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_Restric = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MostUsedApps)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_MostUsedApps);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupBox2.Location = new System.Drawing.Point(372, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 383);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frequently Used Apps";
            // 
            // dgv_MostUsedApps
            // 
            this.dgv_MostUsedApps.AllowUserToAddRows = false;
            this.dgv_MostUsedApps.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgv_MostUsedApps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_MostUsedApps.BackgroundColor = System.Drawing.Color.White;
            this.dgv_MostUsedApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MostUsedApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MostUsedApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_MostUsedApps.Location = new System.Drawing.Point(6, 50);
            this.dgv_MostUsedApps.Name = "dgv_MostUsedApps";
            this.dgv_MostUsedApps.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            this.dgv_MostUsedApps.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_MostUsedApps.Size = new System.Drawing.Size(335, 327);
            this.dgv_MostUsedApps.TabIndex = 0;
            this.dgv_MostUsedApps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MostUsedApps_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Stats_appname";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 270;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 407);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_add);
            this.groupBox5.Controls.Add(this.btn_minus);
            this.groupBox5.Controls.Add(this.txt_timer);
            this.groupBox5.Controls.Add(this.rdo_sec);
            this.groupBox5.Controls.Add(this.rdo_hour);
            this.groupBox5.Controls.Add(this.rdo_min);
            this.groupBox5.Controls.Add(this.btn_Restric);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupBox5.Location = new System.Drawing.Point(6, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 297);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Restric Use";
            // 
            // txt_timer
            // 
            this.txt_timer.BackColor = System.Drawing.Color.White;
            this.txt_timer.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txt_timer.Location = new System.Drawing.Point(136, 67);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.ReadOnly = true;
            this.txt_timer.Size = new System.Drawing.Size(87, 66);
            this.txt_timer.TabIndex = 28;
            // 
            // rdo_sec
            // 
            this.rdo_sec.AutoSize = true;
            this.rdo_sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.rdo_sec.Location = new System.Drawing.Point(49, 157);
            this.rdo_sec.Name = "rdo_sec";
            this.rdo_sec.Size = new System.Drawing.Size(92, 23);
            this.rdo_sec.TabIndex = 27;
            this.rdo_sec.Text = "Seconds";
            this.rdo_sec.UseVisualStyleBackColor = true;
            // 
            // rdo_hour
            // 
            this.rdo_hour.AutoSize = true;
            this.rdo_hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.rdo_hour.Location = new System.Drawing.Point(212, 157);
            this.rdo_hour.Name = "rdo_hour";
            this.rdo_hour.Size = new System.Drawing.Size(63, 23);
            this.rdo_hour.TabIndex = 25;
            this.rdo_hour.Text = "Hour";
            this.rdo_hour.UseVisualStyleBackColor = true;
            // 
            // rdo_min
            // 
            this.rdo_min.AutoSize = true;
            this.rdo_min.Checked = true;
            this.rdo_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.rdo_min.Location = new System.Drawing.Point(150, 157);
            this.rdo_min.Name = "rdo_min";
            this.rdo_min.Size = new System.Drawing.Size(55, 23);
            this.rdo_min.TabIndex = 26;
            this.rdo_min.TabStop = true;
            this.rdo_min.Text = "Min";
            this.rdo_min.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lab_appName);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 73);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selected";
            // 
            // lab_appName
            // 
            this.lab_appName.AutoSize = true;
            this.lab_appName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_appName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lab_appName.Location = new System.Drawing.Point(13, 24);
            this.lab_appName.Name = "lab_appName";
            this.lab_appName.Size = new System.Drawing.Size(159, 32);
            this.lab_appName.TabIndex = 4;
            this.lab_appName.Text = "App Name";
            // 
            // chart
            // 
            this.chart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.chart.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            this.chart.BackSecondaryColor = System.Drawing.Color.White;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            this.chart.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart.BorderSkin.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.chart.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.chart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelBorderWidth = 6;
            series1.LabelForeColor = System.Drawing.Color.Gray;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.MarkerBorderWidth = 0;
            series1.MarkerSize = 0;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Time";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(725, 151);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 151);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(225, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 56);
            this.label3.TabIndex = 1;
            this.label3.Text = "SELECT APP\r\n";
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_add.Image = global::OOP_Project.Properties.Resources.slide_up_40;
            this.btn_add.Location = new System.Drawing.Point(229, 67);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(50, 66);
            this.btn_add.TabIndex = 30;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_minus.Image = ((System.Drawing.Image)(resources.GetObject("btn_minus.Image")));
            this.btn_minus.Location = new System.Drawing.Point(63, 67);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(50, 66);
            this.btn_minus.TabIndex = 29;
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_Restric
            // 
            this.btn_Restric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Restric.FlatAppearance.BorderSize = 0;
            this.btn_Restric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restric.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restric.ForeColor = System.Drawing.Color.White;
            this.btn_Restric.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restric.Image")));
            this.btn_Restric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Restric.Location = new System.Drawing.Point(44, 202);
            this.btn_Restric.Name = "btn_Restric";
            this.btn_Restric.Size = new System.Drawing.Size(235, 70);
            this.btn_Restric.TabIndex = 5;
            this.btn_Restric.Text = "Restric";
            this.btn_Restric.UseVisualStyleBackColor = false;
            this.btn_Restric.Click += new System.EventHandler(this.btn_Restric_Click);
            // 
            // Frm_Focus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Focus";
            this.Text = "Frm_Focus";
            this.Activated += new System.EventHandler(this.Frm_Focus_Activated);
            this.Load += new System.EventHandler(this.Frm_Focus_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MostUsedApps)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_MostUsedApps;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lab_appName;
        private System.Windows.Forms.Button btn_Restric;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.TextBox txt_timer;
        private System.Windows.Forms.RadioButton rdo_sec;
        private System.Windows.Forms.RadioButton rdo_hour;
        private System.Windows.Forms.RadioButton rdo_min;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}