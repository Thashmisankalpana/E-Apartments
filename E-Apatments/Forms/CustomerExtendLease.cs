using E_Apatments.Data;
using E_Apatments.Models;
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
    public partial class CustomerExtendLease : Form
    {
        public CustomerExtendLease()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        private void lnkexe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerExtendLease obj = new CustomerExtendLease();
            obj.Show();
            this.Hide();
        }

        private void lnkcda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Dashboard obj = new Customer_Dashboard();
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

        private void btnapr_Click(object sender, EventArgs e)
        {
            try
            {
                AppDbContext _appDbContext;
                if (string.IsNullOrEmpty(txtflep.Text) || string.IsNullOrEmpty(tstnte.Text) || string.IsNullOrEmpty(txtnop.Text))
                {
                    MessageBox.Show("Fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var extenddetail = new ExtendDetail();

                    extenddetail.NICorPassport = txtflep.Text;
                    extenddetail.Name = (tstnte.Text);
                    extenddetail.NumberofDaysExtend = int.Parse(txtnop.Text);

                    _appDbContext = new AppDbContext();
                    _appDbContext.ExtendDetails.Add(extenddetail);
                    _appDbContext.SaveChanges();

                    MessageBox.Show("Data Successfully Saved !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateGrid();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void updateGrid()
        {
            _appDbContext = new AppDbContext();
            dataGridViewApaTy.DataSource = _appDbContext.CustomRegis.ToList();
        }

        private void CustomerExtendLease_Load(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reservation obj = new Reservation();
            obj.Show();
            this.Hide();
        }

        private void lnkpay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PaymentCustomer obj = new PaymentCustomer();
            obj.Show();
            this.Hide();
        }
    }
}
