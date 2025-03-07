using System;
using System.Runtime.InteropServices;

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

                Console.WriteLine(a + b);
            }

            public void ustal(int a, int b)
            {

                for (int i = 1; i < b; i++)
                {
                    a *= a;
                }
                Console.WriteLine(a);
            }

            public void yazDizi(int[] dizi)
            {
                //diziler referans tiptir.
                //dizileri foreach ile dönebiliriz.
                //dizileri dönerken dizi.Length kullanabiliriz.
                //dizilleri yazdırma
                foreach (var item in dizi)
                {
                    Console.WriteLine(item);
                }
            }

            public long topla2(int s1,int s2)
            { 
                int toplam= s1 + s2;
                return toplam;

            }
        }
        static void Main(string[] args)
        {
            matematik mt = new matematik();
            // bir sınıfı eklediğimizde .net framework içerisindeki tüm sınıfları kullanabiliriz.
            string a = "Hello";
            int[] dizim = { 10, 20, 30, 40, 50 };
            //mt.yaz2(a);
            //mt.yaz3(a, tekrar);
            //mt.ustal(5, 2);
            //mt.yazDizi(dizim);
            Console.WriteLine(mt.topla2(5,6));
            Console.ReadLine();
        }

    }
}

