namespace seyahatplanlamauygulamasi
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.pnl_giris = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adsoyad.Location = new System.Drawing.Point(184, 252);
            this.txt_adsoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(210, 27);
            this.txt_adsoyad.TabIndex = 0;
            this.txt_adsoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_no
            // 
            this.txt_no.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_no.Location = new System.Drawing.Point(197, 304);
            this.txt_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_no.MaxLength = 10;
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(197, 27);
            this.txt_no.TabIndex = 1;
            // 
            // pnl_giris
            // 
            this.pnl_giris.BackColor = System.Drawing.Color.Transparent;
            this.pnl_giris.Location = new System.Drawing.Point(215, 349);
            this.pnl_giris.Name = "pnl_giris";
            this.pnl_giris.Size = new System.Drawing.Size(125, 40);
            this.pnl_giris.TabIndex = 2;
            this.pnl_giris.Click += new System.EventHandler(this.pnl_giris_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.pnl_giris);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.txt_adsoyad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "giris";
            this.Text = "Seyahat Planlama Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Panel pnl_giris;
    }
}

