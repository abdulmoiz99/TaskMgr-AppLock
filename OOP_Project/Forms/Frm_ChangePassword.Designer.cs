namespace OOP_Project.Forms
{
    partial class Frm_ChangePassword
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
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_user = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OldPassword = new System.Windows.Forms.TextBox();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 20;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label8.Location = new System.Drawing.Point(27, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "USER :";
            // 
            // lab_user
            // 
            this.lab_user.AutoSize = true;
            this.lab_user.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lab_user.Location = new System.Drawing.Point(110, 196);
            this.lab_user.Name = "lab_user";
            this.lab_user.Size = new System.Drawing.Size(60, 28);
            this.lab_user.TabIndex = 5;
            this.lab_user.Text = "user";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::OOP_Project.Properties.Resources.male_user_100;
            this.button1.Location = new System.Drawing.Point(9, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 134);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Old Password";
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txt_OldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_OldPassword.Location = new System.Drawing.Point(32, 276);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.Size = new System.Drawing.Size(228, 17);
            this.txt_OldPassword.TabIndex = 8;
            this.txt_OldPassword.Enter += new System.EventHandler(this.txt_OldPassword_Enter);
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txt_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_newPassword.Location = new System.Drawing.Point(32, 355);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.Size = new System.Drawing.Size(225, 17);
            this.txt_newPassword.TabIndex = 10;
            this.txt_newPassword.TextChanged += new System.EventHandler(this.txt_newPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Password";
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ChangePassword.FlatAppearance.BorderSize = 0;
            this.btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_ChangePassword.Location = new System.Drawing.Point(16, 406);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(244, 41);
            this.btn_ChangePassword.TabIndex = 11;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = false;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(16, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 2);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(16, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 2);
            this.panel2.TabIndex = 13;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::OOP_Project.Properties.Resources.close_window_26;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(244, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 27);
            this.btn_close.TabIndex = 14;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 475);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.txt_newPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_OldPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_user);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wx";
            this.Load += new System.EventHandler(this.Frm_ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btn_close;
    }
}