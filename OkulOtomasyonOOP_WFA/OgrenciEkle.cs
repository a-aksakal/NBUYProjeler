using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulOtomasyonOOP_WFA.Data;
using OkulOtomasyonOOP_WFA.Model;

namespace OkulOtomasyonOOP_WFA
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private DbContext _dbContext = new DbContext();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Ogrenciler ogrenciler = new Ogrenciler(txtAd.Text, txtSoyad.Text, txtTelefon.Text, txtTCKN.Text);
            _dbContext.Ogrenciler.Add(ogrenciler);
        }
    }
}
