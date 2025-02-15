using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apatments.Forms
{
    public partial class CustomerPayment : Form
    {
        public CustomerPayment()
        {
            InitializeComponent();
        }

        private void lnkcda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Dashboard obj = new Customer_Dashboard();
            obj.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reservation obj = new Reservation();
            obj.Show();
            this.Hide();
        }

        private void lnkexe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerExtendLease obj = new CustomerExtendLease();
            obj.Show();
            this.Hide();
        }

        private void lnkpay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PaymentCustomer obj = new PaymentCustomer();
            obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult ResExit = MessageBox.Show("Are You Sure,You Want To Exit!!!", "Confirm To Exit",
MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ResExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Customer_Dashboard obj = new Customer_Dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
