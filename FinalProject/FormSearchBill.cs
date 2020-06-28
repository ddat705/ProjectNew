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
    public partial class FormSearchBill : Form
    {
        public FormSearchBill()
        {
            InitializeComponent();
        }

        private void FormSearchBill_Load(object sender, EventArgs e)
        {
            
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SearchBill.TimkiemHD' table. You can move, or remove it, as needed.
            this.TimkiemHDTableAdapter.Fill(this.SearchBill.TimkiemHD, Convert.ToInt32(txtSearch.Text));

            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
        }
    }
}
