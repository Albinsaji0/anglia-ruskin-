﻿
namespace Vendor_Application_Inventory_Platform
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            contactBtn = new Button();
            vendorBtn = new Button();
            homeBtn = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(contactBtn);
            panel1.Controls.Add(vendorBtn);
            panel1.Controls.Add(homeBtn);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 80);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // contactBtn
            // 
            contactBtn.Dock = DockStyle.Left;
            contactBtn.FlatAppearance.BorderSize = 0;
            contactBtn.FlatStyle = FlatStyle.Popup;
            contactBtn.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            contactBtn.ForeColor = SystemColors.Desktop;
            contactBtn.Location = new Point(395, 0);
            contactBtn.Name = "contactBtn";
            contactBtn.Size = new Size(137, 80);
            contactBtn.TabIndex = 3;
            contactBtn.Text = "Contact Us";
            contactBtn.UseVisualStyleBackColor = true;
            contactBtn.Click += contactBtn_Click_1;
            // 
            // vendorBtn
            // 
            vendorBtn.Dock = DockStyle.Left;
            vendorBtn.FlatAppearance.BorderSize = 0;
            vendorBtn.FlatStyle = FlatStyle.Popup;
            vendorBtn.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            vendorBtn.ForeColor = SystemColors.Desktop;
            vendorBtn.Location = new Point(258, 0);
            vendorBtn.Name = "vendorBtn";
            vendorBtn.Size = new Size(137, 80);
            vendorBtn.TabIndex = 2;
            vendorBtn.Text = "Vendors";
            vendorBtn.UseVisualStyleBackColor = true;
            vendorBtn.Click += vendorBtn_Click_1;
            // 
            // homeBtn
            // 
            homeBtn.Dock = DockStyle.Left;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Popup;
            homeBtn.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            homeBtn.ForeColor = SystemColors.Desktop;
            homeBtn.Location = new Point(121, 0);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(137, 80);
            homeBtn.TabIndex = 1;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.Screenshot_2023_11_10_004008;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(834, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(71, 80);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.ImeMode = ImeMode.NoControl;
            pnlFormLoader.Location = new Point(0, 75);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(905, 426);
            pnlFormLoader.TabIndex = 3;
            pnlFormLoader.Paint += pnlFormLoader_Paint_3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(905, 512);
            Controls.Add(panel1);
            Controls.Add(pnlFormLoader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CITISOFT | Dashboard";
            Load += Dashboard_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button homeBtn;
        private Button contactBtn;
        private Button vendorBtn;
        private Panel pnlNav;
        private Panel pnlFormLoader;
    }
}