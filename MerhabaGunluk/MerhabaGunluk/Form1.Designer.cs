namespace MerhabaGunluk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ac = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_fkaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_font = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_renk = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSbtn_Yeni = new System.Windows.Forms.ToolStripButton();
            this.TSbtn_ac = new System.Windows.Forms.ToolStripButton();
            this.TSbtn_kaydet = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ac,
            this.toolStripSeparator1,
            this.TSMI_kaydet,
            this.TSMI_fkaydet,
            this.toolStripSeparator3,
            this.TSMI_kapat});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // TSMI_ac
            // 
            this.TSMI_ac.Name = "TSMI_ac";
            this.TSMI_ac.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMI_ac.Size = new System.Drawing.Size(150, 22);
            this.TSMI_ac.Text = "Aç";
            this.TSMI_ac.Click += new System.EventHandler(this.TSMI_ac_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // TSMI_kaydet
            // 
            this.TSMI_kaydet.Name = "TSMI_kaydet";
            this.TSMI_kaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_kaydet.Size = new System.Drawing.Size(150, 22);
            this.TSMI_kaydet.Text = "Kaydet";
            this.TSMI_kaydet.Click += new System.EventHandler(this.TSMI_kaydet_Click);
            // 
            // TSMI_fkaydet
            // 
            this.TSMI_fkaydet.Name = "TSMI_fkaydet";
            this.TSMI_fkaydet.Size = new System.Drawing.Size(150, 22);
            this.TSMI_fkaydet.Text = "Farklı Kaydet";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
            // 
            // TSMI_kapat
            // 
            this.TSMI_kapat.Name = "TSMI_kapat";
            this.TSMI_kapat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.TSMI_kapat.Size = new System.Drawing.Size(150, 22);
            this.TSMI_kapat.Text = "Kapat";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_font,
            this.TSMI_renk});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // TSMI_font
            // 
            this.TSMI_font.Name = "TSMI_font";
            this.TSMI_font.Size = new System.Drawing.Size(180, 22);
            this.TSMI_font.Text = "Font Ayarları";
            this.TSMI_font.Click += new System.EventHandler(this.TSMI_font_Click);
            // 
            // TSMI_renk
            // 
            this.TSMI_renk.Name = "TSMI_renk";
            this.TSMI_renk.Size = new System.Drawing.Size(180, 22);
            this.TSMI_renk.Text = "Renk Ayarları";
            this.TSMI_renk.Click += new System.EventHandler(this.TSMI_renk_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1010, 412);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.UseWaitCursor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSbtn_Yeni,
            this.TSbtn_ac,
            this.TSbtn_kaydet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1010, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.UseWaitCursor = true;
            // 
            // TSbtn_Yeni
            // 
            this.TSbtn_Yeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSbtn_Yeni.Image = ((System.Drawing.Image)(resources.GetObject("TSbtn_Yeni.Image")));
            this.TSbtn_Yeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtn_Yeni.Name = "TSbtn_Yeni";
            this.TSbtn_Yeni.Size = new System.Drawing.Size(24, 24);
            this.TSbtn_Yeni.Text = "Yeni";
            this.TSbtn_Yeni.Click += new System.EventHandler(this.TSbtn_Yeni_Click);
            // 
            // TSbtn_ac
            // 
            this.TSbtn_ac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSbtn_ac.Image = ((System.Drawing.Image)(resources.GetObject("TSbtn_ac.Image")));
            this.TSbtn_ac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtn_ac.Name = "TSbtn_ac";
            this.TSbtn_ac.Size = new System.Drawing.Size(24, 24);
            this.TSbtn_ac.Text = "Aç";
            this.TSbtn_ac.Click += new System.EventHandler(this.TSbtn_ac_Click);
            // 
            // TSbtn_kaydet
            // 
            this.TSbtn_kaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSbtn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("TSbtn_kaydet.Image")));
            this.TSbtn_kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtn_kaydet.Name = "TSbtn_kaydet";
            this.TSbtn_kaydet.Size = new System.Drawing.Size(24, 24);
            this.TSbtn_kaydet.Text = "Kaydet";
            this.TSbtn_kaydet.Click += new System.EventHandler(this.TSbtn_kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 436);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Merhaba Günlük";
            this.UseWaitCursor = true;
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ac;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_fkaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kapat;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSbtn_Yeni;
        private System.Windows.Forms.ToolStripButton TSbtn_ac;
        private System.Windows.Forms.ToolStripButton TSbtn_kaydet;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_font;
        private System.Windows.Forms.ToolStripMenuItem TSMI_renk;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

