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
    public partial class FormXuLi : Form
    {
        DataTable inforAcc = new DataTable();
        List<PictureBox> lPtb = new List<PictureBox>();
        string srcImageTableEmpty = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Assets\\ImagesApplication\\table_empty.png";
        string srcImageTableUsed = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Assets\\ImagesApplication\\table_used.png";
        public FormXuLi()
        {

            InitializeComponent();

        }

        public FormXuLi(DataTable root)
        {
            InitializeComponent();
            inforAcc = root;

            this.AddListPtb();
            this.LoadNewListTable();
        }


        public void AddListPtb()
        {
            lPtb.Add(ptbBan1);
            lPtb.Add(ptbBan2);
            lPtb.Add(ptbBan3);
            lPtb.Add(ptbBan4);
            lPtb.Add(ptbBan5);
            lPtb.Add(ptbBan6);
            lPtb.Add(ptbBan7);
            lPtb.Add(ptbBan8);
            lPtb.Add(ptbBan9);
            lPtb.Add(ptbBan10);
        }

        public void LoadNewListTable()
        {
            foreach(PictureBox box in lPtb)
            {
                box.BorderStyle = BorderStyle.FixedSingle;
                box.Image = Image.FromFile(@"" + this.srcImageTableEmpty);
            }
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

        private void ptbBan1_Click(object sender, EventArgs e)
        {
            ptbBan1.Image = Image.FromFile(@"" + this.srcImageTableUsed);
        }
    }
}
