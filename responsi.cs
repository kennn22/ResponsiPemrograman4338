using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Karyawan
    {
        // constructor default
        public Karyawan()
        {

        }
        // overload constructor 
        public Karyawan(string nama, string nik, int gajibulanan)
        {
            Nama = nama;
            Nik = nik;
            GajiBulanan = gajibulanan < 0 ? 0 : gajibulanan;
        }
        // properties
        public string Nama      { get; set; }
        public string Nik      { get; set; }
        public int GajiBulanan  { get; set; }
               
             
    }
}