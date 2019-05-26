namespace OOP_Project
{
    partial class Frm_AppLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AppLock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_applock = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_newLock = new System.Windows.Forms.ComboBox();
            this.btn_Lock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_newUnlock = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_UnLock = new System.Windows.Forms.Button();
            this.dgv_currentlyLocked = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_applock.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentlyLocked)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_applock
            // 
            this.pnl_applock.Controls.Add(this.label3);
            this.pnl_applock.Location = new System.Drawing.Point(397, 92);
            this.pnl_applock.Name = "pnl_applock";
            this.pnl_applock.Size = new System.Drawing.Size(317, 380);
            this.pnl_applock.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(67, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 98);
            this.label3.TabIndex = 0;
            this.label3.Text = "No App\r\n   Lock";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cmb_newLock);
            this.groupBox2.Controls.Add(this.btn_Lock);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 223);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lock";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmb_newLock
            // 
            this.cmb_newLock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_newLock.FormattingEnabled = true;
            this.cmb_newLock.Location = new System.Drawing.Point(114, 53);
            this.cmb_newLock.Name = "cmb_newLock";
            this.cmb_newLock.Size = new System.Drawing.Size(215, 29);
            this.cmb_newLock.TabIndex = 2;
            // 
            // btn_Lock
            // 
            this.btn_Lock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Lock.FlatAppearance.BorderSize = 0;
            this.btn_Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lock.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lock.ForeColor = System.Drawing.Color.White;
            this.btn_Lock.Image = global::OOP_Project.Properties.Resources.lock_48;
            this.btn_Lock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lock.Location = new System.Drawing.Point(48, 125);
            this.btn_Lock.Name = "btn_Lock";
            this.btn_Lock.Size = new System.Drawing.Size(249, 73);
            this.btn_Lock.TabIndex = 0;
            this.btn_Lock.Text = "Lock";
            this.btn_Lock.UseVisualStyleBackColor = false;
            this.btn_Lock.Click += new System.EventHandler(this.btn_Lock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "APP NAME:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_newUnlock);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btn_UnLock);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 246);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unlock";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cmb_newUnlock
            // 
            this.cmb_newUnlock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_newUnlock.FormattingEnabled = true;
            this.cmb_newUnlock.Location = new System.Drawing.Point(111, 53);
            this.cmb_newUnlock.Name = "cmb_newUnlock";
            this.cmb_newUnlock.Size = new System.Drawing.Size(215, 29);
            this.cmb_newUnlock.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "APP NAME:";
            // 
            // btn_UnLock
            // 
            this.btn_UnLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_UnLock.FlatAppearance.BorderSize = 0;
            this.btn_UnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UnLock.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UnLock.ForeColor = System.Drawing.Color.White;
            this.btn_UnLock.Image = ((System.Drawing.Image)(resources.GetObject("btn_UnLock.Image")));
            this.btn_UnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UnLock.Location = new System.Drawing.Point(45, 141);
            this.btn_UnLock.Name = "btn_UnLock";
            this.btn_UnLock.Size = new System.Drawing.Size(249, 69);
            this.btn_UnLock.TabIndex = 3;
            this.btn_UnLock.Text = "UnLock";
            this.btn_UnLock.UseVisualStyleBackColor = false;
            this.btn_UnLock.Click += new System.EventHandler(this.btn_inLock_Click);
            // 
            // dgv_currentlyLocked
            // 
            this.dgv_currentlyLocked.AllowUserToAddRows = false;
            this.dgv_currentlyLocked.AllowUserToDeleteRows = false;
            this.dgv_currentlyLocked.BackgroundColor = System.Drawing.Color.White;
            this.dgv_currentlyLocked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_currentlyLocked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_currentlyLocked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_currentlyLocked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_currentlyLocked.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_currentlyLocked.Location = new System.Drawing.Point(397, 80);
            this.dgv_currentlyLocked.Name = "dgv_currentlyLocked";
            this.dgv_currentlyLocked.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_currentlyLocked.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_currentlyLocked.Size = new System.Drawing.Size(317, 357);
            this.dgv_currentlyLocked.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "L_Name";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 270;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(397, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 38);
            this.panel1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Currently Locked";
            // 
            // Frm_AppLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_applock);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_currentlyLocked);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AppLock";
            this.Text = "Frm_AppLock";
            this.Activated += new System.EventHandler(this.Frm_AppLock_Activated);
            this.Load += new System.EventHandler(this.Frm_AppLock_Load);
            this.pnl_applock.ResumeLayout(false);
            this.pnl_applock.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentlyLocked)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_newLock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Lock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_newUnlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_UnLock;
        private System.Windows.Forms.Panel pnl_applock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_currentlyLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}