namespace TekCİftArmstrongAsal
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpGirisBilgileri = new System.Windows.Forms.GroupBox();
            this.mtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.tbTeksayi = new System.Windows.Forms.TabPage();
            this.lblTekCarpim = new System.Windows.Forms.Label();
            this.lblTekToplam = new System.Windows.Forms.Label();
            this.txtTekCarpim = new System.Windows.Forms.TextBox();
            this.txtTekToplam = new System.Windows.Forms.TextBox();
            this.lwTeksayi = new System.Windows.Forms.ListView();
            this.tbKontrol = new System.Windows.Forms.TabControl();
            this.tbCiftSayi = new System.Windows.Forms.TabPage();
            this.lblCiftCarpim = new System.Windows.Forms.Label();
            this.lblCiftToplam = new System.Windows.Forms.Label();
            this.txtCiftCarpim = new System.Windows.Forms.TextBox();
            this.txtCiftToplam = new System.Windows.Forms.TextBox();
            this.lwCiftSayi = new System.Windows.Forms.ListView();
            this.tbAsalSayi = new System.Windows.Forms.TabPage();
            this.lblAsalCarpim = new System.Windows.Forms.Label();
            this.lblAsalToplam = new System.Windows.Forms.Label();
            this.txtAsalCarpim = new System.Windows.Forms.TextBox();
            this.txtAsalToplam = new System.Windows.Forms.TextBox();
            this.lwAsalSayi = new System.Windows.Forms.ListView();
            this.tbArmstrongSayi = new System.Windows.Forms.TabPage();
            this.lbArmstrongCarpim = new System.Windows.Forms.Label();
            this.lbArmstrongToplam = new System.Windows.Forms.Label();
            this.txtArmstrongCarpim = new System.Windows.Forms.TextBox();
            this.txtArmstrongToplam = new System.Windows.Forms.TextBox();
            this.lwArmstrongSayi = new System.Windows.Forms.ListView();
            this.ntfBildirim = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpGirisBilgileri.SuspendLayout();
            this.tbTeksayi.SuspendLayout();
            this.tbKontrol.SuspendLayout();
            this.tbCiftSayi.SuspendLayout();
            this.tbAsalSayi.SuspendLayout();
            this.tbArmstrongSayi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGirisBilgileri
            // 
            this.grpGirisBilgileri.Controls.Add(this.mtxtBaslangic);
            this.grpGirisBilgileri.Controls.Add(this.mtxtBitis);
            this.grpGirisBilgileri.Controls.Add(this.btnİleri);
            this.grpGirisBilgileri.Controls.Add(this.btnGeri);
            this.grpGirisBilgileri.Controls.Add(this.btnHesapla);
            this.grpGirisBilgileri.Controls.Add(this.lblBitis);
            this.grpGirisBilgileri.Controls.Add(this.lblBaslangic);
            this.grpGirisBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpGirisBilgileri.Name = "grpGirisBilgileri";
            this.grpGirisBilgileri.Size = new System.Drawing.Size(776, 98);
            this.grpGirisBilgileri.TabIndex = 0;
            this.grpGirisBilgileri.TabStop = false;
            this.grpGirisBilgileri.Text = "Giriş Bilgileri";
            // 
            // mtxtBaslangic
            // 
            this.mtxtBaslangic.Location = new System.Drawing.Point(116, 39);
            this.mtxtBaslangic.Name = "mtxtBaslangic";
            this.mtxtBaslangic.Size = new System.Drawing.Size(100, 22);
            this.mtxtBaslangic.TabIndex = 10;
            this.mtxtBaslangic.Text = "1";
            this.mtxtBaslangic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBaslangic_KeyPress);
            // 
            // mtxtBitis
            // 
            this.mtxtBitis.Location = new System.Drawing.Point(328, 40);
            this.mtxtBitis.Name = "mtxtBitis";
            this.mtxtBitis.Size = new System.Drawing.Size(100, 22);
            this.mtxtBitis.TabIndex = 11;
            this.mtxtBitis.Text = "10000";
            this.mtxtBitis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBitis_KeyPress);
            // 
            // btnİleri
            // 
            this.btnİleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİleri.Location = new System.Drawing.Point(683, 37);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(75, 23);
            this.btnİleri.TabIndex = 14;
            this.btnİleri.Text = "İleri>>";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(589, 37);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "<<Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(467, 39);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(88, 23);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(243, 40);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(34, 17);
            this.lblBitis.TabIndex = 16;
            this.lblBitis.Text = "Bitiş";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(19, 40);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(69, 17);
            this.lblBaslangic.TabIndex = 15;
            this.lblBaslangic.Text = "Başlangıç";
            // 
            // tbTeksayi
            // 
            this.tbTeksayi.Controls.Add(this.lblTekCarpim);
            this.tbTeksayi.Controls.Add(this.lblTekToplam);
            this.tbTeksayi.Controls.Add(this.txtTekCarpim);
            this.tbTeksayi.Controls.Add(this.txtTekToplam);
            this.tbTeksayi.Controls.Add(this.lwTeksayi);
            this.tbTeksayi.Location = new System.Drawing.Point(4, 25);
            this.tbTeksayi.Name = "tbTeksayi";
            this.tbTeksayi.Padding = new System.Windows.Forms.Padding(3);
            this.tbTeksayi.Size = new System.Drawing.Size(768, 293);
            this.tbTeksayi.TabIndex = 0;
            this.tbTeksayi.Text = "Tek Sayılar";
            this.tbTeksayi.UseVisualStyleBackColor = true;
            // 
            // lblTekCarpim
            // 
            this.lblTekCarpim.AutoSize = true;
            this.lblTekCarpim.Location = new System.Drawing.Point(235, 268);
            this.lblTekCarpim.Name = "lblTekCarpim";
            this.lblTekCarpim.Size = new System.Drawing.Size(67, 17);
            this.lblTekCarpim.TabIndex = 13;
            this.lblTekCarpim.Text = "ÇARPIM :";
            // 
            // lblTekToplam
            // 
            this.lblTekToplam.AutoSize = true;
            this.lblTekToplam.Location = new System.Drawing.Point(11, 268);
            this.lblTekToplam.Name = "lblTekToplam";
            this.lblTekToplam.Size = new System.Drawing.Size(73, 17);
            this.lblTekToplam.TabIndex = 12;
            this.lblTekToplam.Text = "TOPLAM :";
            // 
            // txtTekCarpim
            // 
            this.txtTekCarpim.Location = new System.Drawing.Point(320, 265);
            this.txtTekCarpim.Multiline = true;
            this.txtTekCarpim.Name = "txtTekCarpim";
            this.txtTekCarpim.Size = new System.Drawing.Size(442, 22);
            this.txtTekCarpim.TabIndex = 10;
            // 
            // txtTekToplam
            // 
            this.txtTekToplam.Location = new System.Drawing.Point(90, 263);
            this.txtTekToplam.Name = "txtTekToplam";
            this.txtTekToplam.Size = new System.Drawing.Size(100, 22);
            this.txtTekToplam.TabIndex = 11;
            // 
            // lwTeksayi
            // 
            this.lwTeksayi.HideSelection = false;
            this.lwTeksayi.Location = new System.Drawing.Point(0, 0);
            this.lwTeksayi.Name = "lwTeksayi";
            this.lwTeksayi.Size = new System.Drawing.Size(768, 254);
            this.lwTeksayi.TabIndex = 1;
            this.lwTeksayi.UseCompatibleStateImageBehavior = false;
            // 
            // tbKontrol
            // 
            this.tbKontrol.Controls.Add(this.tbTeksayi);
            this.tbKontrol.Controls.Add(this.tbCiftSayi);
            this.tbKontrol.Controls.Add(this.tbAsalSayi);
            this.tbKontrol.Controls.Add(this.tbArmstrongSayi);
            this.tbKontrol.Location = new System.Drawing.Point(12, 116);
            this.tbKontrol.Name = "tbKontrol";
            this.tbKontrol.SelectedIndex = 0;
            this.tbKontrol.Size = new System.Drawing.Size(776, 322);
            this.tbKontrol.TabIndex = 1;
            // 
            // tbCiftSayi
            // 
            this.tbCiftSayi.Controls.Add(this.lblCiftCarpim);
            this.tbCiftSayi.Controls.Add(this.lblCiftToplam);
            this.tbCiftSayi.Controls.Add(this.txtCiftCarpim);
            this.tbCiftSayi.Controls.Add(this.txtCiftToplam);
            this.tbCiftSayi.Controls.Add(this.lwCiftSayi);
            this.tbCiftSayi.Location = new System.Drawing.Point(4, 25);
            this.tbCiftSayi.Name = "tbCiftSayi";
            this.tbCiftSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tbCiftSayi.Size = new System.Drawing.Size(768, 293);
            this.tbCiftSayi.TabIndex = 1;
            this.tbCiftSayi.Text = "Çift Sayılar";
            this.tbCiftSayi.UseVisualStyleBackColor = true;
            // 
            // lblCiftCarpim
            // 
            this.lblCiftCarpim.AutoSize = true;
            this.lblCiftCarpim.Location = new System.Drawing.Point(235, 268);
            this.lblCiftCarpim.Name = "lblCiftCarpim";
            this.lblCiftCarpim.Size = new System.Drawing.Size(67, 17);
            this.lblCiftCarpim.TabIndex = 13;
            this.lblCiftCarpim.Text = "ÇARPIM :";
            // 
            // lblCiftToplam
            // 
            this.lblCiftToplam.AutoSize = true;
            this.lblCiftToplam.Location = new System.Drawing.Point(11, 268);
            this.lblCiftToplam.Name = "lblCiftToplam";
            this.lblCiftToplam.Size = new System.Drawing.Size(73, 17);
            this.lblCiftToplam.TabIndex = 12;
            this.lblCiftToplam.Text = "TOPLAM :";
            // 
            // txtCiftCarpim
            // 
            this.txtCiftCarpim.Location = new System.Drawing.Point(320, 265);
            this.txtCiftCarpim.Multiline = true;
            this.txtCiftCarpim.Name = "txtCiftCarpim";
            this.txtCiftCarpim.Size = new System.Drawing.Size(442, 22);
            this.txtCiftCarpim.TabIndex = 10;
            // 
            // txtCiftToplam
            // 
            this.txtCiftToplam.Location = new System.Drawing.Point(90, 263);
            this.txtCiftToplam.Name = "txtCiftToplam";
            this.txtCiftToplam.Size = new System.Drawing.Size(100, 22);
            this.txtCiftToplam.TabIndex = 11;
            // 
            // lwCiftSayi
            // 
            this.lwCiftSayi.HideSelection = false;
            this.lwCiftSayi.Location = new System.Drawing.Point(0, 0);
            this.lwCiftSayi.Name = "lwCiftSayi";
            this.lwCiftSayi.Size = new System.Drawing.Size(768, 254);
            this.lwCiftSayi.TabIndex = 1;
            this.lwCiftSayi.UseCompatibleStateImageBehavior = false;
            // 
            // tbAsalSayi
            // 
            this.tbAsalSayi.Controls.Add(this.lblAsalCarpim);
            this.tbAsalSayi.Controls.Add(this.lblAsalToplam);
            this.tbAsalSayi.Controls.Add(this.txtAsalCarpim);
            this.tbAsalSayi.Controls.Add(this.txtAsalToplam);
            this.tbAsalSayi.Controls.Add(this.lwAsalSayi);
            this.tbAsalSayi.Location = new System.Drawing.Point(4, 25);
            this.tbAsalSayi.Name = "tbAsalSayi";
            this.tbAsalSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tbAsalSayi.Size = new System.Drawing.Size(768, 293);
            this.tbAsalSayi.TabIndex = 2;
            this.tbAsalSayi.Text = "Asal Sayılar";
            this.tbAsalSayi.UseVisualStyleBackColor = true;
            // 
            // lblAsalCarpim
            // 
            this.lblAsalCarpim.AutoSize = true;
            this.lblAsalCarpim.Location = new System.Drawing.Point(235, 263);
            this.lblAsalCarpim.Name = "lblAsalCarpim";
            this.lblAsalCarpim.Size = new System.Drawing.Size(67, 17);
            this.lblAsalCarpim.TabIndex = 13;
            this.lblAsalCarpim.Text = "ÇARPIM :";
            // 
            // lblAsalToplam
            // 
            this.lblAsalToplam.AutoSize = true;
            this.lblAsalToplam.Location = new System.Drawing.Point(11, 263);
            this.lblAsalToplam.Name = "lblAsalToplam";
            this.lblAsalToplam.Size = new System.Drawing.Size(73, 17);
            this.lblAsalToplam.TabIndex = 12;
            this.lblAsalToplam.Text = "TOPLAM :";
            // 
            // txtAsalCarpim
            // 
            this.txtAsalCarpim.Location = new System.Drawing.Point(320, 260);
            this.txtAsalCarpim.Multiline = true;
            this.txtAsalCarpim.Name = "txtAsalCarpim";
            this.txtAsalCarpim.Size = new System.Drawing.Size(442, 22);
            this.txtAsalCarpim.TabIndex = 10;
            // 
            // txtAsalToplam
            // 
            this.txtAsalToplam.Location = new System.Drawing.Point(90, 258);
            this.txtAsalToplam.Name = "txtAsalToplam";
            this.txtAsalToplam.Size = new System.Drawing.Size(100, 22);
            this.txtAsalToplam.TabIndex = 11;
            // 
            // lwAsalSayi
            // 
            this.lwAsalSayi.HideSelection = false;
            this.lwAsalSayi.Location = new System.Drawing.Point(0, 0);
            this.lwAsalSayi.Name = "lwAsalSayi";
            this.lwAsalSayi.Size = new System.Drawing.Size(768, 254);
            this.lwAsalSayi.TabIndex = 1;
            this.lwAsalSayi.UseCompatibleStateImageBehavior = false;
            // 
            // tbArmstrongSayi
            // 
            this.tbArmstrongSayi.Controls.Add(this.lbArmstrongCarpim);
            this.tbArmstrongSayi.Controls.Add(this.lbArmstrongToplam);
            this.tbArmstrongSayi.Controls.Add(this.txtArmstrongCarpim);
            this.tbArmstrongSayi.Controls.Add(this.txtArmstrongToplam);
            this.tbArmstrongSayi.Controls.Add(this.lwArmstrongSayi);
            this.tbArmstrongSayi.Location = new System.Drawing.Point(4, 25);
            this.tbArmstrongSayi.Name = "tbArmstrongSayi";
            this.tbArmstrongSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tbArmstrongSayi.Size = new System.Drawing.Size(768, 293);
            this.tbArmstrongSayi.TabIndex = 3;
            this.tbArmstrongSayi.Text = "Armstrong Sayılar";
            this.tbArmstrongSayi.UseVisualStyleBackColor = true;
            // 
            // lbArmstrongCarpim
            // 
            this.lbArmstrongCarpim.AutoSize = true;
            this.lbArmstrongCarpim.Location = new System.Drawing.Point(232, 265);
            this.lbArmstrongCarpim.Name = "lbArmstrongCarpim";
            this.lbArmstrongCarpim.Size = new System.Drawing.Size(67, 17);
            this.lbArmstrongCarpim.TabIndex = 13;
            this.lbArmstrongCarpim.Text = "ÇARPIM :";
            // 
            // lbArmstrongToplam
            // 
            this.lbArmstrongToplam.AutoSize = true;
            this.lbArmstrongToplam.Location = new System.Drawing.Point(8, 265);
            this.lbArmstrongToplam.Name = "lbArmstrongToplam";
            this.lbArmstrongToplam.Size = new System.Drawing.Size(73, 17);
            this.lbArmstrongToplam.TabIndex = 12;
            this.lbArmstrongToplam.Text = "TOPLAM :";
            // 
            // txtArmstrongCarpim
            // 
            this.txtArmstrongCarpim.Location = new System.Drawing.Point(317, 262);
            this.txtArmstrongCarpim.Multiline = true;
            this.txtArmstrongCarpim.Name = "txtArmstrongCarpim";
            this.txtArmstrongCarpim.Size = new System.Drawing.Size(442, 22);
            this.txtArmstrongCarpim.TabIndex = 10;
            // 
            // txtArmstrongToplam
            // 
            this.txtArmstrongToplam.Location = new System.Drawing.Point(87, 260);
            this.txtArmstrongToplam.Name = "txtArmstrongToplam";
            this.txtArmstrongToplam.Size = new System.Drawing.Size(100, 22);
            this.txtArmstrongToplam.TabIndex = 11;
            // 
            // lwArmstrongSayi
            // 
            this.lwArmstrongSayi.HideSelection = false;
            this.lwArmstrongSayi.Location = new System.Drawing.Point(0, 0);
            this.lwArmstrongSayi.Name = "lwArmstrongSayi";
            this.lwArmstrongSayi.Size = new System.Drawing.Size(768, 254);
            this.lwArmstrongSayi.TabIndex = 0;
            this.lwArmstrongSayi.UseCompatibleStateImageBehavior = false;
            // 
            // ntfBildirim
            // 
            this.ntfBildirim.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfBildirim.BalloonTipText = "Calculator Loading...";
            this.ntfBildirim.BalloonTipTitle = "İşlem Başarılı";
            this.ntfBildirim.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfBildirim.Icon")));
            this.ntfBildirim.Text = "bildirim";
            this.ntfBildirim.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKontrol);
            this.Controls.Add(this.grpGirisBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.grpGirisBilgileri.ResumeLayout(false);
            this.grpGirisBilgileri.PerformLayout();
            this.tbTeksayi.ResumeLayout(false);
            this.tbTeksayi.PerformLayout();
            this.tbKontrol.ResumeLayout(false);
            this.tbCiftSayi.ResumeLayout(false);
            this.tbCiftSayi.PerformLayout();
            this.tbAsalSayi.ResumeLayout(false);
            this.tbAsalSayi.PerformLayout();
            this.tbArmstrongSayi.ResumeLayout(false);
            this.tbArmstrongSayi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGirisBilgileri;
        private System.Windows.Forms.MaskedTextBox mtxtBaslangic;
        private System.Windows.Forms.MaskedTextBox mtxtBitis;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.TabPage tbTeksayi;
        private System.Windows.Forms.Label lblTekCarpim;
        private System.Windows.Forms.Label lblTekToplam;
        private System.Windows.Forms.TextBox txtTekCarpim;
        private System.Windows.Forms.TextBox txtTekToplam;
        private System.Windows.Forms.ListView lwTeksayi;
        private System.Windows.Forms.TabControl tbKontrol;
        private System.Windows.Forms.TabPage tbCiftSayi;
        private System.Windows.Forms.Label lblCiftCarpim;
        private System.Windows.Forms.Label lblCiftToplam;
        private System.Windows.Forms.TextBox txtCiftCarpim;
        private System.Windows.Forms.TextBox txtCiftToplam;
        private System.Windows.Forms.ListView lwCiftSayi;
        private System.Windows.Forms.TabPage tbAsalSayi;
        private System.Windows.Forms.Label lblAsalCarpim;
        private System.Windows.Forms.Label lblAsalToplam;
        private System.Windows.Forms.TextBox txtAsalCarpim;
        private System.Windows.Forms.TextBox txtAsalToplam;
        private System.Windows.Forms.ListView lwAsalSayi;
        private System.Windows.Forms.TabPage tbArmstrongSayi;
        private System.Windows.Forms.Label lbArmstrongCarpim;
        private System.Windows.Forms.Label lbArmstrongToplam;
        private System.Windows.Forms.TextBox txtArmstrongCarpim;
        private System.Windows.Forms.TextBox txtArmstrongToplam;
        private System.Windows.Forms.ListView lwArmstrongSayi;
        private System.Windows.Forms.NotifyIcon ntfBildirim;
    }
}

