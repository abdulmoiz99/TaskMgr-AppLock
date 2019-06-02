namespace OOP_Project
{
    partial class Frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dashboard));
            this.PanelFloat = new System.Windows.Forms.Panel();
            this.Panel_SideBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_focus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_systemInfo = new System.Windows.Forms.Button();
            this.btn_AppUsage = new System.Windows.Forms.Button();
            this.btn_Active = new System.Windows.Forms.Button();
            this.btn_Lock = new System.Windows.Forms.Button();
            this.btn_DashBoard = new System.Windows.Forms.Button();
            this.Toppannel = new XanderUI.XUIGradientPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Minimizesd = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.Panel_SideBar.SuspendLayout();
            this.Toppannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFloat
            // 
            this.PanelFloat.BackColor = System.Drawing.Color.White;
            this.PanelFloat.Location = new System.Drawing.Point(3, 188);
            this.PanelFloat.Name = "PanelFloat";
            this.PanelFloat.Size = new System.Drawing.Size(7, 49);
            this.PanelFloat.TabIndex = 4;
            // 
            // Panel_SideBar
            // 
            this.Panel_SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Panel_SideBar.Controls.Add(this.label1);
            this.Panel_SideBar.Controls.Add(this.button2);
            this.Panel_SideBar.Controls.Add(this.btn_focus);
            this.Panel_SideBar.Controls.Add(this.button1);
            this.Panel_SideBar.Controls.Add(this.btn_systemInfo);
            this.Panel_SideBar.Controls.Add(this.btn_AppUsage);
            this.Panel_SideBar.Controls.Add(this.PanelFloat);
            this.Panel_SideBar.Controls.Add(this.btn_Active);
            this.Panel_SideBar.Controls.Add(this.btn_Lock);
            this.Panel_SideBar.Controls.Add(this.btn_DashBoard);
            this.Panel_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_SideBar.ForeColor = System.Drawing.Color.DarkCyan;
            this.Panel_SideBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_SideBar.Name = "Panel_SideBar";
            this.Panel_SideBar.Size = new System.Drawing.Size(268, 691);
            this.Panel_SideBar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(47, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log Out";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 651);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 40);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_focus
            // 
            this.btn_focus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_focus.FlatAppearance.BorderSize = 0;
            this.btn_focus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_focus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_focus.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_focus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_focus.Image = global::OOP_Project.Properties.Resources.delete_shield_36;
            this.btn_focus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_focus.Location = new System.Drawing.Point(12, 356);
            this.btn_focus.Name = "btn_focus";
            this.btn_focus.Size = new System.Drawing.Size(253, 50);
            this.btn_focus.TabIndex = 4;
            this.btn_focus.Text = "         Focus";
            this.btn_focus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_focus.UseVisualStyleBackColor = false;
            this.btn_focus.Click += new System.EventHandler(this.btn_focus_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 172);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_systemInfo
            // 
            this.btn_systemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_systemInfo.FlatAppearance.BorderSize = 0;
            this.btn_systemInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_systemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_systemInfo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_systemInfo.ForeColor = System.Drawing.Color.White;
            this.btn_systemInfo.Image = global::OOP_Project.Properties.Resources.info_36;
            this.btn_systemInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_systemInfo.Location = new System.Drawing.Point(12, 468);
            this.btn_systemInfo.Name = "btn_systemInfo";
            this.btn_systemInfo.Size = new System.Drawing.Size(253, 50);
            this.btn_systemInfo.TabIndex = 6;
            this.btn_systemInfo.Text = "   System Info";
            this.btn_systemInfo.UseVisualStyleBackColor = false;
            this.btn_systemInfo.Click += new System.EventHandler(this.btn_systemInfo_Click);
            // 
            // btn_AppUsage
            // 
            this.btn_AppUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_AppUsage.FlatAppearance.BorderSize = 0;
            this.btn_AppUsage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_AppUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AppUsage.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AppUsage.ForeColor = System.Drawing.Color.White;
            this.btn_AppUsage.Image = global::OOP_Project.Properties.Resources.chart_361;
            this.btn_AppUsage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AppUsage.Location = new System.Drawing.Point(12, 412);
            this.btn_AppUsage.Name = "btn_AppUsage";
            this.btn_AppUsage.Size = new System.Drawing.Size(253, 50);
            this.btn_AppUsage.TabIndex = 5;
            this.btn_AppUsage.Text = "  App Usage";
            this.btn_AppUsage.UseVisualStyleBackColor = false;
            this.btn_AppUsage.Click += new System.EventHandler(this.btn_AppUsage_Click);
            // 
            // btn_Active
            // 
            this.btn_Active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Active.FlatAppearance.BorderSize = 0;
            this.btn_Active.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_Active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Active.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Active.ForeColor = System.Drawing.Color.White;
            this.btn_Active.Image = global::OOP_Project.Properties.Resources.system_task_36;
            this.btn_Active.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Active.Location = new System.Drawing.Point(12, 244);
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(253, 50);
            this.btn_Active.TabIndex = 2;
            this.btn_Active.Text = "     Performance";
            this.btn_Active.UseVisualStyleBackColor = false;
            this.btn_Active.Click += new System.EventHandler(this.btn_Active_Click);
            // 
            // btn_Lock
            // 
            this.btn_Lock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Lock.FlatAppearance.BorderSize = 0;
            this.btn_Lock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lock.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lock.ForeColor = System.Drawing.Color.White;
            this.btn_Lock.Image = global::OOP_Project.Properties.Resources.locker_36;
            this.btn_Lock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lock.Location = new System.Drawing.Point(12, 300);
            this.btn_Lock.Name = "btn_Lock";
            this.btn_Lock.Size = new System.Drawing.Size(253, 50);
            this.btn_Lock.TabIndex = 3;
            this.btn_Lock.Text = "App Lock";
            this.btn_Lock.UseVisualStyleBackColor = false;
            this.btn_Lock.Click += new System.EventHandler(this.btn_Lock_Click);
            // 
            // btn_DashBoard
            // 
            this.btn_DashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_DashBoard.FlatAppearance.BorderSize = 0;
            this.btn_DashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DashBoard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DashBoard.ForeColor = System.Drawing.Color.White;
            this.btn_DashBoard.Image = global::OOP_Project.Properties.Resources.home_36;
            this.btn_DashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DashBoard.Location = new System.Drawing.Point(12, 188);
            this.btn_DashBoard.Name = "btn_DashBoard";
            this.btn_DashBoard.Size = new System.Drawing.Size(253, 50);
            this.btn_DashBoard.TabIndex = 1;
            this.btn_DashBoard.Text = " DashBoard";
            this.btn_DashBoard.UseVisualStyleBackColor = false;
            this.btn_DashBoard.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // Toppannel
            // 
            this.Toppannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Toppannel.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(104)))));
            this.Toppannel.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.Toppannel.Controls.Add(this.btn_close);
            this.Toppannel.Controls.Add(this.btn_Minimizesd);
            this.Toppannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppannel.Location = new System.Drawing.Point(268, 0);
            this.Toppannel.Name = "Toppannel";
            this.Toppannel.PrimerColor = System.Drawing.Color.White;
            this.Toppannel.Size = new System.Drawing.Size(791, 36);
            this.Toppannel.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.Toppannel.TabIndex = 3;
            this.Toppannel.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.Toppannel.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.Toppannel.Paint += new System.Windows.Forms.PaintEventHandler(this.Toppannel_Paint);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::OOP_Project.Properties.Resources.close_window_26;
            this.btn_close.Location = new System.Drawing.Point(754, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 34);
            this.btn_close.TabIndex = 9;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // btn_Minimizesd
            // 
            this.btn_Minimizesd.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimizesd.FlatAppearance.BorderSize = 0;
            this.btn_Minimizesd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizesd.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizesd.Image")));
            this.btn_Minimizesd.Location = new System.Drawing.Point(715, 0);
            this.btn_Minimizesd.Name = "btn_Minimizesd";
            this.btn_Minimizesd.Size = new System.Drawing.Size(35, 37);
            this.btn_Minimizesd.TabIndex = 8;
            this.btn_Minimizesd.UseVisualStyleBackColor = false;
            this.btn_Minimizesd.Click += new System.EventHandler(this.btn_Minimizesd_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 30;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 691);
            this.Controls.Add(this.Toppannel);
            this.Controls.Add(this.Panel_SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Dashboard";
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.Resize += new System.EventHandler(this.Frm_Dashboard_Resize_1);
            this.Panel_SideBar.ResumeLayout(false);
            this.Panel_SideBar.PerformLayout();
            this.Toppannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DashBoard;
        private System.Windows.Forms.Button btn_Active;
        private System.Windows.Forms.Button btn_Lock;
        private System.Windows.Forms.Button btn_systemInfo;
        private System.Windows.Forms.Panel PanelFloat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_AppUsage;
        private System.Windows.Forms.Panel Panel_SideBar;
        private System.Windows.Forms.Button btn_focus;
        private XanderUI.XUIGradientPanel Toppannel;
        private System.Windows.Forms.Button btn_Minimizesd;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
    }
}