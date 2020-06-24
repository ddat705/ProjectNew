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
    public partial class FormAddAccount : Form
    {
        //BLAccount BLAcc = new BLAccount();
        //DataTable dataTable = new DataTable();
        public FormAddAccount()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
           // this.dataTable = BLAcc.();
           // this.dgvTaiKhoan.DataSource = dataTable;
        }
    }
}
