/*
 * Name: Duong Khanh Duy
 * Date:21/9/2024
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yeu cau nguoi dung chon loai danh sach 
            Console.WriteLine("Nguoi dung muon nhap danh sach gi ?");
            Console.WriteLine("Nhan 1 nhap danh sach nhan vien san xuat");
            Console.WriteLine("Nhan 2 nhap danh sach nhan vien van phong");

            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Nhap Vao So Luong Nhan Vien San Xuat: ");

                int n = int.Parse(Console.ReadLine());
                NhanVienSanXuat[] nvsx = new NhanVienSanXuat[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap Thong tin nhan vien thu " + (i + 1).ToString());
                    Console.WriteLine("Nhap Vao Ho Va Ten: ");

                    string hoTen = Console.ReadLine();

                    Console.WriteLine("Nhap vao ngay sinh: ");
                    Console.WriteLine("Nhap ngay: ");

                    int ngay = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nhap thang: ");

                    int thang = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nhap nam: ");

                    int nam = int.Parse(Console.ReadLine())
                        ;
                    DateTime ngaySinh = new DateTime(nam, thang, ngay);

                    Console.WriteLine("Nhap vao Dia chi: ");

                    DiaChi diaChi = new DiaChi("", "", "", "");
                    diaChi.Input();

                    Console.WriteLine("Nhap vao Luong Co Ban: ");

                    double luongCB = double.Parse(Console.ReadLine());

                    Console.WriteLine("Nhap vao so san pham: ");

                    int soSP = int.Parse(Console.ReadLine());
                    nvsx[i] = new NhanVienSanXuat(hoTen, ngaySinh, diaChi, luongCB, soSP);

                }
                //In danh sach vua nhap
                for (int i = 0; i < nvsx.Length; i++)
                {
                    nvsx[i].InThongTin();
                    double luong = nvsx[i].TinhLuong();
                    Console.WriteLine($"Luong: {luong} VND");
                }
            }
            else
            {
                Console.WriteLine("Nhap vao so luong nhan vien van phong: ");
                int m = int.Parse(Console.ReadLine());

                NhanVienVanPhong[] nvvp = new NhanVienVanPhong[m];

                for (int i = 0; i < m; i++)
                {
                    Console.WriteLine("Nhap Thong tin nhan vien thu " + (i + 1).ToString());
                    Console.WriteLine("Nhap Vao Ho Va Ten: ");

                    string hoTen = Console.ReadLine();

                    Console.WriteLine("Nhap vao ngay sinh: ");
                    Console.WriteLine("Nhap ngay: ");

                    int ngay = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nhap thang: ");

                    int thang = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nhap nam: ");

                    int nam = int.Parse(Console.ReadLine());

                    DateTime ngaySinh = new DateTime(nam, thang, ngay);

                    Console.WriteLine("Nhap vao Dia chi: ");
                    DiaChi diaChi = new DiaChi("", "", "", "");
                    diaChi.Input();

                    Console.WriteLine("So ngay lam viec: ");

                    int soNgayLamViec = int.Parse(Console.ReadLine());

                    nvvp[i] = new NhanVienVanPhong(hoTen, ngaySinh, diaChi, soNgayLamViec);

                }
                // In danh sach vua nhap
                for (int i = 0;i < m; i++)
                {
                    nvvp[i].InThongTin();
                    double luong = nvvp[i].TinhLuong();
                    Console.WriteLine($"Luong: {luong} VND");
                }
            }
            Console.ReadKey();
        }
    }
}
