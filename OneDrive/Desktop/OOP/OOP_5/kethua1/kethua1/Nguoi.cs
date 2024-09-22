using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kethua1
{
    internal class Nguoi
    {
        private string hoTen;
        private int namSinh;

        public Nguoi(string hoTen, int namSinh)
        {
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
        }
        public Nguoi()
        {
            hoTen = "";
            namSinh = 0;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        public void Nhap()
        {
            Console.WriteLine("Ho Ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nam Sinh: ");
            namSinh = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"Ho va Ten: {hoTen} Nam Sinh: {namSinh}");
        }
    }
}
