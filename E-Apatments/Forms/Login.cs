using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apatments
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
    }
}
