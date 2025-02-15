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
    public partial class CustomerRegister : Form
    {
        public CustomerRegister()
        {
            InitializeComponent();
        }

        private void txtmail_Validating(object sender, CancelEventArgs e)
        {
            if (!this.txtmail.Text.Contains('@') || !this.txtmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            txtaccty.Clear();
            txtName.Clear();
            txtadd.Clear();
            txtcon.Clear();
            txtnop.Clear();
            txtmail.Clear();
            txtdep1.Clear();
            txtdep2.Clear();
            txtdep3.Clear();
            txtdep4.Clear();
            txtdepo.Clear();
            txtusna.Clear();
            txtpass.Clear();
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

        private void btnregi_Click(object sender, EventArgs e)
        {
            try
            {
                AppDbContext _appDbContext;
                if (string.IsNullOrEmpty(txtaccty.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtadd.Text)
                    || string.IsNullOrEmpty(txtcon.Text) || string.IsNullOrEmpty(txtnop.Text) || string.IsNullOrEmpty(txtmail.Text))
                {
                    MessageBox.Show("Fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var customregi = new CustomRegi();

                    customregi.CusId = Guid.NewGuid();
                    customregi.AcountType = txtaccty.Text;
                    customregi.Name = txtName.Text;
                    customregi.AlternateAddress = txtadd.Text;
                    customregi.ContactNumber = txtcon.Text;
                    customregi.NICPassportNo = txtnop.Text;
                    customregi.Email = txtmail.Text;
                    customregi.Dependent1 = txtdep1.Text;
                    customregi.Dependent2 = txtdep2.Text;
                    customregi.Dependent3 = txtdep3.Text;
                    customregi.Dependent4 = txtdep4.Text;
                    customregi.OtherDependent = txtdepo.Text;
                    customregi.Username = txtusna.Text;
                    customregi.Password = txtpass.Text;
                    customregi.RegisterAt = DateTime.Now;

                    _appDbContext = new AppDbContext();
                    _appDbContext.CustomRegis.Add(customregi);
                    _appDbContext.SaveChanges();

                    clear();

                    MessageBox.Show("Data Successfully Saved !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
