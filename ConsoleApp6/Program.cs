using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{  
    class personel
        { 
        public int id;
        public string name;
        public string surname;
        public byte Age;
         public void personelyaz()
         {
            Console.WriteLine("Id={0} Ad={1} Soyad={2} Yaş={3}",id,name,surname,Age);
            Console.ReadKey();
         }

        public void adsoyad()
        {
            Console.WriteLine(name+surname);
            Console.ReadLine();
        }

        public string adsoyad1()
        { 
        return  name+surname;
        }

        public int toplam()
        {
            int a = 0;
            int b = 15;
            return a+ b;
        }
        }


    class matematik
    { 
    
    }

    internal class Program
    {
        /*
        static int a;

        static void test()
        {
            int a;
            Program.a = 5;
        }

        static void yaz()
        {
            int a;
            a = 20;
        } */
        static void Main(string[] args)
        {
        personel p = new personel();
            p.id = 5;
            p.name= "Hamid Han";
            p.surname = "Doğdu";
            p.Age = 19;
            p.adsoyad();
            string y=p.adsoyad1();
            int hesap=p.toplam();
            p.personelyaz();
            Console.WriteLine(y+hesap);
            Console.ReadLine();
        }
        //methods
        //static /değil , geri dönüş tipi veritipi/void,methodun adı(parametreler alacağı yerler)
        //{
        //}
    }
}
