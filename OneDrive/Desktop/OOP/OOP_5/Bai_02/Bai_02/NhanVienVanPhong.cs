using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_02
{
    internal class NhanVienVanPhong:NhanVien
    {
        private int soNgayLamViec;
        public int SoNgayLamViec { get => soNgayLamViec; set => soNgayLamViec = value; }

        public NhanVienVanPhong(string hoTen, DateTime ngaySinh, DiaChi diaChi, int soNgayLamViec) : base(hoTen, ngaySinh, diaChi)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.SoNgayLamViec= soNgayLamViec;
        }

        public new void InThongTin()
        {   
            base.InThongTin(); 
            Console.WriteLine($"So Ngay lam viec: {soNgayLamViec}");
        }
        public double TinhLuong()
        {
            return 100 * soNgayLamViec; 
        }
    }
}
