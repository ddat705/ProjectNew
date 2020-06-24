using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.ModelClass
{
    public class Table
    {
        public PictureBox ptb = new PictureBox();
        public bool isUsed = true;

        public Table() 
        {
        }

        public void setTableEmpty(string src)
        {
            this.ptb.Image = Image.FromFile(@"" + src);
            this.isUsed = true;
        }
        public void setTableIsUsed(string src)
        {
            this.ptb.Image = Image.FromFile(@"" + src);
            this.isUsed = false;
        }

        public void setBorderStyleNull()
        {
            this.ptb.BorderStyle = BorderStyle.None;
        }
        public void setBorderStyle()
        {
            this.ptb.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
