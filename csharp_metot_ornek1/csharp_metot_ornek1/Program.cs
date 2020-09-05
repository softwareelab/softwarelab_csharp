using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_metot_ornek1
{
    class Program
    {
        public static float sayi1, sayi2;
        public static float toplama, cikarma, bolme, carpma;

        static void Main(string[] args)
        {
            calistir();
        }

        private static void calistir()
        {
            try
            {
                //metotlarla hesap makinası yapalım
                Console.WriteLine("Hangi işlemi yapmak istiyorsunuz: ");
                Console.WriteLine("1.Toplama\n" +
                    "2.Çıkarma\n" +
                    "3.Bolme\n" +
                    "4.Carpma\n" +
                    "5.Çıkış Yap");
                int islem = Convert.ToInt32(Console.ReadLine());
                if (islem <= 5 && islem >= 1)
                {
                    //2 farklı tür kullanabiliriz
                    //1 = switch case
                    //2 = if else
                    //iki örnegi de ele alacagız

                    //Switch case
                    Console.WriteLine("Birinci sayıyı giriniz: ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İkinci sayıyı giriniz: ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());

                    switch (islem)
                    {
                        case 1:
                            toplamaIslemi();
                            break;

                        case 2:
                            cikarmaIslemi();
                            break;

                        case 3:
                            bolmeIslemi();
                            break;

                        case 4:
                            carpmaIslemi();
                            break;

                        case 5:
                            cikisyap();
                            break;
                    }

                    //if else
                    //burayı acıklama satırı olarak gösterecegim
                    //sebebi switch case yapısını kullanacagız
                    //amac 2 farklı kullanım sekli göstermek
                   
                    
                    /*
                    if (islem == 1)
                    {
                        toplamaIslemi();
                    }
                    else if (islem == 2)
                    {
                        cikarmaIslemi();
                    }
                    else if (islem == 3)
                    {
                        bolmeIslemi();
                    }
                    else if (islem == 4)
                    {
                        carpmaIslemi();
                    }
                    else if(islem == 5)
                    {
                        cikisyap();
                    }
                    else if(islem > 5 || islem < 0)
                    {
                        Console.WriteLine("Seçiminizi 1-5 arası yapınız!");
                        calistir();
                    }
                    */
                }
                else
                {
                    Console.WriteLine("Lütfen 1-4 arası bir secim yapınız!");
                    calistir();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Sadece Rakam Giriniz!");
                calistir();
            }
        }       
        private static void toplamaIslemi()
        {
            toplama = sayi1 + sayi2;
            Console.WriteLine("Toplama işlemi sonucu: " + toplama);
            islemiTekrarlaSorusu();
        }
        private static void cikarmaIslemi()
        {
            cikarma = sayi1 - sayi2;
            Console.WriteLine("Çıkarma işlemi sonucu: " + cikarma);
            islemiTekrarlaSorusu();
        }
        private static void bolmeIslemi()
        {
            if (sayi2 <= 0)
            {
                Console.WriteLine("Sayı 0'a bölünemez!\n" +
                    "Sonuç tanımsız!");
                islemiTekrarlaSorusu();
            }
            else
            {
                bolme = sayi1 / sayi2;
                Console.WriteLine("Bölme işlemi sonucu: " + bolme);
                islemiTekrarlaSorusu();
            }
        }
        private static void carpmaIslemi()
        {
            carpma = sayi1 * sayi2;
            Console.WriteLine("Çarpma işlemi sonucu: " + carpma);
            islemiTekrarlaSorusu();
        }
        private static void cikisyap()
        {
            Console.WriteLine("Çıkış yapılıyor...");
        }
        private static void islemiTekrarlaSorusu()
        {
            Console.WriteLine("Yeni bir işlem yapmak ister misiniz ? (E/H)");
            char yeniden = char.Parse(Console.ReadLine().ToLower());

            if (yeniden == 'e')
            {
                calistir();
            }
            else if (yeniden == 'h')
            {
                Console.WriteLine("Program kapatılıyor...");
            }
            else
            {
                Console.WriteLine("E ya da H harfi kullanınız!");
                islemiTekrarlaSorusu();
            }
        }
    }
}
