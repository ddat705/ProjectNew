﻿using System;
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
    public partial class FormXuLi : Form
    {
        DataTable inforAcc = new DataTable();
        public FormXuLi()
        {
            InitializeComponent();
        }

        public FormXuLi(DataTable root)
        {
            InitializeComponent();
            inforAcc = root;
        }

        private void MenuManager_Click(object sender, EventArgs e)
        {
            Form fMenuManager = new FormMenuManager();
            this.Hide();
            fMenuManager.ShowDialog();
            this.Show();
        }

        private void FormXuLi_Load(object sender, EventArgs e)
        {

        }

        private void StaffManager_Click(object sender, EventArgs e)
        {
            Form fQLNV = new FormQuanLiNV();
            this.Hide();
            fQLNV.ShowDialog();
            this.Show();
        }

        private void SaleManager_Click(object sender, EventArgs e)
        {
            Form fThongKe = new FormThongKe();
            this.Hide();
            fThongKe.ShowDialog();
            this.Show();
        }

        private void InfoAccount_Click(object sender, EventArgs e)
        {
            Form fInfoAccount = new FormPermissionAdmin(this.inforAcc);
            this.Hide();
            fInfoAccount.ShowDialog();
            this.Show();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            Form fThemTK = new FormAddAccount();
            this.Hide();
            fThemTK.ShowDialog();
            this.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form fLogin = new FormLogin();
            this.Close();
            
        }

        private void FormXuLi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Bạn muốn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rep != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
