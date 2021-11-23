using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonOOP_WFA.Model
{
    public abstract class Kisiler
    {
        private string Ad { get; set; }
        private string Soyad { get; set; }
        private string Telefon { get; set; }
        private string TCKN { get; set; }

        public Kisiler(string ad, string soyad, string telefon, string tckn)
        {
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            TCKN = tckn;
        }

    }
}
