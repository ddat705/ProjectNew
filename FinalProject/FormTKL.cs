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
    public partial class FormTKL : Form
    {
        public FormTKL()
        {
            InitializeComponent();
        }

        private void FormTKL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongKeLuong.ThongKeLuongBoPhan' table. You can move, or remove it, as needed.
            //this.ThongKeLuongBoPhanTableAdapter.Fill(this.ThongKeLuong.ThongKeLuongBoPhan);

            //this.reportViewer1.RefreshReport();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                this.ThongKeLuongBoPhanTableAdapter.Fill(this.ThongKeLuong.ThongKeLuongBoPhan,"Quản Lí");        
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.ThongKeLuongBoPhanTableAdapter.Fill(this.ThongKeLuong.ThongKeLuongBoPhan, "Thu Ngân");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                this.ThongKeLuongBoPhanTableAdapter.Fill(this.ThongKeLuong.ThongKeLuongBoPhan, "Phục Vụ");
            }
            else 
            {
                this.ThongKeLuongBoPhanTableAdapter.Fill(this.ThongKeLuong.ThongKeLuongBoPhan, "Bảo Vệ");
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
