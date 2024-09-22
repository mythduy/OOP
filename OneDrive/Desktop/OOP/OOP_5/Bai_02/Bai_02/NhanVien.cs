using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_02
{
    internal class NhanVien
    {
        private string hoTen;
        private DateTime ngaySinh;
        private DiaChi diaChi;

        public NhanVien(string hoTen, DateTime ngaySinh, DiaChi diaChi)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        internal DiaChi DiaChi { get => diaChi; set => diaChi = value; }

        public void InThongTin()
        {
            Console.WriteLine($"Ho Ten: {hoTen}, Ngay Sinh: {NgaySinh}, Dia Chi: {diaChi.toString()}");
        }

    }
}
