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
    public partial class FormLuongToanNV : Form
    {
        public FormLuongToanNV()
        {
            InitializeComponent();
        }

        private void FormLuongToanNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TKLToanNV.TKLFull' table. You can move, or remove it, as needed.
            this.TKLFullTableAdapter.Fill(this.TKLToanNV.TKLFull);

            this.reportViewer1.RefreshReport();
        }
    }
}
