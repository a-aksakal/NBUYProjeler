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

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.MdiParent = this;
            ogrenciEkle.Dock = DockStyle.Fill;
            ogrenciEkle.Show();

        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciGoster ogrenciGoster = new OgrenciGoster();
            ogrenciGoster.MdiParent = this;
            ogrenciGoster.Dock = DockStyle.Fill;
            ogrenciGoster.Show();
        }
    }
}
