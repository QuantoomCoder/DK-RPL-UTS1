using System;

namespace UTSS1
{
    class Cek_kesalahan
    {
        static void Main()
        {   
            // Izzatul Azam X-RPL
            // menggunakan Console.WriteLine untuk menampilkan sehingga input ada di baris bawahnya
            Console.Write("Masukan angka pertama: ");
            //int angka1 tidak menggunakan Convert.ToInt32 atau int.Parse
            int angka1 = Convert.ToInt32(Console.ReadLine());

            // menggunakan Console.WriteLine untuk menampilkan sehingga input ada di baris bawahnya
            Console.Write("Masukan angka kedua: ");
            int angka2 = int.Parse(Console.ReadLine());

            int hasil = angka1 + angka2;
            // tidak menggunakan {0} untuk menampilkan hasil penjumlahan
            Console.WriteLine("Hasil penjumlahan: {0}", hasil);
        }
    }
}