using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emlakci
{
    class Program
    {
        public static int adet;
        public static int deger;
        public static int[,] evdizi;
        public static int sayac = 0;
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("1. Ev Eklemek" +
                "\n2. Evleri Sorgula" +
                "\n3. Çıkış yap");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                EvEklemek();
            }
            else if (secim == 2)
            {
                EvSorgulama();
            }
            else if (secim == 3)
            {
                Console.Clear();
                Console.WriteLine("Çıkış yapmak için bir tusa basınız...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Menu();
            }
        }
        public static void EvEklemek()
        {

            Console.WriteLine("Kaç adet ev girilecek: ");
            adet = int.Parse(Console.ReadLine());
            evdizi = new int[adet, 3];
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("{0}. evin katı", i + 1);
                evdizi[i, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}. evin m2 ", i + 1);
                evdizi[i, 1] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}. evin daire no", i + 1);
                evdizi[i, 2] = int.Parse(Console.ReadLine());
                fsyazdir(deger);
            }
            AnaMenuSorusu();
        }
        public static void EvSorgulama()
        {
            if (sayac == 0)
            {   
                sayac += 10;
                Console.WriteLine("Ev Listesi Şu an boş...");
                AnaMenuSorusu();
            }
            else if (sayac != 0)
            {   
                for (int i = 0; i < adet; i++)
                {
                    Console.WriteLine("{0}. evin katı:{1} ", i + 1, evdizi[i, 0]);
                    Console.WriteLine("{0}. evin m2:{1} ", i + 1, evdizi[i, 1]);
                    Console.WriteLine("{0}. evin daire no:{1} ", i + 1, evdizi[i, 2]);
                }
                AnaMenuSorusu();
            }
        }
        public static void AnaMenuSorusu()
        {
            Console.WriteLine("Anamenuye Dönmek İster Misiniz:(E/H) ");
            char menudon = char.Parse(Console.ReadLine().ToLower());
            if (menudon == 'e')
            {
                Menu();
            }
            else if (menudon == 'h')
            {
                Console.WriteLine("çıkış yapılıyor..");
            }
            else
            {
                Menu();
            }
        }
        public static void fsyazdir(int deger)
        {
            FileStream fs = new FileStream(@"D:\Test.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < adet; i++)
            {
                sw.Write(evdizi[adet,0]);
                sw.Write(evdizi[adet,1]);
                sw.Write(evdizi[adet,2]);
            }
            fs.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
