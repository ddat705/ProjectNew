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
    public partial class FormTKDoanhThu : Form
    {
        public FormTKDoanhThu()
        {
            InitializeComponent();
        }

        private void FormTKDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongKeDoanhThu.TKDT' table. You can move, or remove it, as needed.
            //this.TKDTTableAdapter.Fill(this.ThongKeDoanhThu.TKDT);

            //this.reportViewer1.RefreshReport();
        }

        private void BtnTK_Click(object sender, EventArgs e)
        {
            this.TKDTTableAdapter.Fill(this.ThongKeDoanhThu.TKDT,dtpFrom.Text,dtpTo.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
