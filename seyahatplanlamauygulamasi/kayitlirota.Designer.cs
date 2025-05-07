namespace seyahatplanlamauygulamasi
{
    partial class kayitlirota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayitlirota));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnl_geri = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 303);
            this.listBox1.TabIndex = 0;
            // 
            // pnl_geri
            // 
            this.pnl_geri.BackColor = System.Drawing.Color.Transparent;
            this.pnl_geri.Location = new System.Drawing.Point(232, 394);
            this.pnl_geri.Name = "pnl_geri";
            this.pnl_geri.Size = new System.Drawing.Size(154, 44);
            this.pnl_geri.TabIndex = 3;
            this.pnl_geri.Click += new System.EventHandler(this.pnl_geri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(65, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 44);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // kayitlirota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_geri);
            this.Controls.Add(this.listBox1);
            this.Name = "kayitlirota";
            this.Text = "Seyahat Planlama Uygulaması";
            this.Load += new System.EventHandler(this.kayitlirota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnl_geri;
        private System.Windows.Forms.Panel panel1;
    }
}