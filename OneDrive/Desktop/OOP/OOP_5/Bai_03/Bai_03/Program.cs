/*
 * Name:Duong Khanh Duy
 * Date:21/9/2005
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Vao So Luong Oto: ");
            int n = int.Parse(Console.ReadLine());

            Oto[] Otos = new Oto[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap Thong Tin Xe Thu"+(i+1).ToString());
                Otos[i] = new Oto();
                Otos[i].Nhap();
                
            }
            for(int i = 0;i < n; i++)
            {   
                Otos[i].Xuat();
            }
            Console.ReadKey();
        }
    }
}
