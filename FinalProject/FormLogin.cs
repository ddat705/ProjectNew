using FinalProject.BS_Layer;
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

        BLAccount BLacc = new BLAccount();
        DataTable DTacc = new DataTable();

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
                this.Login();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                this.Login();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            DTacc = this.BLacc.LayTaiKhoanByUsername(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (DTacc.Rows.Count != 0)
            {
                Form f = new FormXuLi();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Login();
            }
        }
    }
}
