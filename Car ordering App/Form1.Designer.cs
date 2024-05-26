using System;

namespace Car_Ordering_App
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
            this.email_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.Email_lb = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.signup_bt = new System.Windows.Forms.Button();
            this.login_bt = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // email_tb
            // 
            this.email_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email_tb.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tb.Location = new System.Drawing.Point(105, 153);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(467, 52);
            this.email_tb.TabIndex = 0;
            // 
            // pass_tb
            // 
            this.pass_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_tb.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tb.Location = new System.Drawing.Point(105, 300);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(467, 52);
            this.pass_tb.TabIndex = 1;
            this.pass_tb.UseSystemPasswordChar = true;
            // 
            // Email_lb
            // 
            this.Email_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email_lb.AutoSize = true;
            this.Email_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.Email_lb.Location = new System.Drawing.Point(99, 93);
            this.Email_lb.Name = "Email_lb";
            this.Email_lb.Size = new System.Drawing.Size(103, 31);
            this.Email_lb.TabIndex = 2;
            this.Email_lb.Text = "Email :";
            // 
            // password_lb
            // 
            this.password_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.password_lb.Location = new System.Drawing.Point(99, 246);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(156, 31);
            this.password_lb.TabIndex = 3;
            this.password_lb.Text = "password :";
            // 
            // signup_bt
            // 
            this.signup_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_bt.BackColor = System.Drawing.Color.LightGreen;
            this.signup_bt.FlatAppearance.BorderSize = 0;
            this.signup_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_bt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_bt.Location = new System.Drawing.Point(142, 504);
            this.signup_bt.Name = "signup_bt";
            this.signup_bt.Size = new System.Drawing.Size(362, 70);
            this.signup_bt.TabIndex = 4;
            this.signup_bt.Text = "Sign Up";
            this.signup_bt.UseVisualStyleBackColor = false;
            this.signup_bt.Click += new System.EventHandler(this.signup_bt_Click);
            // 
            // login_bt
            // 
            this.login_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_bt.BackColor = System.Drawing.Color.LightGreen;
            this.login_bt.FlatAppearance.BorderSize = 0;
            this.login_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_bt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_bt.Location = new System.Drawing.Point(142, 408);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(362, 70);
            this.login_bt.TabIndex = 5;
            this.login_bt.Text = "Log In";
            this.login_bt.UseVisualStyleBackColor = false;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(449, 358);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 23);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(723, 641);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.signup_bt);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.Email_lb);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.email_tb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Show password using Checkbox
            if (checkBox1.Checked)
            {
                pass_tb.UseSystemPasswordChar = false;
            }
            else
            {
                pass_tb.UseSystemPasswordChar = true;
            }
        }
        #endregion

        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Label Email_lb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Button signup_bt;
        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

