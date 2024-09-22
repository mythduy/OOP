using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_02
{
    internal class DiaChi
    {
        private string soNha;
        private string tenDuong;
        private string tenQuan;
        private string thanhPho;

        public DiaChi(string soNha, string tenDuong, string tenQuan, string thanhPho)
        {
            this.soNha = soNha;
            this.tenDuong = tenDuong;
            this.tenQuan = tenQuan;
            this.thanhPho = thanhPho;
        }

        public string SoNha { get => soNha; set => soNha = value; }
        public string TenDuong { get => tenDuong; set => tenDuong = value; }
        public string TenQuan { get => tenQuan; set => tenQuan = value; }
        public string ThanhPho { get => thanhPho; set => thanhPho = value; }

        public void Input()
        {
            Console.WriteLine("Nhap so nha: ");
            soNha =Console.ReadLine();
            Console.WriteLine("Nhap so duong: ");
            tenDuong =Console.ReadLine();
            Console.WriteLine("Nhap ten quan: ");
            tenQuan =Console.ReadLine();
            Console.WriteLine("Nhap thanh pho: ");
            thanhPho =Console.ReadLine();
        }
        public string toString()
        {
            return $"So Nha:{soNha}, Ten Duong: {tenDuong}, Ten Quan: {tenQuan}, Thanh Pho: {ThanhPho}";
        }

    }
}
