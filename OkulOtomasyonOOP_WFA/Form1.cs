using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulOtomasyonOOP_WFA.Model;
using OkulOtomasyonOOP_WFA.Data;

namespace OkulOtomasyonOOP_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public DbContext DbContext = new DbContext();
        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.MdiParent = this;
            ogrenciEkle.Dock = DockStyle.Fill;
            ogrenciEkle.DbContext = DbContext;
            ogrenciEkle.Show();

        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciGoster ogrenciGoster = new OgrenciGoster();
            ogrenciGoster.MdiParent = this;
            ogrenciGoster.Dock = DockStyle.Fill;
            ogrenciGoster.DbContext = DbContext;
            ogrenciGoster.Show();
        }
    }
}
