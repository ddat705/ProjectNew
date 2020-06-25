using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.ModelClass
{
    public class SelectedMenuClass : IDisposable
    {
        public string maMon;
        public string TenMon;
        public int soLuong;
        public double gia;
        public double thanhTien;

        public SelectedMenuClass()
        {

        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
