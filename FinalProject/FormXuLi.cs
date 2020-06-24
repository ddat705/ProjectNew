using FinalProject.ModelClass;
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
        List<Table> lTable = new List<Table>();
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
            for(int i = 0; i<10; i++)
            {
                Table a = new Table();
                lTable.Add(a);
            }
            lTable[0].ptb = ptbBan1;
            lTable[1].ptb = ptbBan2;
            lTable[2].ptb = ptbBan3;
            lTable[3].ptb = ptbBan4;
            lTable[4].ptb = ptbBan5;
            lTable[5].ptb = ptbBan6;
            lTable[6].ptb = ptbBan7;
            lTable[7].ptb = ptbBan8;
            lTable[8].ptb = ptbBan9;
            lTable[9].ptb = ptbBan10;
            //lPtb.Add(ptbBan1);
            //lPtb.Add(ptbBan2);
            //lPtb.Add(ptbBan3);
            //lPtb.Add(ptbBan4);
            //lPtb.Add(ptbBan5);
            //lPtb.Add(ptbBan6);
            //lPtb.Add(ptbBan7);
            //lPtb.Add(ptbBan8);
            //lPtb.Add(ptbBan9);
            //lPtb.Add(ptbBan10);
        }

        public void LoadNewListTable()
        {
            foreach (Table t in lTable)
            {
                t.setTableEmpty(srcImageTableEmpty);
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

        public void setBorderListTable(int index)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == index)
                {
                    lTable[i].setBorderStyle();
                }
                else
                {
                    lTable[i].setBorderStyleNull();
                }
            }
        }

        private void ptbBan1_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(0);
            if(lTable[0].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[0].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[0].setTableEmpty(srcImageTableEmpty);
            //}
        }
      

        private void ptbBan2_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(1);
            if (lTable[1].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[1].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[1].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan3_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(2);
            if (lTable[2].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[2].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[2].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan4_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(3);
            if (lTable[3].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[3].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[3].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan5_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(4);
            if (lTable[4].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[4].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[4].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan6_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(5);
            if (lTable[5].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[5].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[5].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan7_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(6);
            if (lTable[6].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[6].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[6].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan8_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(7);
            if (lTable[7].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[7].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[7].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan9_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(8);
            if (lTable[8].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[8].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[8].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan10_Click(object sender, EventArgs e)
        {
            this.setBorderListTable(9);
            if (lTable[9].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[9].setTableIsUsed(srcImageTableUsed);
                }
            }
            //else
            //{
            //    lTable[9].setTableEmpty(srcImageTableEmpty);
            //}
        }
    }
}
