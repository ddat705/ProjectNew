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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportXuatHD.BILL' table. You can move, or remove it, as needed.
            //this.BILLTableAdapter.Fill(this.ReportXuatHD.BILL);

            this.reportViewer1.RefreshReport();
        }
    }
}
