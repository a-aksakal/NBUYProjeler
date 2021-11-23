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

        private DbContext _dbContext;
        
        private void OgrenciGoster_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dbContext.Ogrenciler;
        }
    }
}
