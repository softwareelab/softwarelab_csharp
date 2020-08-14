using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    class Program
    {
        public static Atm atm_kapsul = new Atm();

        static public void Main(string[] args)
        {            
            KullaniciGirisi();
        }
        static public void KullaniciGirisi()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Kullanıcı adını giriniz: ");
            atm_kapsul.Kullaniciadi = Console.ReadLine();
            if (atm_kapsul.Kullaniciadi == "admin")
            {
                SifreSorgu();
            }
            else if (atm_kapsul.Kullaniciadi != "admin")
            {
                Console.WriteLine("Giriş Yapılamadı !");
                KullaniciGirisi();
            }
        }
        static public void SifreSorgu()
        {
            Console.WriteLine("Şifre Giriniz:");
            int sifre_sorgu = int.Parse(Console.ReadLine());
            if (atm_kapsul.Sifre == sifre_sorgu)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Giriş Başarılı!");
                AtmGirisMenu();
            }
            else if (atm_kapsul.Sifre != sifre_sorgu)
            {
                Console.WriteLine("Şifreniz Hatalı!");
                KullaniciGirisi();
            }
        }
        static public void AtmGirisMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: " +
            "\n1. Bakiye Sorgulama" +
            "\n2. Para Çekme" +
            "\n3. Para Yatırma" +
            "\n4. Şifre Değiştir");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                BakiyeYazdir();
            }
            else if (secim == 2)
            {
                ParaCekme();
            }
            else if (secim == 3)
            {
                ParaYatirma();
            }
            else if (secim == 4)
            {
                SifteDegistir();
            }
        }
        static public void BakiyeYazdir()
        {
            Console.WriteLine("Bakiyeniz: " + atm_kapsul.Bakiye);
            AnaMenuDon();
        }
        static public void ParaCekme()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ne kadar para çekilecek: ");
            int cekilecek_tutar = int.Parse(Console.ReadLine());
            if (cekilecek_tutar > atm_kapsul.Bakiye)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bakiyeniz Yetersiz!");
                AnaMenuDon();
            }
            else if (cekilecek_tutar <= atm_kapsul.Bakiye)
            {
                atm_kapsul.Bakiye -= cekilecek_tutar;
                Console.WriteLine("Para Çekme işlemi yapılıyor..."
                    + "\nGüncel bakiyeniz: " + atm_kapsul.Bakiye);
                AnaMenuDon();
            }
        }
        static public void ParaYatirma()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Yatırılacak Tutarı giriniz: ");
            int yatirilacak_tutar = int.Parse(Console.ReadLine());
            atm_kapsul.Bakiye += yatirilacak_tutar;
            Console.WriteLine("Güncel Bakiyeniz: " + atm_kapsul.Bakiye);
            AnaMenuDon();
        }
        static public void SifteDegistir()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Şifrenizi Giriniz: ");
            int sifrekontrol = int.Parse(Console.ReadLine());
            if (atm_kapsul.Sifre == sifrekontrol)
            {
                Console.WriteLine("Yeni şifrenizi giriniz: ");
                int yenisifre = int.Parse(Console.ReadLine());
                Console.WriteLine("Yeni Şifrenizi Tekrar giriniz:");
                int yenisifre_tekrar = int.Parse(Console.ReadLine());
                if (yenisifre == yenisifre_tekrar)
                {
                    atm_kapsul.Sifre = yenisifre;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sifreniz başarıyla değiştirildi!");
                    AnaMenuDon();
                }
                else if (yenisifre != yenisifre_tekrar)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("şifreniz uyuşmuyor!");
                    SifteDegistirYenidenSorsunMu();
                }
            }
            else if (atm_kapsul.Sifre != sifrekontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Şifrenizi hatalı girdiniz!");
                SifteDegistirYenidenSorsunMu();
            }
        }
        static public void SifteDegistirYenidenSorsunMu()
        {
            Console.WriteLine("Şifrenizi Tekrardan Değiştirmek ister misiniz: (E/H) ?");
            char evethayir = char.Parse(Console.ReadLine().ToLower());
            if (evethayir == 'e')
            {
                SifteDegistir();
            }
            else if (evethayir == 'h')
            {
                AnaMenuDon();
            }
            else
            {
                Console.WriteLine("Lütfen 1 yada 2 olarak belirtiniz!");
                SifteDegistirYenidenSorsunMu();
            }
        }
        static public void AnaMenuDon()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ana Menuye dönmek ister misiniz (E/H): ");
            char anamenudon = char.Parse(Console.ReadLine().ToLower());

            if (anamenudon == 'e')
            {
                AtmGirisMenu();
            }
            else if (anamenudon == 'h')
            {
                Console.WriteLine("Güle güle...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lütfen E yada H harfini kullanınız!");
                AnaMenuDon();
            }
        }
    }
}
