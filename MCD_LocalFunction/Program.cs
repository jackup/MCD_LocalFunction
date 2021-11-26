using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFunctionKullanimi(12, 22);
        }

        static void LocalFunctionKullanimi(int sayi1, int sayi2)
        {
            int Topla(int gSayi1, int gSayi2)
            {
                return gSayi1 + gSayi2;
            }
            int toplamDeger = Topla(sayi1, sayi2);
            Console.WriteLine(toplamDeger);
        }
    }
}
