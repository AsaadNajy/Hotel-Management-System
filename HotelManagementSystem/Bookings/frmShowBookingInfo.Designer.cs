﻿namespace HotelManagementSystem.Bookings
{
    partial class frmShowBookingInfo
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
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlBookingInfo1 = new HotelManagementSystem.Bookings.Controls.ctrlBookingInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnClose.BorderRadius = 22;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnClose.FillColor2 = System.Drawing.Color.RosyBrown;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::HotelManagementSystem.Properties.Resources.cancel1;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(762, 597);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 164;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblTitle.Location = new System.Drawing.Point(288, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(358, 46);
            this.lblTitle.TabIndex = 163;
            this.lblTitle.Text = "Booking Information";
            // 
            // ctrlBookingInfo1
            // 
            this.ctrlBookingInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlBookingInfo1.Location = new System.Drawing.Point(19, 69);
            this.ctrlBookingInfo1.Name = "ctrlBookingInfo1";
            this.ctrlBookingInfo1.Size = new System.Drawing.Size(923, 516);
            this.ctrlBookingInfo1.TabIndex = 165;
            // 
            // frmShowBookingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 647);
            this.Controls.Add(this.ctrlBookingInfo1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowBookingInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Booking Info";
            this.Load += new System.EventHandler(this.frmShowBookingInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlBookingInfo ctrlBookingInfo1;
    }
}