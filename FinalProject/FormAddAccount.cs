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
    public partial class FormAddAccount : Form
    {
        BLAccount BLAcc = new BLAccount();
        DataTable dataTable = new DataTable();
        string err;
        public FormAddAccount()
        {
            InitializeComponent();
            //this.LoadData();
        }
        void LoadData()
        {
            this.dataTable = BLAcc.getStaffDHaveAcc();
            this.dgvTaiKhoan.DataSource = dataTable;
            this.cbBoxSelect.SelectedIndex = 2;
            this.cbBoxIDTen.SelectedIndex = 2;
            this.txtUsername.ResetText();
            this.txtUsername.Enabled = false;            
            this.txtPassword.ResetText();
            this.txtPassword.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnLuu.Enabled = false;
            this.cbChucvu.Enabled = false;
            DgvTaiKhoan_CellClick(null, null);
        }
           
        

        private void FormAddAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTaiKhoan.CurrentCell.RowIndex;
            this.lblID.Text = dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();
            this.btnThem.Enabled = true;
            int index = cbChucvu.FindString(this.dgvTaiKhoan.Rows[r].Cells[5].Value.ToString());
            cbChucvu.SelectedIndex = index;

        }

        private void CbBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBoxSelect!=null)
            {
                txtsearch.Enabled = true;
            }
            if(cbBoxSelect.SelectedIndex==1)
            {
                this.dataTable = this.BLAcc.getStaffDHaveAccByPosition("2");
                this.dgvTaiKhoan.DataSource = dataTable;
            }
            else if(cbBoxSelect.SelectedIndex==0)
            {
                this.dataTable = this.BLAcc.getStaffDHaveAccByPosition("1");
                this.dgvTaiKhoan.DataSource = dataTable;
            }
            else
            {
                this.dataTable = this.BLAcc.getStaffDHaveAcc();
                this.dgvTaiKhoan.DataSource = dataTable;
            }
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBoxSelect.SelectedIndex == 2)
                {
                    if (cbBoxIDTen.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccbyID(txtsearch.Text);
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else if(cbBoxIDTen.SelectedIndex==1)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccbyName(txtsearch.Text);
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getStaffDHaveAcc();
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                }
                else if(cbBoxSelect.SelectedIndex==0)
                {
                    if(cbBoxIDTen.SelectedIndex==0)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByIDAndPosition(txtsearch.Text, "1");
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else if (cbBoxIDTen.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByNameAndPosition(txtsearch.Text, "1");
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByPosition("1");
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                }
                else if (cbBoxSelect.SelectedIndex == 1)
                {
                    if (cbBoxIDTen.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByIDAndPosition(txtsearch.Text, "2");
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else if (cbBoxSelect.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByNameAndPosition(txtsearch.Text, "2");
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByPosition("2");
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                }
            }
            catch
            {

            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            this.txtPassword.Enabled = true;
            this.txtUsername.Enabled = true;
            this.btnHuy.Enabled = true;
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text!="" && txtPassword.Text!="")
            {
                btnLuu.Enabled = true;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnLuu.Enabled = true;
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                BLAccount blacc = new BLAccount();
                blacc.CreateAcc(this.txtUsername.Text, this.txtPassword.Text, Convert.ToString(cbChucvu.SelectedIndex + 1), this.lblID.Text, err);
                LoadData();
                this.dgvTaiKhoan.Enabled = true;
                MessageBox.Show("Đã thêm xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
