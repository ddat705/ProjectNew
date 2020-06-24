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

        public void Login()
        {
            DTacc = BLacc.LayTaiKhoanByUsername(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (DTacc.Rows.Count != 0)
            {
                try
                {
                    Form f = new FormXuLi();
                    this.Hide();
                    f.ShowDialog();       
                    this.txtPassword.Text = "";
                    this.txtUsername.Text = "";
                    this.Show();
                }
                catch
                {

                }

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Login();
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Bạn muốn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rep != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
