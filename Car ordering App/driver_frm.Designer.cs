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
    partial class driver_form
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
            this.request_email_txt = new System.Windows.Forms.TextBox();
            this.car_plate_txt = new System.Windows.Forms.TextBox();
            this.driver_confirm_btn = new System.Windows.Forms.Button();
            this.car_plate_label = new System.Windows.Forms.Label();
            this.request_Email_label = new System.Windows.Forms.Label();
            this.data_Viewer = new System.Windows.Forms.DataGridView();
            this.ref_request_bt = new System.Windows.Forms.Button();
            this.request_list_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // request_email_txt
            // 
            this.request_email_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.request_email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_email_txt.Location = new System.Drawing.Point(226, 316);
            this.request_email_txt.Name = "request_email_txt";
            this.request_email_txt.Size = new System.Drawing.Size(227, 38);
            this.request_email_txt.TabIndex = 0;
            // 
            // car_plate_txt
            // 
            this.car_plate_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.car_plate_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_plate_txt.Location = new System.Drawing.Point(226, 208);
            this.car_plate_txt.Name = "car_plate_txt";
            this.car_plate_txt.Size = new System.Drawing.Size(227, 38);
            this.car_plate_txt.TabIndex = 1;
            // 
            // driver_confirm_btn
            // 
            this.driver_confirm_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.driver_confirm_btn.BackColor = System.Drawing.Color.LightGreen;
            this.driver_confirm_btn.FlatAppearance.BorderSize = 0;
            this.driver_confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driver_confirm_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver_confirm_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.driver_confirm_btn.Location = new System.Drawing.Point(211, 454);
            this.driver_confirm_btn.Name = "driver_confirm_btn";
            this.driver_confirm_btn.Size = new System.Drawing.Size(200, 50);
            this.driver_confirm_btn.TabIndex = 17;
            this.driver_confirm_btn.Text = "Confirm";
            this.driver_confirm_btn.UseVisualStyleBackColor = false;
            this.driver_confirm_btn.Click += new System.EventHandler(this.driver_confirm_btn_Click);
            // 
            // car_plate_label
            // 
            this.car_plate_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.car_plate_label.AutoSize = true;
            this.car_plate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_plate_label.ForeColor = System.Drawing.SystemColors.Control;
            this.car_plate_label.Location = new System.Drawing.Point(8, 211);
            this.car_plate_label.Name = "car_plate_label";
            this.car_plate_label.Size = new System.Drawing.Size(153, 31);
            this.car_plate_label.TabIndex = 18;
            this.car_plate_label.Text = "Car Plate: ";
            // 
            // request_Email_label
            // 
            this.request_Email_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.request_Email_label.AutoSize = true;
            this.request_Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_Email_label.ForeColor = System.Drawing.SystemColors.Control;
            this.request_Email_label.Location = new System.Drawing.Point(-10, 316);
            this.request_Email_label.Name = "request_Email_label";
            this.request_Email_label.Size = new System.Drawing.Size(212, 31);
            this.request_Email_label.TabIndex = 19;
            this.request_Email_label.Text = "Request Email:";
            // 
            // data_Viewer
            // 
            this.data_Viewer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.data_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Viewer.Location = new System.Drawing.Point(491, 102);
            this.data_Viewer.Name = "data_Viewer";
            this.data_Viewer.ReadOnly = true;
            this.data_Viewer.RowHeadersWidth = 51;
            this.data_Viewer.RowTemplate.Height = 24;
            this.data_Viewer.Size = new System.Drawing.Size(856, 342);
            this.data_Viewer.TabIndex = 20;
            // 
            // ref_request_bt
            // 
            this.ref_request_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ref_request_bt.BackColor = System.Drawing.Color.LightGreen;
            this.ref_request_bt.FlatAppearance.BorderSize = 0;
            this.ref_request_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ref_request_bt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ref_request_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ref_request_bt.Location = new System.Drawing.Point(804, 502);
            this.ref_request_bt.Name = "ref_request_bt";
            this.ref_request_bt.Size = new System.Drawing.Size(260, 54);
            this.ref_request_bt.TabIndex = 21;
            this.ref_request_bt.Text = "Reload requests";
            this.ref_request_bt.UseVisualStyleBackColor = false;
            this.ref_request_bt.Click += new System.EventHandler(this.ref_request_bt_Click);
            // 
            // request_list_lb
            // 
            this.request_list_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.request_list_lb.AutoSize = true;
            this.request_list_lb.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_list_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.request_list_lb.Location = new System.Drawing.Point(799, 49);
            this.request_list_lb.Name = "request_list_lb";
            this.request_list_lb.Size = new System.Drawing.Size(205, 30);
            this.request_list_lb.TabIndex = 22;
            this.request_list_lb.Text = "request List";
            // 
            // driver_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1401, 726);
            this.Controls.Add(this.request_list_lb);
            this.Controls.Add(this.ref_request_bt);
            this.Controls.Add(this.data_Viewer);
            this.Controls.Add(this.request_Email_label);
            this.Controls.Add(this.car_plate_label);
            this.Controls.Add(this.driver_confirm_btn);
            this.Controls.Add(this.request_email_txt);
            this.Controls.Add(this.car_plate_txt);
            this.Name = "driver_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "driver_form";
            ((System.ComponentModel.ISupportInitialize)(this.data_Viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    private TextBox request_email_txt;
    private TextBox car_plate_txt;

        #endregion

        private Button driver_confirm_btn;
        private Label car_plate_label;
        private Label request_Email_label;
        private DataGridView data_Viewer;
        private Button ref_request_bt;
        private Label request_list_lb;
    }
}