using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonOOP_WFA.Model
{
    public class Ogretemenler : Calisanlar
    {
        private int _saatlikUcret;
        private int _calismaSaati;
        public Ogretemenler(string ad, string soyad, string telefon, string tckn, int saatlikucret, int calismaSaati, int maas) : base(maas,ad,soyad,telefon,tckn)
        {
            _saatlikUcret = saatlikucret;
            _calismaSaati = calismaSaati;
            
        }
        public override int MaasHesapla()
        {
            int sonuc = _saatlikUcret * _calismaSaati;
            return sonuc;
        }
    }
}
