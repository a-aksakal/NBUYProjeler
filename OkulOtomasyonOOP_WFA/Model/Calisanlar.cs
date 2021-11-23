using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyonOOP_WFA.Model
{
    public abstract class Calisanlar : Kisiler
    {
        private int _maas { get; set; }
        public Calisanlar(int maas,string ad,string soyad,string telefon, string tckn) : base(ad,soyad,telefon,tckn)
        {
            _maas = maas;
        }
        public virtual int MaasHesapla()
        {
            int sonuc = _maas;
            _maas = sonuc;
            return _maas;
        } 
    }
}
