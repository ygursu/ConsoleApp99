using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedengirilenikisayinincarpimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, carpim;

            Console.WriteLine("Lütfen Birinci sayıyı giriniz");
            sayi1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci sayıyı giriniz");
            sayi2 = Int32.Parse(Console.ReadLine());

            carpim = sayi1 * sayi2;

            Console.WriteLine("Sayıların çarpımı =" + carpim);
            Console.ReadLine();



        }
    }
}