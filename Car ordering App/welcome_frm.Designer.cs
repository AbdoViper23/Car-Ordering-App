namespace Car_Ordering_App
{
    partial class welcome_frm
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
            this.passenger_bt = new System.Windows.Forms.Button();
            this.driver_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passenger_bt
            // 
            this.passenger_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passenger_bt.BackColor = System.Drawing.Color.LightGreen;
            this.passenger_bt.FlatAppearance.BorderSize = 0;
            this.passenger_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passenger_bt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passenger_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passenger_bt.Location = new System.Drawing.Point(21, 291);
            this.passenger_bt.Name = "passenger_bt";
            this.passenger_bt.Size = new System.Drawing.Size(362, 70);
            this.passenger_bt.TabIndex = 6;
            this.passenger_bt.Text = "I\'m a Passenger";
            this.passenger_bt.UseVisualStyleBackColor = false;
            this.passenger_bt.Click += new System.EventHandler(this.passenger_bt_Click);
            // 
            // driver_bt
            // 
            this.driver_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.driver_bt.BackColor = System.Drawing.Color.LightGreen;
            this.driver_bt.FlatAppearance.BorderSize = 0;
            this.driver_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driver_bt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.driver_bt.Location = new System.Drawing.Point(407, 291);
            this.driver_bt.Name = "driver_bt";
            this.driver_bt.Size = new System.Drawing.Size(362, 70);
            this.driver_bt.TabIndex = 7;
            this.driver_bt.Text = "I\'m a Driver";
            this.driver_bt.UseVisualStyleBackColor = false;
            this.driver_bt.Click += new System.EventHandler(this.driver_bt_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 113);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome ";
            // 
            // welcome_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driver_bt);
            this.Controls.Add(this.passenger_bt);
            this.Name = "welcome_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome_frm";
            this.Load += new System.EventHandler(this.welcome_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passenger_bt;
        private System.Windows.Forms.Button driver_bt;
        private System.Windows.Forms.Label label1;
    }
}