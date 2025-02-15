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
    public partial class waitingdetail : Form
    {
        public waitingdetail()
        {
            InitializeComponent();
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
            Admin_Dashboard obj = new Admin_Dashboard();
            obj.Show();
            this.Hide();
        }

        private void lnkdash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Dashboard obj = new Admin_Dashboard();
            obj.Show();
            this.Hide();
        }

        private void lnkcde_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerDetail obj = new CustomerDetail();
            obj.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ApartmentTypes obj = new ApartmentTypes();
            obj.Show();
            this.Hide();
        }

        private void lnkapde_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ApartmentDetail obj = new ApartmentDetail();
            obj.Show();
            this.Hide();
        }

        private void lnkwali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            waitingdetail obj = new waitingdetail();
            obj.Show();
            this.Hide();
        }

        private void lnkaprent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ApartmentReservation obj = new ApartmentReservation();
            obj.Show();
            this.Hide();
        }

        private void lnkrefu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Refunddetail obj = new Refunddetail();
            obj.Show();
            this.Hide();
        }

        private void lnkexde_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExtendLease obj = new ExtendLease();
            obj.Show();
            this.Hide();
        }

        private void lnkpay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerPayment obj = new CustomerPayment();
            obj.Show();
            this.Hide();
        }

        private void lnkre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reports obj = new Reports();
            obj.Show();
            this.Hide();
        }
    }
}
