using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_35_15_08_23_
{
    internal class Hesaplama
    {
        public void Hesapla(int n1,int n2,string IslemTuru)
        {
            
            int sonuc = 0;
            string format = "{0} {1} {2} = {3}";
            
            switch (IslemTuru) 
            {
                case "+":
                    sonuc = n1 + n2;
                    break;
                case "-":
                    sonuc = n1 - n2;
                    break;
                case "*":
                    sonuc = n1 * n2;
                    break;
                case "/":
                    sonuc = n1 / n2;
                    break;
            }
            Console.Write(format,n1,n2,sonuc);
        }
        public void Hesapla(int n1,int n2)
        {
            int last = n1 + n2;
            Console.Write("İşlem seçmediğiniz için Toplanacak;\nToplama: {0} + {1} = {2}", n1, n2, last);
        }
    }
}
