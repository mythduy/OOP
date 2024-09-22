using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kethua1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soLuongSV;
            Console.WriteLine("Nhap so luong sinh vien: ");
            soLuongSV = int.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[soLuongSV];

            for(int i = 0; i < sv.Length; i++)
            {
                Console.WriteLine($"Sinh vien thu {i+1}");
                sv[i] = new SinhVien();
                sv[i].Nhap();

            
            }
            for(int i = 0;i < sv.Length; i++)
            {
                sv[i].Xuat();
            }
            Console.ReadKey();
        }
    }
}
