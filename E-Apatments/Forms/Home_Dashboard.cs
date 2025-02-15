using E_Apatments.Data;
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
    public partial class Home_Dashboard : Form
    {
        public Home_Dashboard()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        private void updateGrid()
        {
            _appDbContext = new AppDbContext();
            dataGridView1.DataSource = _appDbContext.ApartmentDetais.ToList();
        }
        private void btnregno_Click(object sender, EventArgs e)
        {
            CustomerRegister obj = new CustomerRegister();
            obj.Show();
            this.Hide();
        }

        private void Home_Dashboard_Load(object sender, EventArgs e)
        {
            updateGrid();
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

        private void linklog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
