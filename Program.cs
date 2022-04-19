using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Karyawan 1
            Karyawan karyawan1 = new Karyawan();

            // properties
            karyawan1.Nik = "1910302123";
            karyawan1.Nama = "PAIJO";
            karyawan1.GajiBulanan = 3000000;

            // membuat objek Karyawan 2
            Karyawan  karyawan2 = new Karyawan();

            // properties
            karyawan2.Nik = "1910302124";
            karyawan2.Nama = "JONO";
            karyawan2.GajiBulanan = 2000000;

            //pemanggilan method
            Console.WriteLine("No. \tNik\t\tNama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("1. \t{0}\t{1}\t\t{2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. \t{0}\t{1}\t\t{2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine("\n");
            Console.WriteLine("Asyiiiiik Kenaikan Gaji 10% !! ");
            Console.WriteLine("\n");

            Console.WriteLine("No. \tNik\t\tNama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("1. \t{0}\t{1}\t\t{2}",karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10) );
            Console.WriteLine("2. \t{0}\t{1}\t\t{2}",karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10) );

            Console.ReadKey();
        }
    }
}