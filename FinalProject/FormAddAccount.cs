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
        public FormAddAccount()
        {
            InitializeComponent();
            this.LoadData();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            
        }
        void LoadData()
        {
            this.dgvTaiKhoan.Enabled = true;
            this.dataTable = BLAcc.getStaffDHaveAcc();
            this.dgvTaiKhoan.DataSource = dataTable;
            this.cbBoxSelect.SelectedIndex = 2;
            this.txtUsername.ResetText();
            this.txtUsername.Enabled = false;            
            this.txtPassword.ResetText();
            this.txtPassword.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnHuy.Enabled = false;

                //DgvTaiKhoan_CellClick(null, null);
        }
           
        

        private void FormAddAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTaiKhoan.CurrentCell.RowIndex;
            this.lblID.Text = dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();
            this.txtUsername.Enabled = true;
            this.txtPassword.Enabled = true;

        }

        private void CbBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxSelect != null)
            {
                txtSearchBox.Enabled = true;
            }
            if (cbBoxSelect.Text.CompareTo("Thu Ngân") == 0)
            {
                this.dataTable = this.BLAcc.getStaffDHaveAccByPosition("2");
                this.dgvTaiKhoan.DataSource = dataTable;

            }
            else if (cbBoxSelect.Text.CompareTo("Quản Lí") == 0)
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

        private void CbBoxOptionIDName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxOptionIDName.SelectedIndex != 2)
            {
                txtSearchBox.Enabled = true;
            }
            else
            {
                txtSearchBox.Text = "";
                txtSearchBox.Enabled = false;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBoxSelect.SelectedIndex == 2)
                {
                    if (cbBoxOptionIDName.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccbyID(txtSearchBox.Text);
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else if (cbBoxOptionIDName.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccbyName(txtSearchBox.Text);
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else
                    {
                        this.dataTable = BLAcc.getStaffDHaveAcc();
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                }
                else if (cbBoxSelect.SelectedIndex == 0)
                {
                    if (cbBoxOptionIDName.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByIDAndPosition(txtSearchBox.Text, "1");
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else if (cbBoxOptionIDName.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByNameAndPosition(txtSearchBox.Text, "1");
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
                    if (cbBoxOptionIDName.SelectedIndex == 0)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByIDAndPosition(txtSearchBox.Text, "2");
                        this.dgvTaiKhoan.DataSource = dataTable;
                    }
                    else if (cbBoxOptionIDName.SelectedIndex == 1)
                    {
                        this.dataTable = BLAcc.getStaffDHaveAccByIDAndPosition(txtSearchBox.Text, "2");
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
    }
}
