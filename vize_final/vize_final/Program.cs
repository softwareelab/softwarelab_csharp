using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize_final
{
    class Program
    {
        static public int vizenotu;
        static public int vizeort;
        static public int vizetoplam;


        static public int finalnotu;
        static public int finalort;
        static public int finaltoplam;

        static public float notort;

        static void Main(string[] args)
        {
            Calistir();
        }

        private static void Calistir()
        {
            Console.WriteLine("-----Vize-Final Ortalaması Alıp Hesaplatma-----");
            VizeHesaplama();
        }
        private static void VizeHesaplama()
        {
            Console.Write("Vize notunuzu giriniz: ");
            vizenotu = int.Parse(Console.ReadLine());
            if (vizenotu <= 100 && vizenotu >= 0)
            {
                Console.Write("Vizenizin yüzde kaç ortalaması alınacak? ");
                vizeort = int.Parse(Console.ReadLine());
                if (vizeort <= 100 && vizeort >= 0)
                {
                    vizetoplam = (vizenotu * vizeort) / 100;
                    FinalHesaplama();
                }
                else if (vizeort > 100)
                {
                    Console.WriteLine("100'den büyük girilemez!");
                    VizeHesaplama();
                }
            }
            else if (vizenotu > 100 || vizenotu < 0)
            {
                Console.WriteLine("Notunuz 0-100 arası olmalıdır!");
                VizeHesaplama();
            }

        }


        private static void FinalHesaplama()
        {
            Console.Write("Final notunuzu giriniz: ");
            finalnotu = int.Parse(Console.ReadLine());
            if (finalnotu <= 100 && finalnotu >= 0)
            {
                Console.Write("Final notunuzun yüzde kaç ortalaması alınacak? ");
                finalort = int.Parse(Console.ReadLine());
                if (finalort <= 100 && finalort >= 0 && finalort + vizeort == 100)
                {
                    finaltoplam = (finalnotu * finalort) / 100;
                    HarfNotu();
                }
                else if (finalort > 100 || finalort + vizeort > 100)
                {
                    Console.WriteLine("100'den büyük girilemez!");
                    FinalHesaplama();
                }
            }
            else if (finalnotu > 100 || finalnotu < 0)
            {
                Console.WriteLine("Notunuz 0-100 arası olmalıdır!");
                FinalHesaplama();
            }
        }
        private static void HarfNotu()
        {
            notort = vizetoplam + finaltoplam;
            if (notort <= 100 && notort >= 85)
            {
                Console.WriteLine("Ortalamanız: {0} \nHarf Notunuz: AA", notort);
            }
            else if (notort < 85 && notort >= 70)
            {
                Console.WriteLine("Ortalamanız: {0} \nHarf Notunuz: AB", notort);
            }
            else if (notort < 70 && notort >= 60)
            {
                Console.WriteLine("Ortalamanız: {0} \nHarf Notunuz: BB", notort);
            }
            else if (notort < 60 && notort >= 50)
            {
                Console.WriteLine("Ortalamanız: {0} \nHarf Notunuz: BC", notort);
            }
            else if (notort < 50 && notort >= 40)
            {
                Console.WriteLine("Ortalamanız: {0} \nHarf Notunuz: CC", notort);
            }
            else if (notort < 40 && notort >= 30)
            {
                Console.WriteLine("Ortalamanız: {0} \nHarf Notunuz: CD", notort);
            }
            else if (notort < 30 && notort >= 20)
            {
                Console.WriteLine("Ortalamanız: {0} \nHarf Notunuz: DD", notort);
            }
            else if (notort < 20 && notort >= 0)
            {
                Console.WriteLine("Kaldınız!");
            }
            AnaMenu();
        }
        static private void AnaMenu()
        {
            Console.WriteLine("Yeniden işlem yapmak ister misiniz(E/H) ?");
            char evethayir = char.Parse(Console.ReadLine().ToLower());
            if (evethayir == 'e')
            {
                Calistir();
            }
            else if (evethayir == 'h')
            {
                Console.WriteLine("İyi Günler...");
            }
        }

    }
}
