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
    public partial class OgrenciGoster : Form
    {
        public OgrenciGoster()
        {
            InitializeComponent();
        }
        public DbContext DbContext { get; set; }

        private void OgrenciGoster_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = DbContext.Ogrenciler.ToList();
        }
    }
}
