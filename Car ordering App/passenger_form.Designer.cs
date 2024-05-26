using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Ordering_App
{
    partial class passenger_form
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
            this.button_request = new System.Windows.Forms.Button();
            this.pick_up_point_lb = new System.Windows.Forms.Label();
            this.Trip_price_lb = new System.Windows.Forms.Label();
            this.drop_point_lb = new System.Windows.Forms.Label();
            this.pick_up_tb = new System.Windows.Forms.TextBox();
            this.txt_drop = new System.Windows.Forms.TextBox();
            this.Trip_price_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_request
            // 
            this.button_request.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_request.BackColor = System.Drawing.Color.LightGreen;
            this.button_request.FlatAppearance.BorderSize = 0;
            this.button_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_request.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_request.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_request.Location = new System.Drawing.Point(292, 301);
            this.button_request.Name = "button_request";
            this.button_request.Size = new System.Drawing.Size(204, 70);
            this.button_request.TabIndex = 7;
            this.button_request.Text = "Send Request";
            this.button_request.UseVisualStyleBackColor = false;
            this.button_request.Click += new System.EventHandler(this.button_request_Click);
            // 
            // pick_up_point_lb
            // 
            this.pick_up_point_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pick_up_point_lb.AutoSize = true;
            this.pick_up_point_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_up_point_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.pick_up_point_lb.Location = new System.Drawing.Point(162, 65);
            this.pick_up_point_lb.Name = "pick_up_point_lb";
            this.pick_up_point_lb.Size = new System.Drawing.Size(196, 31);
            this.pick_up_point_lb.TabIndex = 19;
            this.pick_up_point_lb.Text = "pick up point :";
            // 
            // Trip_price_lb
            // 
            this.Trip_price_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Trip_price_lb.AutoSize = true;
            this.Trip_price_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trip_price_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.Trip_price_lb.Location = new System.Drawing.Point(162, 220);
            this.Trip_price_lb.Name = "Trip_price_lb";
            this.Trip_price_lb.Size = new System.Drawing.Size(154, 31);
            this.Trip_price_lb.TabIndex = 20;
            this.Trip_price_lb.Text = "Trip price :";
            // 
            // drop_point_lb
            // 
            this.drop_point_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drop_point_lb.AutoSize = true;
            this.drop_point_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_point_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.drop_point_lb.Location = new System.Drawing.Point(162, 144);
            this.drop_point_lb.Name = "drop_point_lb";
            this.drop_point_lb.Size = new System.Drawing.Size(161, 31);
            this.drop_point_lb.TabIndex = 21;
            this.drop_point_lb.Text = "drop point :";
            // 
            // pick_up_tb
            // 
            this.pick_up_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pick_up_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_up_tb.Location = new System.Drawing.Point(376, 65);
            this.pick_up_tb.Name = "pick_up_tb";
            this.pick_up_tb.Size = new System.Drawing.Size(227, 38);
            this.pick_up_tb.TabIndex = 22;
            // 
            // txt_drop
            // 
            this.txt_drop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_drop.Location = new System.Drawing.Point(376, 144);
            this.txt_drop.Name = "txt_drop";
            this.txt_drop.Size = new System.Drawing.Size(227, 38);
            this.txt_drop.TabIndex = 23;
            // 
            // Trip_price_tb
            // 
            this.Trip_price_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Trip_price_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trip_price_tb.Location = new System.Drawing.Point(376, 220);
            this.Trip_price_tb.Name = "Trip_price_tb";
            this.Trip_price_tb.Size = new System.Drawing.Size(227, 38);
            this.Trip_price_tb.TabIndex = 24;
            // 
            // passenger_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(837, 462);
            this.Controls.Add(this.Trip_price_tb);
            this.Controls.Add(this.txt_drop);
            this.Controls.Add(this.pick_up_tb);
            this.Controls.Add(this.drop_point_lb);
            this.Controls.Add(this.Trip_price_lb);
            this.Controls.Add(this.pick_up_point_lb);
            this.Controls.Add(this.button_request);
            this.Name = "passenger_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_request;
        private Label pick_up_point_lb;
        private Label Trip_price_lb;
        private Label drop_point_lb;
        private TextBox pick_up_tb;
        private TextBox txt_drop;
        private TextBox Trip_price_tb;
    }
}