using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4503
{
    public class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, int GajiBulan)
        {
            NIK = nik;
            Nama = nama;
            GajiBulanan = GajiBulan;
            if(GajiBulanan < 0 )
            {
                GajiBulanan = 0;
            }
        }
    }
}
