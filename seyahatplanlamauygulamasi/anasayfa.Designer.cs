namespace seyahatplanlamauygulamasi
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_rota = new System.Windows.Forms.Panel();
            this.pnl_kayitlirota = new System.Windows.Forms.Panel();
            this.pnl_cikis = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pnl_rota
            // 
            this.pnl_rota.BackColor = System.Drawing.Color.Transparent;
            this.pnl_rota.Location = new System.Drawing.Point(82, 188);
            this.pnl_rota.Name = "pnl_rota";
            this.pnl_rota.Size = new System.Drawing.Size(177, 208);
            this.pnl_rota.TabIndex = 1;
            this.pnl_rota.Click += new System.EventHandler(this.pnl_rota_Click_1);
            // 
            // pnl_kayitlirota
            // 
            this.pnl_kayitlirota.BackColor = System.Drawing.Color.Transparent;
            this.pnl_kayitlirota.Location = new System.Drawing.Point(295, 188);
            this.pnl_kayitlirota.Name = "pnl_kayitlirota";
            this.pnl_kayitlirota.Size = new System.Drawing.Size(181, 208);
            this.pnl_kayitlirota.TabIndex = 2;
            this.pnl_kayitlirota.Click += new System.EventHandler(this.pnl_kayitlirota_Click_1);
            // 
            // pnl_cikis
            // 
            this.pnl_cikis.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cikis.Location = new System.Drawing.Point(82, 422);
            this.pnl_cikis.Name = "pnl_cikis";
            this.pnl_cikis.Size = new System.Drawing.Size(394, 48);
            this.pnl_cikis.TabIndex = 2;
            this.pnl_cikis.Click += new System.EventHandler(this.pnl_cikis_Click_1);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.pnl_cikis);
            this.Controls.Add(this.pnl_kayitlirota);
            this.Controls.Add(this.pnl_rota);
            this.Controls.Add(this.label1);
            this.Name = "anasayfa";
            this.Text = "Seyahat Planlama Uygulaması";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_rota;
        private System.Windows.Forms.Panel pnl_kayitlirota;
        private System.Windows.Forms.Panel pnl_cikis;
    }
}