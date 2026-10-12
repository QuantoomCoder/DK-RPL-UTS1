using System;

namespace UTSS1
{
    class HitungLuas
    {
        static void Main()
        {   
            // Izzatul Azam X-RPL
            Console.WriteLine("================================");
            Console.WriteLine("      Program Perhitungan");
            Console.WriteLine("     Luas Persegi Panjang");
            Console.WriteLine("================================");

            Console.Write("Masukkan panjang persegi (cm): ");
            int panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan lebar persegi (cm): ");
            int lebar = Convert.ToInt32(Console.ReadLine());
            int luas = panjang * lebar;
            Console.WriteLine("Luas persegi panjang adalah: {0}", luas + " cm^2");
            Console.WriteLine("================================");
        }
    }
}