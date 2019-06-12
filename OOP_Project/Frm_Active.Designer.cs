namespace OOP_Project
{
    partial class Frm_Active
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Active));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_activeTask = new System.Windows.Forms.TextBox();
            this.lisV_Apps = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lisV_Process = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partion = new System.Windows.Forms.Panel();
            this.btn_endTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Selected:";
            // 
            // txt_activeTask
            // 
            this.txt_activeTask.BackColor = System.Drawing.Color.White;
            this.txt_activeTask.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_activeTask.Location = new System.Drawing.Point(98, 482);
            this.txt_activeTask.Multiline = true;
            this.txt_activeTask.Name = "txt_activeTask";
            this.txt_activeTask.ReadOnly = true;
            this.txt_activeTask.Size = new System.Drawing.Size(309, 29);
            this.txt_activeTask.TabIndex = 22;
            // 
            // lisV_Apps
            // 
            this.lisV_Apps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lisV_Apps.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisV_Apps.Location = new System.Drawing.Point(18, 57);
            this.lisV_Apps.MultiSelect = false;
            this.lisV_Apps.Name = "lisV_Apps";
            this.lisV_Apps.Size = new System.Drawing.Size(389, 419);
            this.lisV_Apps.TabIndex = 25;
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
            this.lisV_Process.Location = new System.Drawing.Point(426, 57);
            this.lisV_Process.MultiSelect = false;
            this.lisV_Process.Name = "lisV_Process";
            this.lisV_Process.Size = new System.Drawing.Size(327, 520);
            this.lisV_Process.TabIndex = 28;
            this.lisV_Process.UseCompatibleStateImageBehavior = false;
            this.lisV_Process.View = System.Windows.Forms.View.Details;
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
            // partion
            // 
            this.partion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.partion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.partion.Location = new System.Drawing.Point(417, 19);
            this.partion.Name = "partion";
            this.partion.Size = new System.Drawing.Size(3, 560);
            this.partion.TabIndex = 26;
            // 
            // btn_endTask
            // 
            this.btn_endTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_endTask.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_endTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_endTask.Image = ((System.Drawing.Image)(resources.GetObject("btn_endTask.Image")));
            this.btn_endTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_endTask.Location = new System.Drawing.Point(19, 517);
            this.btn_endTask.Name = "btn_endTask";
            this.btn_endTask.Size = new System.Drawing.Size(388, 43);
            this.btn_endTask.TabIndex = 24;
            this.btn_endTask.Text = "End Task";
            this.btn_endTask.UseVisualStyleBackColor = true;
            this.btn_endTask.Click += new System.EventHandler(this.btn_endTask_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 41);
            this.label3.TabIndex = 29;
            this.label3.Text = "Apps:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(426, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 41);
            this.label2.TabIndex = 30;
            this.label2.Text = "Proccess:";
            // 
            // Frm_Active
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_activeTask);
            this.Controls.Add(this.lisV_Apps);
            this.Controls.Add(this.lisV_Process);
            this.Controls.Add(this.partion);
            this.Controls.Add(this.btn_endTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Active";
            this.Text = "Frm_Active";
            this.Load += new System.EventHandler(this.Frm_Active_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_activeTask;
        private System.Windows.Forms.ListView lisV_Apps;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lisV_Process;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel partion;
        private System.Windows.Forms.Button btn_endTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}