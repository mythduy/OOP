using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03
{
    internal class Oto:Xe
    {
        private int soChoNgoi;
        private int trongTai;

        public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }
        public int TrongTai { get => trongTai; set => trongTai = value; }

        public Oto(string nhanHieu, double giaTien, int namSanXuat, int soChoNgoi, int trongTai):base(nhanHieu,giaTien,namSanXuat)
        {
            this.NhanHieu = nhanHieu;
            this.GiaTien = giaTien;
            this.NamSanXuat = namSanXuat;
            this.SoChoNgoi=soChoNgoi;
            this.TrongTai=trongTai;

        }
        
        public Oto():base()
        {
            soChoNgoi = 0;
            trongTai = 0;
        }
        public new void Nhap()
        {
            base.Input();
            Console.WriteLine("Nhap Vao So Cho Ngoi: ");
            soChoNgoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Vao So Trong Tai: ");
            trongTai = int.Parse(Console.ReadLine());
        }

        public new void Xuat()
        {
            
            Console.WriteLine($"{base.Output()},So Cho Ngoi: {soChoNgoi}, Trong Tai Cua Xe La: {trongTai}");
        }


    }
}
