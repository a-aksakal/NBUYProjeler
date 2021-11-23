using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonOOP_WFA.Model
{
    public class Personeller : Calisanlar
    {
        public Personeller(string ad, string soyad, string telefon, string tckn, int maas) : base(maas,ad,soyad,telefon,tckn)
        {
            MaasHesapla();
        }
    }
}
