using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OkulOtomasyonOOP_WFA.Model;

namespace OkulOtomasyonOOP_WFA.Data
{
    public class DbContext
    {
        public List<Ogrenciler> Ogrenciler { get; set; } = new List<Ogrenciler>();
        public List<Ogretemenler> Ogretmenler { get; set; } = new List<Ogretemenler>();
        public List<Veliler> Veliler { get; set; } = new List<Veliler>();
        public List<Personeller> Personeller { get; set; } = new List<Personeller>();
        
    }
}
