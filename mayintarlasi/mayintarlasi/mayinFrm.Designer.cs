
namespace mayintarlasi
{
    partial class mayinFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sifirlabtn = new System.Windows.Forms.Button();
            this.zorrb = new System.Windows.Forms.RadioButton();
            this.ortarb = new System.Windows.Forms.RadioButton();
            this.kolayrb = new System.Windows.Forms.RadioButton();
            this.baslabtn = new System.Windows.Forms.Button();
            this.oyunalanigrp = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sifirlabtn);
            this.groupBox1.Controls.Add(this.zorrb);
            this.groupBox1.Controls.Add(this.ortarb);
            this.groupBox1.Controls.Add(this.kolayrb);
            this.groupBox1.Controls.Add(this.baslabtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontroller";
            // 
            // sifirlabtn
            // 
            this.sifirlabtn.Location = new System.Drawing.Point(25, 154);
            this.sifirlabtn.Name = "sifirlabtn";
            this.sifirlabtn.Size = new System.Drawing.Size(75, 23);
            this.sifirlabtn.TabIndex = 4;
            this.sifirlabtn.Text = "Sıfırla";
            this.sifirlabtn.UseVisualStyleBackColor = true;
            this.sifirlabtn.Click += new System.EventHandler(this.sifirlabtn_Click);
            // 
            // zorrb
            // 
            this.zorrb.AutoSize = true;
            this.zorrb.Location = new System.Drawing.Point(25, 87);
            this.zorrb.Name = "zorrb";
            this.zorrb.Size = new System.Drawing.Size(46, 20);
            this.zorrb.TabIndex = 3;
            this.zorrb.TabStop = true;
            this.zorrb.Text = "Zor";
            this.zorrb.UseVisualStyleBackColor = true;
            // 
            // ortarb
            // 
            this.ortarb.AutoSize = true;
            this.ortarb.Location = new System.Drawing.Point(25, 60);
            this.ortarb.Name = "ortarb";
            this.ortarb.Size = new System.Drawing.Size(51, 20);
            this.ortarb.TabIndex = 2;
            this.ortarb.TabStop = true;
            this.ortarb.Text = "Orta";
            this.ortarb.UseVisualStyleBackColor = true;
            // 
            // kolayrb
            // 
            this.kolayrb.AutoSize = true;
            this.kolayrb.Location = new System.Drawing.Point(25, 33);
            this.kolayrb.Name = "kolayrb";
            this.kolayrb.Size = new System.Drawing.Size(60, 20);
            this.kolayrb.TabIndex = 1;
            this.kolayrb.TabStop = true;
            this.kolayrb.Text = "Kolay";
            this.kolayrb.UseVisualStyleBackColor = true;
            // 
            // baslabtn
            // 
            this.baslabtn.Location = new System.Drawing.Point(25, 125);
            this.baslabtn.Name = "baslabtn";
            this.baslabtn.Size = new System.Drawing.Size(75, 23);
            this.baslabtn.TabIndex = 0;
            this.baslabtn.Text = "Başla";
            this.baslabtn.UseVisualStyleBackColor = true;
            this.baslabtn.Click += new System.EventHandler(this.baslabtn_Click);
            // 
            // oyunalanigrp
            // 
            this.oyunalanigrp.Location = new System.Drawing.Point(149, 12);
            this.oyunalanigrp.Name = "oyunalanigrp";
            this.oyunalanigrp.Size = new System.Drawing.Size(351, 297);
            this.oyunalanigrp.TabIndex = 1;
            this.oyunalanigrp.TabStop = false;
            this.oyunalanigrp.Text = "Oyun Alanı";
            // 
            // mayinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 318);
            this.Controls.Add(this.oyunalanigrp);
            this.Controls.Add(this.groupBox1);
            this.Name = "mayinFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox oyunalanigrp;
        private System.Windows.Forms.RadioButton kolayrb;
        private System.Windows.Forms.Button baslabtn;
        private System.Windows.Forms.RadioButton zorrb;
        private System.Windows.Forms.RadioButton ortarb;
        private System.Windows.Forms.Button sifirlabtn;
    }
}

