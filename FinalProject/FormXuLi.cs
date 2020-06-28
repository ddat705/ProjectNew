using FinalProject.BS_Layer;
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
        private DataTable inforAcc = new DataTable();
        private List<Table> lTable = new List<Table>();

        private int BanDangChon;
        private int monDangChon;

        string srcImageTableEmpty = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Assets\\ImagesApplication\\table_empty.png";
        string srcImageTableUsed = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Assets\\ImagesApplication\\table_used.png";

        private DataTable dtMenu = new DataTable();
        private BLAccount BLAcc = new BLAccount();
        
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
            this.cbBoxLoai.SelectedIndex = 0;
            this.reload(0);
        }

        public void reload(int check)
        {
            if(check == 0)
            {
                dtMenu = BLAcc.getMenuAll();
            }
            else
            {
                dtMenu = BLAcc.getMenuByLoai(check.ToString());             
            }
            cbBoxTenMon.Items.Clear();
            foreach(DataRow x in dtMenu.Rows)
            {
                cbBoxTenMon.Items.Add(x[1].ToString());
            }
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
                    if(lTable[i].isUsed == false)
                    {
                        lTable[i].setBorderStyle();
                        this.BanDangChon = index;
                        this.test();
                    }

                }
                else
                {
                    lTable[i].setBorderStyleNull();
                }
            }
            this.lbTextSelectedTable.Text = "Bàn " + Convert.ToString(this.BanDangChon + 1);
        }

        private void ptbBan1_Click(object sender, EventArgs e)
        {            
            if(lTable[0].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[0].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(0);

                }
            }
            else
                this.setBorderListTable(0);
            //else
            //{
            //    lTable[0].setTableEmpty(srcImageTableEmpty);
            //}
        }
      

        private void ptbBan2_Click(object sender, EventArgs e)
        {
            if (lTable[1].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[1].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(1);
                }
            }
            else
                this.setBorderListTable(1);

            //else
            //{
            //    lTable[1].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan3_Click(object sender, EventArgs e)
        {
            if (lTable[2].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[2].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(2);
                }
            }
            else
                this.setBorderListTable(2);

            //else
            //{
            //    lTable[2].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan4_Click(object sender, EventArgs e)
        {
            if (lTable[3].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[3].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(3);

                }
            }
            else
                 this.setBorderListTable(3);

            //else
            //{
            //    lTable[3].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan5_Click(object sender, EventArgs e)
        {
            if (lTable[4].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[4].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(4);

                }
            }
            else
                this.setBorderListTable(4);

            //else
            //{
            //    lTable[4].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan6_Click(object sender, EventArgs e)
        {
            if (lTable[5].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[5].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(5);

                }
            }
            else
                this.setBorderListTable(5);

            //else
            //{
            //    lTable[5].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan7_Click(object sender, EventArgs e)
        {
            if (lTable[6].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[6].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(6);
                }
            }
            else
                this.setBorderListTable(6);

            //else
            //{
            //    lTable[6].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan8_Click(object sender, EventArgs e)
        {
            if (lTable[7].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[7].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(7);

                }
            }
            else
                this.setBorderListTable(7);

            //else
            //{
            //    lTable[7].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan9_Click(object sender, EventArgs e)
        {
            if (lTable[8].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[8].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(8);

                }
            }
            else
                this.setBorderListTable(8);

            //else
            //{
            //    lTable[8].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void ptbBan10_Click(object sender, EventArgs e)
        {
            if (lTable[9].isUsed == true)
            {
                DialogResult rep;
                rep = MessageBox.Show("Bạn muốn chọn bàn này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    lTable[9].setTableIsUsed(srcImageTableUsed);
                    this.setBorderListTable(9);

                }
            }
            else
                this.setBorderListTable(9);

            //else
            //{
            //    lTable[9].setTableEmpty(srcImageTableEmpty);
            //}
        }

        private void cbBoxLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.reload(cbBoxLoai.SelectedIndex);
        }

        private void cbBoxTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.monDangChon = cbBoxTenMon.SelectedIndex;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBoxTenMon.Text != "")
                {
                    SelectedMenuClass x = new SelectedMenuClass();
                    x.maMon = dtMenu.Rows[monDangChon][0].ToString();
                    x.TenMon = dtMenu.Rows[monDangChon][1].ToString();
                    x.soLuong = Convert.ToInt32(NumberUpDown.Value);
                    x.gia = Convert.ToDouble(dtMenu.Rows[monDangChon][2]);
                    x.thanhTien = x.gia * x.soLuong;
                    lTable[BanDangChon].lSelectedMenu.Add(x);
                    this.RutGonlSelectedMenu(lTable[BanDangChon]);
                    this.test();
                }
                else
                {
                    MessageBox.Show("chua chon mon");
                }
            }
            catch
            {

            }


            //lTable[BanDangChon].lSelectedMenu
        }
        public void RutGonlSelectedMenu(Table TB)
        {
            for(int i = 0; i< TB.lSelectedMenu.Count-1; i++)
            {
                List<int> x = new List<int>();
                for(int j = i+1; j < TB.lSelectedMenu.Count; j++)
                {
                    if(TB.lSelectedMenu[i].maMon == TB.lSelectedMenu[j].maMon)
                    {
                        x.Add(j);
                        TB.lSelectedMenu[i].soLuong += TB.lSelectedMenu[j].soLuong;
                    }
                }
                this.removelSelectedMenu(TB, x);
                TB.lSelectedMenu[i].thanhTien = TB.lSelectedMenu[i].gia * TB.lSelectedMenu[i].soLuong;
            }
        }

        public void removelSelectedMenu(Table tb,List<int> x)
        {

            for(int i = 0; i< x.Count; i++)
            {
                tb.lSelectedMenu.RemoveAt(x[i]);
            }
        }
        public void test()
        {
            dgvMuaHang.Rows.Clear();
            //dgvMuaHang.Rows.Clear();
            for (int i = 0; i < lTable[BanDangChon].lSelectedMenu.Count; i++)
            {
                string[] row1 = new string[] { lTable[BanDangChon].lSelectedMenu[i].TenMon, lTable[BanDangChon].lSelectedMenu[i].soLuong.ToString(), lTable[BanDangChon].lSelectedMenu[i].thanhTien.ToString() };
                dgvMuaHang.Rows.Add(row1);
            }
            //int i = 0;
            this.label20.Text = lTable[BanDangChon].lSelectedMenu.Count.ToString();
            //lTable[BanDangChon].lSelectedMenu.ForEach(rs =>
            //{
            //    dgvMuaHang.Rows[i].Cells[0].Value = rs.TenMon.ToString();
            //    dgvMuaHang.Rows[i].Cells[1].Value = rs.soLuong.ToString();
            //    dgvMuaHang.Rows[i].Cells[2].Value = rs.thanhTien.ToString();
            //    i++;
            //});
        }

        private void BtnXuatHoaDon_Click(object sender, EventArgs e)
        {
            Form a = new FormReport();
            this.Hide();
            a.ShowDialog();
            this.Show();

        }

        private void TìmKiếmThôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new FormSearchBill();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void TheoBộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new FormTKL();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void ToànThểNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new FormLuongToanNV();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void ThốngKêTổngDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new FormTKDoanhThu();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }
    }
}
