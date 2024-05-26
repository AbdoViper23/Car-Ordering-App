using System;

namespace Car_Ordering_App
{
    partial class signup_frm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.password_lb = new System.Windows.Forms.Label();
            this.Email_lb = new System.Windows.Forms.Label();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.Email_tb = new System.Windows.Forms.TextBox();
            this.name_lb = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.signup_bt = new System.Windows.Forms.Button();
            this.back_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(501, 494);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 23);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // password_lb
            // 
            this.password_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.password_lb.Location = new System.Drawing.Point(151, 382);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(156, 31);
            this.password_lb.TabIndex = 12;
            this.password_lb.Text = "password :";
            // 
            // Email_lb
            // 
            this.Email_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email_lb.AutoSize = true;
            this.Email_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.Email_lb.Location = new System.Drawing.Point(151, 229);
            this.Email_lb.Name = "Email_lb";
            this.Email_lb.Size = new System.Drawing.Size(103, 31);
            this.Email_lb.TabIndex = 11;
            this.Email_lb.Text = "Email :";
            // 
            // pass_tb
            // 
            this.pass_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_tb.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tb.Location = new System.Drawing.Point(157, 436);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(467, 52);
            this.pass_tb.TabIndex = 10;
            this.pass_tb.UseSystemPasswordChar = true;
            // 
            // Email_tb
            // 
            this.Email_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email_tb.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_tb.Location = new System.Drawing.Point(157, 289);
            this.Email_tb.Name = "Email_tb";
            this.Email_tb.Size = new System.Drawing.Size(467, 52);
            this.Email_tb.TabIndex = 9;
            // 
            // name_lb
            // 
            this.name_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.name_lb.Location = new System.Drawing.Point(151, 93);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(107, 31);
            this.name_lb.TabIndex = 15;
            this.name_lb.Text = "Name :";
            // 
            // name_tb
            // 
            this.name_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_tb.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tb.Location = new System.Drawing.Point(157, 153);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(467, 52);
            this.name_tb.TabIndex = 14;
            // 
            // signup_bt
            // 
            this.signup_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_bt.BackColor = System.Drawing.Color.LightGreen;
            this.signup_bt.FlatAppearance.BorderSize = 0;
            this.signup_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_bt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_bt.Location = new System.Drawing.Point(196, 549);
            this.signup_bt.Name = "signup_bt";
            this.signup_bt.Size = new System.Drawing.Size(362, 70);
            this.signup_bt.TabIndex = 16;
            this.signup_bt.Text = "Sign Up";
            this.signup_bt.UseVisualStyleBackColor = false;
            this.signup_bt.Click += new System.EventHandler(this.signup_bt_Click);
            // 
            // back_bt
            // 
            this.back_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_bt.BackColor = System.Drawing.Color.LightGreen;
            this.back_bt.FlatAppearance.BorderSize = 0;
            this.back_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_bt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_bt.Location = new System.Drawing.Point(21, 604);
            this.back_bt.Name = "back_bt";
            this.back_bt.Size = new System.Drawing.Size(111, 38);
            this.back_bt.TabIndex = 17;
            this.back_bt.Text = "back";
            this.back_bt.UseVisualStyleBackColor = false;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            // 
            // signup_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(796, 675);
            this.Controls.Add(this.back_bt);
            this.Controls.Add(this.signup_bt);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.Email_lb);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.Email_tb);
            this.Name = "signup_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup_frm";
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

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Label Email_lb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.TextBox Email_tb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Button signup_bt;
        private System.Windows.Forms.Button back_bt;
    }
}