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



            public void topla(int a, int b)
            {
                
                Console.WriteLine(a+b);
            }

            public void ustal(int a, int b)
            {

                for(int i = 1; i < b; i++)
                {
                    a *= a; 
                }
               Console.WriteLine(a);
            }
            static void Main(string[] args)
            {
                matematik mt = new matematik();
                // bir sınıfı eklediğimizde .net framework içerisindeki tüm sınıfları kullanabiliriz.
                string a = "Hello";
                //mt.yaz2(a);
                //mt.yaz3(a, tekrar);
                mt.ustal(5, 2);
                Console.ReadLine();


            }
        }
    }
}
