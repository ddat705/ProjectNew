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
    public partial class FormPermissionAdmin : Form
    {
        public FormPermissionAdmin()
        {
            InitializeComponent();
        }

        public FormPermissionAdmin(DataTable root)
        {
            InitializeComponent();
            lbTextUsername.Text = root.Rows[0][0].ToString();
            lbTextChucVu.Text = root.Rows[0][5].ToString();
            lbTextID.Text = root.Rows[0][2].ToString();
            lbTextName.Text = root.Rows[0][3].ToString();
            lbTextCMND.Text = root.Rows[0][4].ToString();
            lbTextRoleAcc.Text = root.Rows[0][1].ToString();
            if(root.Rows[0][6].ToString() != "null")
                ptbPictureUser.Image = Image.FromFile(root.Rows[0][6].ToString());
        }

        private void FormPermissionAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
