using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //Form f = new FormTaiKhoan();
                //this.Hide();
                //f.ShowDialog();
                //this.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form f = new FormPermissionAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
