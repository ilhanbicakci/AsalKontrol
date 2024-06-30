using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen bir sayı giriniz: ");

            int sayi = Convert.ToInt32(Console.ReadLine());
            bool asal_misin = true;

            if (sayi >= 2)
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asal_misin = false;
                    }
                }
            }
            else
            {
                asal_misin = false;
            }

            if (asal_misin)
            {
                Console.WriteLine($"{sayi} asaldır.");
            }
            else
            {
                Console.WriteLine($"{sayi} asal değildir.");
            }

        }
    }
}
