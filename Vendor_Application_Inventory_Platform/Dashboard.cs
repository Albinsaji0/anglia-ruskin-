﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace Vendor_Application_Inventory_Platform
{

    public partial class Dashboard : Form


    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn

            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));


            this.pnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Check if the user clicked the X button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Display a confirmation dialog
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicks "No," cancel the form closing
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                // If the user clicks "Yes," allow the form to close
                else
                {
                    // Perform any additional cleanup or save operations if needed
                    // ...

                    // Close the application
                    Application.Exit();
                }
            }
        } 
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            frmProfilePrev frmProfilePrev_Vrb = new frmProfilePrev() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProfilePrev_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmProfilePrev_Vrb);
            frmProfilePrev_Vrb.Show();
        }

        //
        private void contactBtn_Click(object sender, EventArgs e)
        {


            this.pnlFormLoader.Controls.Clear();
            frmContact frmContact_Vrb = new frmContact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmContact_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmContact_Vrb);
            frmContact_Vrb.Show();
        }

        //
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        //
        private void homeBtn_Click_1(object sender, EventArgs e)
        {


            this.pnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        //
        private void vendorBtn_Click(object sender, EventArgs e)
        {


            this.pnlFormLoader.Controls.Clear();
            frmVendors frmVendors_Vrb = new frmVendors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmVendors_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmVendors_Vrb);
            frmVendors_Vrb.Show();
        }

        //
        private void homeBtn_Leave_1(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(255, 255, 255);
        }

        //
        private void vendorBtn_Leave(object sender, EventArgs e)
        {
            vendorBtn.BackColor = Color.FromArgb(255, 255, 255);
        }

        //
        private void contactBtn_Leave(object sender, EventArgs e)
        {
            contactBtn.BackColor = Color.FromArgb(255, 255, 255);
        }






        //
        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlFormLoader_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void vendorBtn_Click_1(object sender, EventArgs e)
        {


            this.pnlFormLoader.Controls.Clear();
            frmVendors frmVendors_Vrb = new frmVendors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmVendors_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmVendors_Vrb);
            frmVendors_Vrb.Show();

        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void pnlFormLoader_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {


            this.pnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void contactBtn_Click_1(object sender, EventArgs e)
        {

            this.pnlFormLoader.Controls.Clear();
            frmContact frmContact_Vrb = new frmContact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmContact_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmContact_Vrb);
            frmContact_Vrb.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

            this.pnlFormLoader.Controls.Clear();
            frmProfilePrev frmProfilePrev_Vrb = new frmProfilePrev() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frmProfilePrev_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmProfilePrev_Vrb);
            frmProfilePrev_Vrb.Show();
        }

        private void pnlFormLoader_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }
        

           
    }
}

