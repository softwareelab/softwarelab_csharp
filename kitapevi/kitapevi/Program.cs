using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitapevi
{
    class Program
    {
        public static int adet = 0;
        public static string[,] kitapdizi;
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu()
        {
            Console.WriteLine("-----MENU-----");
            Console.WriteLine("1. Kitap Eklemek: ");
            Console.WriteLine("2. Kitap Listesini Görüntüle: ");
            Console.WriteLine("3. Çıkış Yap");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                kitapEklemek();
            }
            else if (secim == 2)
            {
                kitapGoruntule();
            }
            else if (secim == 3)
            {
                Console.WriteLine("Cıkıs yapılıyor...");
            }

            Console.ReadKey();
        }

        private static void kitapEklemek()
        {
            Console.WriteLine("kaç adet kitap eklenecek ?");
            adet = int.Parse(Console.ReadLine());
            
            kitapdizi = new string[adet, 3];

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("kitap yazarı: ");
                kitapdizi[i, 0] = Console.ReadLine();
                Console.WriteLine("kitap türü: ");
                kitapdizi[i, 1] = Console.ReadLine();
                Console.WriteLine("basım yılı: ");
                kitapdizi[i, 2] = Console.ReadLine();
            }
            Console.WriteLine("kitap ekleme başarıyla tamamlandı!");
            Console.WriteLine("menuye dönülsünmü(E/H) ?");
            char kitapeklemenudon = char.Parse(Console.ReadLine().ToLower());
            if (kitapeklemenudon == 'e')
            {
                menu();
            }
            else if (kitapeklemenudon == 'h')
            {
                Console.WriteLine("Uygulama kapatılıyor..");
            }
            else
            {
                menu();
            }

        }

        public static void kitapGoruntule()
        {

            Console.WriteLine("kitap listesi görüntüleniyor!");
            for (int i = 0; i < adet; i++)
            {
                
                 Console.WriteLine("kitabın yazarı: {0} ",kitapdizi[i,0]);
                 Console.WriteLine("kitabın türü: {0} ",kitapdizi[i,1]);
                 Console.WriteLine("kitabın basım yılı: {0} ",kitapdizi[i,2]);
                
            }

            Console.WriteLine("menuye donulsun mu (E/H) ?");
            char kitapsorgumenudon = char.Parse(Console.ReadLine().ToLower());

            if (kitapsorgumenudon == 'e')
            {
                menu();
            }
            else if(kitapsorgumenudon == 'h')
            {
                Console.WriteLine("Uygulamadan cıkılıyor!");
            }
            else
            {
                menu();

            }

        }
    }
}
