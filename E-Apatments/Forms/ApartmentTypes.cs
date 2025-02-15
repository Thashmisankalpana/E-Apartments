using E_Apatments.Data;
using E_Apatments.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apatments.Forms
{
    public partial class ApartmentTypes : Form
    {
        public ApartmentTypes()
        {
            InitializeComponent();
        }

        int indexRow;
        AppDbContext _appDbContext;

        private void clear()
        {
            txtaccty.Clear();
            tstrefu.Clear();
            txtfimre.Clear();
            txtpasq.Clear();
        }
        private void updateGrid()
        {
            _appDbContext = new AppDbContext();
            dataGridViewApaTy.DataSource = _appDbContext.ApartmentDetais.ToList();
        }
        private void btnsav_Click(object sender, EventArgs e)
        {
            try
            {
                AppDbContext _appDbContext;
                if (string.IsNullOrEmpty(txtaccty.Text) || string.IsNullOrEmpty(tstrefu.Text) || string.IsNullOrEmpty(txtfimre.Text) || string.IsNullOrEmpty(txtpasq.Text))
                {
                    MessageBox.Show("Fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var apartmentdetai = new ApartmentDetai();

                    apartmentdetai.ApartmentType = txtaccty.Text;
                    apartmentdetai.RefundableDeposit = int.Parse(tstrefu.Text);
                    apartmentdetai.FirstMonthRent = int.Parse(txtfimre.Text);
                    apartmentdetai.ParkingSpaceQuantity = int.Parse(txtpasq.Text);
                    apartmentdetai.Updated= DateTime.Now;

                    _appDbContext = new AppDbContext();
                    _appDbContext.ApartmentDetais.Add(apartmentdetai);
                    _appDbContext.SaveChanges();

                    clear();

                    MessageBox.Show("Data Successfully Saved !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateGrid();
                    clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void ApartmentTypes_Load(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void dataGridViewApaTy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewApaTy.Rows[indexRow];


            txtaccty.Text = row.Cells[0].Value.ToString();
            tstrefu.Text = row.Cells[1].Value.ToString();
            txtfimre.Text = row.Cells[2].Value.ToString();
            txtpasq.Text = row.Cells[3].Value.ToString();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridViewApaTy.Rows[indexRow];
            newDataRow.Cells[0].Value = txtaccty.Text;
            newDataRow.Cells[1].Value = tstrefu.Text;
            newDataRow.Cells[2].Value = txtfimre.Text;
            newDataRow.Cells[3].Value = txtpasq.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ApartmentTypes obj = new ApartmentTypes();
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
