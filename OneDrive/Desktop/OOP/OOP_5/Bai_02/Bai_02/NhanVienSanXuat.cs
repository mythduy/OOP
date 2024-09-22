using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_02
{
    internal class NhanVienSanXuat:NhanVien
    {
        private double luongCB;
        private int soSP;

        public double LuongCB { get => luongCB; set => luongCB = value; }
        public int SoSP { get => soSP; set => soSP = value; }

        public NhanVienSanXuat(string hoTen, DateTime ngaySinh, DiaChi diaChi, double luongCB, int soSP):base(hoTen,ngaySinh,diaChi)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.luongCB = luongCB;
            this.SoSP = soSP;
        }

        public new void  InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Luong Co Ban: {luongCB}, So San Pham: {soSP}");
        }
        
        public double TinhLuong()
        {
            return luongCB * soSP;
        }

    }
}
