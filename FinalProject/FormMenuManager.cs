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
    public partial class FormMenuManager : Form
    {
        BLAccount BLAcc = new BLAccount();
        DataTable dataTable = new DataTable();
        string err;
        public FormMenuManager()
        {
            InitializeComponent();
            this.cbBoxOptionSearch.SelectedIndex = 2;
            this.CbBoxSelectLoai.SelectedIndex = 2;
            this.reload();
            this.SetValueToTextBox(0);
            this.disableTextBoxSelected();

        }

        public void reload()
        {
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.disableTextBoxSelected();
            this.dgvThongtin.ClearSelection();
            this.dataTable = BLAcc.getMenuAll();
            this.dgvThongtin.DataSource = dataTable;
            this.SetValueToTextBox(0);

        }

        private void FormMenuManager_Load(object sender, EventArgs e)
        {

        }

        private void cbBoxOptionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBoxOptionSearch.SelectedIndex != 2)
            {
                txtSearchBox.Enabled = true;
            }
            else
            {
                txtSearchBox.Text = "";
                txtSearchBox.Enabled = false;
            }
        }

        public void SetValueToTextBox(int x)
        {
            if(this.dgvThongtin.Rows[x].Cells[0].Value != null)
            {
                this.txtBoxMaMonAn.Text = this.dgvThongtin.Rows[x].Cells[0].Value.ToString();
                this.txtBoxTenMonAn.Text = this.dgvThongtin.Rows[x].Cells[1].Value.ToString();
                this.txtBoxGia.Text = this.dgvThongtin.Rows[x].Cells[2].Value.ToString();
                int index = cbBoxLoai.FindString(this.dgvThongtin.Rows[x].Cells[3].Value.ToString());
                cbBoxLoai.SelectedIndex = index;
            }
            else
            {
                this.txtBoxMaMonAn.Text = "";
                this.txtBoxTenMonAn.Text = this.txtBoxMaMonAn.Text = "";              
                this.txtBoxGia.Text = this.txtBoxMaMonAn.Text = "";           
                cbBoxLoai.SelectedIndex = -1;
            }

        }

        public void SetValueToTextBoxAllNull()
        {
            this.txtBoxMaMonAn.Text = "";
            this.txtBoxTenMonAn.Text = "";
            this.txtBoxGia.Text = "";
            cbBoxLoai.SelectedIndex = 0;
        }

        private void dgvThongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.SetValueToTextBox(e.RowIndex);

            }
            catch { }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if(CbBoxSelectLoai.SelectedIndex == 2)
                {
                    if(cbBoxOptionSearch.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getMenuByID(txtSearchBox.Text);
                        this.dgvThongtin.DataSource = dataTable;
                    }
                    else if(cbBoxOptionSearch.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getMenuByName(txtSearchBox.Text);
                        this.dgvThongtin.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getMenuAll();
                        this.dgvThongtin.DataSource = dataTable;
                    }
                }
                else if(CbBoxSelectLoai.SelectedIndex == 0)
                {
                    if (cbBoxOptionSearch.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getMenuByIDAndLoai(txtSearchBox.Text,"1");
                        this.dgvThongtin.DataSource = dataTable;
                    }
                    else if (cbBoxOptionSearch.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getMenuByNameAndLoai(txtSearchBox.Text,"1");
                        this.dgvThongtin.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getMenuByLoai("1");
                        this.dgvThongtin.DataSource = dataTable;
                    }
                }
                else if (CbBoxSelectLoai.SelectedIndex == 1)
                {
                    if (cbBoxOptionSearch.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getMenuByIDAndLoai(txtSearchBox.Text, "2");
                        this.dgvThongtin.DataSource = dataTable;
                    }
                    else if (cbBoxOptionSearch.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getMenuByNameAndLoai(txtSearchBox.Text, "2");
                        this.dgvThongtin.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getMenuByLoai("2");
                        this.dgvThongtin.DataSource = dataTable;
                    }
                }
            }
            catch
            {

            }

        }

        public void disableTextBoxSelected()
        {
            this.txtBoxMaMonAn.Enabled = false;
            this.txtBoxTenMonAn.Enabled = false;
            this.txtBoxGia.Enabled = false;
            this.cbBoxLoai.Enabled = false;
        }
        public void enableTextBoxSelected()
        {
            this.txtBoxTenMonAn.Enabled = true;
            this.txtBoxGia.Enabled = true;
            this.cbBoxLoai.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtBoxMaMonAn.Text != "")
            {
                this.btnLuu.Enabled = true;
                this.btnHuy.Enabled = true;
                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.enableTextBoxSelected();
            }
            else
            {
                MessageBox.Show("Chưa chọn món để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.disableTextBoxSelected();
            this.reload();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn lưu lại!!", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (a == DialogResult.OK)
            {
                if(txtBoxMaMonAn.Text == "")
                {
                    if(this.BLAcc.addMenu(txtBoxTenMonAn.Text, txtBoxGia.Text, Convert.ToString(cbBoxLoai.SelectedIndex+1),err))
                    {
                        MessageBox.Show("Lưu thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    this.reload();
                }
              
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.reload();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.SetValueToTextBoxAllNull();
            this.enableTextBoxSelected();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtBoxMaMonAn.Text != "")
            {
                DialogResult a = MessageBox.Show("Bạn chắc chắn xoá", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (a == DialogResult.OK)
                {
                    this.BLAcc.deleteMenuByID(txtBoxMaMonAn.Text);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn món để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
