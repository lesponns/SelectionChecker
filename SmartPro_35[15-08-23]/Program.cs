using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_35_15_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesaplama = new Hesaplama();

            Console.WriteLine("Sayıları giriniz.");
            Console.Write("1. Sayı: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayı: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("\nYapmak istediğiniz işlemi seçiniz.\n");
            Console.Write("\nToplama +\nÇıkarma -\nÇarpma *\nBölme /\n");
            string secim = Console.ReadLine();

            hesaplama.Hesapla(n1, n2,secim);
            if (string.IsNullOrEmpty(secim))
            {
                hesaplama.Hesapla(n1, n2);
            }

            Console.ReadKey();
        }
    }
}
