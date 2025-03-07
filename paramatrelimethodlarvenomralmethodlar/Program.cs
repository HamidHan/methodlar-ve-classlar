using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace paramatrelimethodlarvenomralmethodlar
{
    internal class Program
    {
        class matematik
        {
            public void yaz()
            {
                Console.WriteLine("işlem");
            }

            public void yaz2(string yazi)
            {
                Console.WriteLine(yazi);
            }

            public void yaz3(string metin, int sayi)
            {
                for (int i = 0; i < sayi; i++)
                {
                    Console.WriteLine(metin);

                }
            }
            static void Main(string[] args)
            {
                matematik mt = new matematik();
                // bir sınıfı eklediğimizde .net framework içerisindeki tüm sınıfları kullanabiliriz.
                string a = "Hello";
                int tekrar=Convert.ToInt32(Console.ReadLine());
                mt.yaz2(a);
                mt.yaz3(a, tekrar);
                Console.ReadLine();


            }
        }
    }
}
