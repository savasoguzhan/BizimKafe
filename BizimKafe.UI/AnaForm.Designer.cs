namespace BizimKafe.UI
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGecmisSiparisler = new System.Windows.Forms.ToolStripMenuItem();
            this.lwMasalar = new System.Windows.Forms.ListView();
            this.imlResimler = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUrunler,
            this.tsmiGecmisSiparisler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUrunler
            // 
            this.tsmiUrunler.Name = "tsmiUrunler";
            this.tsmiUrunler.Size = new System.Drawing.Size(85, 29);
            this.tsmiUrunler.Text = "Urunler";
            this.tsmiUrunler.Click += new System.EventHandler(this.tsmiUrunler_Click);
            // 
            // tsmiGecmisSiparisler
            // 
            this.tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
            this.tsmiGecmisSiparisler.Size = new System.Drawing.Size(161, 29);
            this.tsmiGecmisSiparisler.Text = "Gecmis Siparisler";
            this.tsmiGecmisSiparisler.Click += new System.EventHandler(this.tsmiGecmisSiparisler_Click);
            // 
            // lwMasalar
            // 
            this.lwMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwMasalar.LargeImageList = this.imlResimler;
            this.lwMasalar.Location = new System.Drawing.Point(0, 33);
            this.lwMasalar.Name = "lwMasalar";
            this.lwMasalar.Size = new System.Drawing.Size(1004, 523);
            this.lwMasalar.TabIndex = 1;
            this.lwMasalar.UseCompatibleStateImageBehavior = false;
            this.lwMasalar.DoubleClick += new System.EventHandler(this.lwMasalar_DoubleClick);
            // 
            // imlResimler
            // 
            this.imlResimler.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlResimler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlResimler.ImageStream")));
            this.imlResimler.TransparentColor = System.Drawing.Color.Transparent;
            this.imlResimler.Images.SetKeyName(0, "bos");
            this.imlResimler.Images.SetKeyName(1, "dolu");
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 556);
            this.Controls.Add(this.lwMasalar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bizim Kafe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiUrunler;
        private ToolStripMenuItem tsmiGecmisSiparisler;
        private ListView lwMasalar;
        private ImageList imlResimler;
    }
}