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
    public partial class ApartmentDetail : Form
    {
        public ApartmentDetail()
        {
            InitializeComponent();
        }
        int indexRow;
        AppDbContext _appDbContext;

        private void clear()
        {
            txtloc.Clear();
            txtmubui.Clear();
            txtcls1q.Clear();
            txtcls3q.Clear();
            txtparsq.Clear();
            txtcls2q.Clear();
            txtstq.Clear();
            txtbunasta.Clear();
            txtpsnsta.Clear();
        }
        private void updateGrid()
        {
            _appDbContext = new AppDbContext();
            dataGridViewApade.DataSource = _appDbContext.ApartmentAllDetas.ToList();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Admin_Dashboard obj = new Admin_Dashboard();
            obj.Show();
            this.Hide();
        }

        private void btnsav_Click(object sender, EventArgs e)
        {
            try
            {
                AppDbContext _appDbContext;
                if (string.IsNullOrEmpty(txtloc.Text) || string.IsNullOrEmpty(txtmubui.Text) || string.IsNullOrEmpty(txtbunasta.Text) || string.IsNullOrEmpty(txtcls1q.Text)
                    || string.IsNullOrEmpty(txtcls2q.Text) || string.IsNullOrEmpty(txtcls3q.Text) || string.IsNullOrEmpty(txtstq.Text) || string.IsNullOrEmpty(txtparsq.Text)
                    || string.IsNullOrEmpty(txtpsnsta.Text))
                {
                    MessageBox.Show("Fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var apartmentalldeta = new ApartmentAllDeta();

                    apartmentalldeta.Location = txtloc.Text;
                    apartmentalldeta.MultiStoriedBuildingQuantity = int.Parse(txtmubui.Text);
                    apartmentalldeta.BuildingNameStarted = (txtbunasta.Text);
                    apartmentalldeta.Class1ApartmentsQuantity = int.Parse(txtcls1q.Text);
                    apartmentalldeta.Class2ApartmentsQuantity = int.Parse(txtcls2q.Text);
                    apartmentalldeta.Class3ApartmentsQuantity = int.Parse(txtcls3q.Text);
                    apartmentalldeta.StateApartmentsQuantity = int.Parse(txtstq.Text);
                    apartmentalldeta.ParkingSpaceQuantity = int.Parse(txtparsq.Text);
                    apartmentalldeta.ParkingSpaceNameStarted = (txtpsnsta.Text);
                    apartmentalldeta.AddedAt = DateTime.Now;

                    _appDbContext = new AppDbContext();
                    _appDbContext.ApartmentAllDetas.Add(apartmentalldeta);
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

        private void btnup_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridViewApade.Rows[indexRow];
            newDataRow.Cells[1].Value = txtmubui.Text;
            newDataRow.Cells[3].Value = txtcls1q.Text;
            newDataRow.Cells[4].Value = txtcls2q.Text;
            newDataRow.Cells[5].Value = txtcls3q.Text;
            newDataRow.Cells[6].Value = txtstq.Text;
            newDataRow.Cells[7].Value = txtparsq.Text;
        }

        private void dataGridViewApade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridViewApade.Rows[indexRow];


            txtmubui.Text = row.Cells[1].Value.ToString();
            txtcls1q.Text = row.Cells[3].Value.ToString();
            txtcls2q.Text = row.Cells[4].Value.ToString();
            txtcls3q.Text = row.Cells[5].Value.ToString();
            txtstq.Text = row.Cells[6].Value.ToString();
            txtparsq.Text = row.Cells[7].Value.ToString();
        }

        private void ApartmentDetail_Load(object sender, EventArgs e)
        {
            updateGrid();
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
