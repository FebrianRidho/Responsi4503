using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4503
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kar1 = new Karyawan("190302123", "Paijo", Int32.Parse("3000000"));
            Karyawan kar2 = new Karyawan("190302124", "Jono", Int32.Parse("2000000"));

            Console.WriteLine("No NIK / Nama \t Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            CetakHasil11(kar1);
            CetakHasil12(kar2);

            Console.WriteLine();

            Console.WriteLine("Asyiiiiik dapat kenaikan gaji 10%!!");

            Console.WriteLine();

            Console.WriteLine("No NIK / Nama \t Gaji Bulanan");
            Console.WriteLine("------------------------------");
            CetakHasil13(kar1);
            CetakHasil14(kar2);

            Console.ReadKey();
        }
        static void CetakHasil11(Karyawan k)
        {
            Console.WriteLine("1. {0} {1}\t{2}", k.NIK, k.Nama, k.GajiBulanan);
        }
        static void CetakHasil12(Karyawan k)
        {
            Console.WriteLine("2. {0} {1}\t{2}", k.NIK, k.Nama, k.GajiBulanan);
        }
        static void CetakHasil13(Karyawan k)
        {
            Console.WriteLine("1. {0} {1}\t{2}", k.NIK, k.Nama, k.GajiBulanan + k.GajiBulanan * 10 / 100);
        }
        static void CetakHasil14(Karyawan k)
        {
            Console.WriteLine("2. {0} {1}\t{2}", k.NIK, k.Nama, k.GajiBulanan + k.GajiBulanan * 10 / 100);
        }

    }
}