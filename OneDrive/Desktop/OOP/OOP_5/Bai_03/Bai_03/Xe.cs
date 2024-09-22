using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03
{
    internal class Xe
    {
        private string nhanHieu;
        private double giaTien;
        private int namSanXuat;

        public string NhanHieu { get => nhanHieu; set => nhanHieu = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public int NamSanXuat { get => namSanXuat; set => namSanXuat = value; }

        public Xe(string nhanHieu, double giaTien, int namSanXuat)
        {
            this.NhanHieu = nhanHieu;
            this.GiaTien = giaTien;
            this.NamSanXuat = namSanXuat;
        }
        
        public Xe()
        {
            nhanHieu = "";
            giaTien = 0;
            namSanXuat = 0;
        }
        
        ~Xe() { } // phuong thuc huy giai phong vung nho

        public void Input()
        {
            Console.WriteLine("Nhap Ten Nhan Xe: ");
            nhanHieu = Console.ReadLine();
            Console.WriteLine("Nhap Gia Tien: ");
            giaTien = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Nam San Xuat: ");
            namSanXuat = int.Parse(Console.ReadLine());
        }

        public string Output()
        {
            return $"Nhan Xe: {nhanHieu}, Gia Tien: {giaTien}, Nam San Xuat: {namSanXuat}";
        }
    }
}
