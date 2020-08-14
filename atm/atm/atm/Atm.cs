using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public class Atm
    {
        string kullaniciadi;
        public string Kullaniciadi
        {
            get { return kullaniciadi; }
            set { kullaniciadi = value; }
        }


        int sifre = 1234;
        public int Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        
        private int bakiye = 0;
        public int Bakiye
        {
            get { return bakiye; }
            set { bakiye = value; }
        }
    }
}
