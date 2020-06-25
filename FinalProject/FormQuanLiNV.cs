using FinalProject.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormQuanLiNV : Form
    {
        BLAccount BLAcc = new BLAccount();
        DataTable dataTable = new DataTable();
        bool Them;
        string err;
        public FormQuanLiNV()
        {
            InitializeComponent();

        }
        void LoadData()
        {
            this.dataTable = BLAcc.getStaffAll();
            this.dgvThongTinNV.DataSource = dataTable;
            txtSearchBox.ResetText();
            this.cbBoxOptionSearch.SelectedIndex=4;
            this.cbBoxOptionIDName.SelectedIndex = 2;
            this.btnHuy.Enabled = false;
            this.btnLuu.Enabled = false;
            this.cbBoxChucVu.Enabled = false;
            this.txtBoxHoTen.Enabled = false;
            this.txtBoxLuong.Enabled = false;
            this.txtID.Enabled = false;
            this.dtpNamsinh.Enabled = false;
            this.txtBoxCMND.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnReload.Enabled = true;
            DgvThongTinNV_CellClick(null, null);

        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            dgvThongTinNV.Enabled = false;
            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            this.cbBoxChucVu.Enabled = true;
            this.txtBoxHoTen.Enabled = true;
            this.txtBoxLuong.Enabled = true;
            this.txtID.Enabled = false;
            this.dtpNamsinh.Enabled = true;
            this.txtBoxCMND.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.cbBoxChucVu.SelectedIndex=-1;
            this.txtBoxHoTen.ResetText();
            this.txtBoxLuong.ResetText();
            this.txtID.ResetText();
            this.dtpNamsinh.Text = DateTime.Now.ToString();
            this.txtBoxCMND.ResetText();
            this.txtID.Focus();
        }



        private void CbBoxOptionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxOptionSearch != null)
            {
                txtSearchBox.Enabled = true;
            }
            if (cbBoxOptionSearch.Text.CompareTo("Thu Ngân") == 0)
            {
                this.dataTable = this.BLAcc.getChucVu("2");
                this.dgvThongTinNV.DataSource = dataTable;

            }
            else if (cbBoxOptionSearch.Text.CompareTo("Quản Lí") == 0)
            {
                this.dataTable = this.BLAcc.getChucVu("1");
                this.dgvThongTinNV.DataSource = dataTable;
            }
            else if (cbBoxOptionSearch.Text.CompareTo("Phục Vụ") == 0)
            {
                this.dataTable = this.BLAcc.getChucVu("3");
                this.dgvThongTinNV.DataSource = dataTable;
            }
            else if (cbBoxOptionSearch.Text.CompareTo("Bảo Vệ") == 0)
            {
                this.dataTable = this.BLAcc.getChucVu("4");
                this.dgvThongTinNV.DataSource = dataTable;
            }
            else
            {
                this.dataTable = this.BLAcc.getStaffAll();
                this.dgvThongTinNV.DataSource = dataTable;
            }

        }

        private void FormQuanLiNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvThongTinNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvThongTinNV.CurrentCell.RowIndex;
            this.txtID.Text = dgvThongTinNV.Rows[r].Cells[0].Value.ToString();
            this.txtBoxHoTen.Text = dgvThongTinNV.Rows[r].Cells[1].Value.ToString();
            this.txtBoxCMND.Text = dgvThongTinNV.Rows[r].Cells[2].Value.ToString();
            this.dtpNamsinh.Value = Convert.ToDateTime(dgvThongTinNV.Rows[r].Cells[3].Value.ToString());
            this.txtBoxLuong.Text = dgvThongTinNV.Rows[r].Cells[4].Value.ToString();
            int index = cbBoxChucVu.FindString(this.dgvThongTinNV.Rows[r].Cells[5].Value.ToString());
            cbBoxChucVu.SelectedIndex = index;

        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.dgvThongTinNV.Enabled = true;
            this.cbBoxChucVu.ResetText();
            this.txtBoxHoTen.ResetText();
            this.txtBoxLuong.ResetText();
            this.txtID.ResetText();
            this.dtpNamsinh.ResetText();
            this.txtBoxCMND.ResetText();
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnHuy.Enabled = false;
            this.btnLuu.Enabled = false;
            this.cbBoxChucVu.Enabled = false;
            this.txtBoxHoTen.Enabled = false;
            this.txtBoxLuong.Enabled = false;
            this.txtID.Enabled = false;
            this.dtpNamsinh.Enabled = false;
            this.txtBoxCMND.Enabled = false;
            DgvThongTinNV_CellClick(null, null);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {

                    BLAccount blacc = new BLAccount();
                    blacc.AddNV(this.txtBoxHoTen.Text, this.txtBoxCMND.Text, this.dtpNamsinh.Text, this.txtBoxLuong.Text, Convert.ToString(cbBoxChucVu.SelectedIndex+1), err);
                    LoadData();
                    this.dgvThongTinNV.Enabled = true;
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {

                BLAccount blacc = new BLAccount();
                blacc.UpdateNV(this.txtID.Text, this.txtBoxHoTen.Text, this.txtBoxCMND.Text, this.dtpNamsinh.Text, this.txtBoxLuong.Text, Convert.ToString(cbBoxChucVu.SelectedIndex + 1), err);
                LoadData();
                this.dgvThongTinNV.Enabled = true;
                MessageBox.Show("Đã sửa xong!");
            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            DgvThongTinNV_CellClick(null, null);
            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            this.cbBoxChucVu.Enabled = true;
            this.txtBoxHoTen.Enabled = true;
            this.txtBoxLuong.Enabled = true;
            this.txtID.Enabled = true;
            this.dtpNamsinh.Enabled = true;
            this.txtBoxCMND.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtID.Enabled = false;
            this.txtBoxHoTen.Focus();

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                DialogResult a = MessageBox.Show("Bạn chắc chắn xoá", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (a == DialogResult.OK)
                {
                    this.BLAcc.DeleteStaff(txtID.Text);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.LoadData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBoxOptionSearch.SelectedIndex == 4)
                {
                    if (cbBoxOptionIDName.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getNVbyID(txtSearchBox.Text);
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else if (cbBoxOptionIDName.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getNVbyName(txtSearchBox.Text);
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getStaffAll();
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                }
                else if (cbBoxOptionSearch.SelectedIndex == 0)
                {
                    if (cbBoxOptionIDName.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getStaffByIDAndPosition(txtSearchBox.Text, "2");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else if (cbBoxOptionIDName.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getStaffByNameAndPosition(txtSearchBox.Text, "2");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getChucVu("2");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                }
                else if (cbBoxOptionSearch.SelectedIndex == 1)
                {
                    if (cbBoxOptionIDName.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getStaffByIDAndPosition(txtSearchBox.Text, "1");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else if (cbBoxOptionIDName.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getStaffByNameAndPosition(txtSearchBox.Text, "1");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getChucVu("1");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                }
                else if (cbBoxOptionSearch.SelectedIndex == 2)
                {
                    if (cbBoxOptionIDName.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getStaffByIDAndPosition(txtSearchBox.Text, "3");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else if (cbBoxOptionIDName.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getStaffByNameAndPosition(txtSearchBox.Text, "3");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getChucVu("3");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                }
                else if (cbBoxOptionSearch.SelectedIndex == 3)
                {
                    if (cbBoxOptionIDName.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getStaffByIDAndPosition(txtSearchBox.Text, "4");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else if (cbBoxOptionIDName.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getStaffByNameAndPosition(txtSearchBox.Text, "4");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getChucVu("4");
                        this.dgvThongTinNV.DataSource = dataTable;
                    }
                }
            }
            catch
            {

            }

        }


    }
}
