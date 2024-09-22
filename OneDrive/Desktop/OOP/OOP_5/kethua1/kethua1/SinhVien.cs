using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kethua1
{
    internal class SinhVien: Nguoi
    {
        private int maSo;

        public SinhVien(int maSo, string hoTen, int namSinh):base(hoTen, namSinh)
        {
            this.maSo = maSo;
        }
        public SinhVien():base()
        {
            maSo = 0;
        }
        public int MaSo { get => maSo; set => maSo = value; }
        
        public void Nhap()
        {
            Console.WriteLine("Nhap mssv: ");
            maSo = int.Parse(Console.ReadLine());
            base.Nhap();
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma so:{maSo} ");
            base.Xuat();
        }
        

    }
}
