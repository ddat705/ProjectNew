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

        public FormMenuManager()
        {
            InitializeComponent();
            this.dataTable = BLAcc.getMenuAll();
            this.dgvThongtin.DataSource = dataTable;
        }

        private void FormMenuManager_Load(object sender, EventArgs e)
        {

        }

        private void cbBoxOptionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBoxOptionSearch != null)
            {
                txtSearchBox.Enabled = true;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
