
namespace OkulOtomasyonOOP_WFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peronellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veliEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.ekleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ekleToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerToolStripMenuItem,
            this.öğretmenlerToolStripMenuItem,
            this.velilerToolStripMenuItem,
            this.peronellerToolStripMenuItem});
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.gösterToolStripMenuItem.Text = "Göster";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            this.öğrencilerToolStripMenuItem.Click += new System.EventHandler(this.öğrencilerToolStripMenuItem_Click);
            // 
            // öğretmenlerToolStripMenuItem
            // 
            this.öğretmenlerToolStripMenuItem.Name = "öğretmenlerToolStripMenuItem";
            this.öğretmenlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğretmenlerToolStripMenuItem.Text = "Öğretmenler";
            // 
            // velilerToolStripMenuItem
            // 
            this.velilerToolStripMenuItem.Name = "velilerToolStripMenuItem";
            this.velilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.velilerToolStripMenuItem.Text = "Veliler";
            // 
            // peronellerToolStripMenuItem
            // 
            this.peronellerToolStripMenuItem.Name = "peronellerToolStripMenuItem";
            this.peronellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peronellerToolStripMenuItem.Text = "Peroneller";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğretmenEkleToolStripMenuItem,
            this.veliEkleToolStripMenuItem,
            this.personelEkleToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğretmenEkleToolStripMenuItem
            // 
            this.öğretmenEkleToolStripMenuItem.Name = "öğretmenEkleToolStripMenuItem";
            this.öğretmenEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğretmenEkleToolStripMenuItem.Text = "Öğretmen Ekle";
            // 
            // veliEkleToolStripMenuItem
            // 
            this.veliEkleToolStripMenuItem.Name = "veliEkleToolStripMenuItem";
            this.veliEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veliEkleToolStripMenuItem.Text = "Veli Ekle";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peronellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veliEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
    }
}

