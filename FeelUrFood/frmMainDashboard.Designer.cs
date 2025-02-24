namespace FeelUrFood
{
    partial class frmMainDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CallForSupportPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.KioskStatusPingBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.LiveViewBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.OperationsBtn = new System.Windows.Forms.Button();
            this.BillingBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.CallForSupportPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.CallForSupportPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 110);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label3.Location = new System.Drawing.Point(237, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Main server";
            // 
            // CallForSupportPanel
            // 
            this.CallForSupportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CallForSupportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.CallForSupportPanel.Controls.Add(this.panel8);
            this.CallForSupportPanel.Controls.Add(this.label2);
            this.CallForSupportPanel.Controls.Add(this.label1);
            this.CallForSupportPanel.Location = new System.Drawing.Point(934, 0);
            this.CallForSupportPanel.Name = "CallForSupportPanel";
            this.CallForSupportPanel.Size = new System.Drawing.Size(251, 110);
            this.CallForSupportPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(107, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "7735069877";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Call For Support";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LogoutBtn);
            this.panel3.Controls.Add(this.KioskStatusPingBtn);
            this.panel3.Controls.Add(this.SettingsBtn);
            this.panel3.Controls.Add(this.LiveViewBtn);
            this.panel3.Controls.Add(this.ReportBtn);
            this.panel3.Controls.Add(this.OperationsBtn);
            this.panel3.Controls.Add(this.BillingBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 535);
            this.panel3.TabIndex = 2;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackgroundImage = global::FeelUrFood.Properties.Resources.power_off__1_;
            this.LogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 419);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(231, 71);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // KioskStatusPingBtn
            // 
            this.KioskStatusPingBtn.BackgroundImage = global::FeelUrFood.Properties.Resources.update__1_;
            this.KioskStatusPingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.KioskStatusPingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KioskStatusPingBtn.Location = new System.Drawing.Point(0, 349);
            this.KioskStatusPingBtn.Name = "KioskStatusPingBtn";
            this.KioskStatusPingBtn.Size = new System.Drawing.Size(231, 71);
            this.KioskStatusPingBtn.TabIndex = 5;
            this.KioskStatusPingBtn.UseVisualStyleBackColor = true;
            this.KioskStatusPingBtn.Click += new System.EventHandler(this.KioskStatusPingBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackgroundImage = global::FeelUrFood.Properties.Resources.setting;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 279);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(231, 71);
            this.SettingsBtn.TabIndex = 4;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // LiveViewBtn
            // 
            this.LiveViewBtn.BackgroundImage = global::FeelUrFood.Properties.Resources.four_squares_button_of_view_options__1_;
            this.LiveViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LiveViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LiveViewBtn.Location = new System.Drawing.Point(0, 209);
            this.LiveViewBtn.Name = "LiveViewBtn";
            this.LiveViewBtn.Size = new System.Drawing.Size(231, 71);
            this.LiveViewBtn.TabIndex = 3;
            this.LiveViewBtn.UseVisualStyleBackColor = true;
            this.LiveViewBtn.Click += new System.EventHandler(this.LiveViewBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackgroundImage = global::FeelUrFood.Properties.Resources.bar_chart__1_;
            this.ReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Location = new System.Drawing.Point(0, 139);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(231, 71);
            this.ReportBtn.TabIndex = 2;
            this.ReportBtn.UseVisualStyleBackColor = true;
            // 
            // OperationsBtn
            // 
            this.OperationsBtn.BackgroundImage = global::FeelUrFood.Properties.Resources.settings__2_;
            this.OperationsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OperationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OperationsBtn.Location = new System.Drawing.Point(0, 69);
            this.OperationsBtn.Name = "OperationsBtn";
            this.OperationsBtn.Size = new System.Drawing.Size(231, 71);
            this.OperationsBtn.TabIndex = 1;
            this.OperationsBtn.UseVisualStyleBackColor = true;
            this.OperationsBtn.Click += new System.EventHandler(this.OperationsBtn_Click);
            // 
            // BillingBtn
            // 
            this.BillingBtn.BackgroundImage = global::FeelUrFood.Properties.Resources.receipt__1_;
            this.BillingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BillingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillingBtn.Location = new System.Drawing.Point(0, -1);
            this.BillingBtn.Name = "BillingBtn";
            this.BillingBtn.Size = new System.Drawing.Size(231, 71);
            this.BillingBtn.TabIndex = 0;
            this.BillingBtn.UseVisualStyleBackColor = true;
            this.BillingBtn.Click += new System.EventHandler(this.BillingBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FeelUrFood.Properties.Resources.FYF__2_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 110);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackgroundImage = global::FeelUrFood.Properties.Resources.store;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(793, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(41, 35);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackgroundImage = global::FeelUrFood.Properties.Resources.setting1;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(840, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(41, 35);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackgroundImage = global::FeelUrFood.Properties.Resources.notification;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(887, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 35);
            this.panel5.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::FeelUrFood.Properties.Resources.customer_support;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(10, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(41, 35);
            this.panel8.TabIndex = 3;
            // 
            // frmMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CallForSupportPanel.ResumeLayout(false);
            this.CallForSupportPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button KioskStatusPingBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button LiveViewBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button OperationsBtn;
        private System.Windows.Forms.Button BillingBtn;
        private System.Windows.Forms.Panel CallForSupportPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}