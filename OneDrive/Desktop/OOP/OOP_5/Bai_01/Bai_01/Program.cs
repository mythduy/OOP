/*Cylinder.cs
 * Nam: Duong Khanh Duy
 * Date: 21/9/2024
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cycl = new Cylinder(1,2,"white");
            Console.WriteLine($"Object "+ cycl.toString());
            Console.WriteLine("Volume's object: ");
            Console.WriteLine(cycl.getVolume());
            Console.ReadKey();
        }
    }
}
