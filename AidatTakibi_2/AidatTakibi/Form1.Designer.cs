namespace AidatTakibi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aileAdi = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.TextBox();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.gsmNo = new System.Windows.Forms.TextBox();
            this.KaydetHane = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AidatTxt = new System.Windows.Forms.TextBox();
            this.dogalgazFiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kisiBasiBorc = new System.Windows.Forms.TextBox();
            this.HesaplaBorc = new System.Windows.Forms.Button();
            this.BorcuAta = new System.Windows.Forms.Button();
            this.temizleHane = new System.Windows.Forms.Button();
            this.temizleBorcHesap = new System.Windows.Forms.Button();
            this.yilSec = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.aySec = new System.Windows.Forms.ComboBox();
            this.BorcDurum = new System.Windows.Forms.DataGridView();
            this.Hane_Bilgileri = new System.Windows.Forms.DataGridView();
            this.BorcDonemi = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.daireNo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.borcDonemSec = new System.Windows.Forms.ComboBox();
            this.Borc_Ode = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.daireNoSec = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.KisiBorcDurum = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BorcDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hane_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorcDonemi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KisiBorcDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hane Bilgileri Girme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ailenin Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(59, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(31, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "GSM No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(15, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Daire No:";
            // 
            // aileAdi
            // 
            this.aileAdi.Location = new System.Drawing.Point(99, 48);
            this.aileAdi.Margin = new System.Windows.Forms.Padding(4);
            this.aileAdi.Name = "aileAdi";
            this.aileAdi.Size = new System.Drawing.Size(209, 22);
            this.aileAdi.TabIndex = 6;
            // 
            // adi
            // 
            this.adi.Location = new System.Drawing.Point(99, 76);
            this.adi.Margin = new System.Windows.Forms.Padding(4);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(209, 22);
            this.adi.TabIndex = 7;
            // 
            // soyadi
            // 
            this.soyadi.Location = new System.Drawing.Point(99, 108);
            this.soyadi.Margin = new System.Windows.Forms.Padding(4);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(209, 22);
            this.soyadi.TabIndex = 8;
            // 
            // gsmNo
            // 
            this.gsmNo.Location = new System.Drawing.Point(99, 139);
            this.gsmNo.Margin = new System.Windows.Forms.Padding(4);
            this.gsmNo.Name = "gsmNo";
            this.gsmNo.Size = new System.Drawing.Size(209, 22);
            this.gsmNo.TabIndex = 9;
            // 
            // KaydetHane
            // 
            this.KaydetHane.BackColor = System.Drawing.SystemColors.WindowText;
            this.KaydetHane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydetHane.ForeColor = System.Drawing.SystemColors.Window;
            this.KaydetHane.Location = new System.Drawing.Point(162, 202);
            this.KaydetHane.Margin = new System.Windows.Forms.Padding(4);
            this.KaydetHane.Name = "KaydetHane";
            this.KaydetHane.Size = new System.Drawing.Size(148, 37);
            this.KaydetHane.TabIndex = 11;
            this.KaydetHane.Text = "Kaydet/Güncelle";
            this.KaydetHane.UseVisualStyleBackColor = false;
            this.KaydetHane.Click += new System.EventHandler(this.KaydetHane_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(1, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Aidat Borcu Atama/Hesapla";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(1, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hane Başı Ödenecek Ücret:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(27, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Toplam Doğalgaz Ücreti:";
            // 
            // AidatTxt
            // 
            this.AidatTxt.Location = new System.Drawing.Point(241, 47);
            this.AidatTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AidatTxt.Name = "AidatTxt";
            this.AidatTxt.Size = new System.Drawing.Size(188, 22);
            this.AidatTxt.TabIndex = 15;
            // 
            // dogalgazFiyat
            // 
            this.dogalgazFiyat.Location = new System.Drawing.Point(241, 80);
            this.dogalgazFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.dogalgazFiyat.Name = "dogalgazFiyat";
            this.dogalgazFiyat.Size = new System.Drawing.Size(188, 22);
            this.dogalgazFiyat.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(28, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Kişi Başına Düşen Borç:";
            // 
            // kisiBasiBorc
            // 
            this.kisiBasiBorc.Location = new System.Drawing.Point(241, 114);
            this.kisiBasiBorc.Margin = new System.Windows.Forms.Padding(4);
            this.kisiBasiBorc.Name = "kisiBasiBorc";
            this.kisiBasiBorc.Size = new System.Drawing.Size(188, 22);
            this.kisiBasiBorc.TabIndex = 18;
            // 
            // HesaplaBorc
            // 
            this.HesaplaBorc.BackColor = System.Drawing.SystemColors.WindowText;
            this.HesaplaBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HesaplaBorc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HesaplaBorc.Location = new System.Drawing.Point(181, 199);
            this.HesaplaBorc.Margin = new System.Windows.Forms.Padding(4);
            this.HesaplaBorc.Name = "HesaplaBorc";
            this.HesaplaBorc.Size = new System.Drawing.Size(100, 39);
            this.HesaplaBorc.TabIndex = 19;
            this.HesaplaBorc.Text = "Hesapla";
            this.HesaplaBorc.UseVisualStyleBackColor = false;
            this.HesaplaBorc.Click += new System.EventHandler(this.HesaplaBorc_Click);
            // 
            // BorcuAta
            // 
            this.BorcuAta.BackColor = System.Drawing.SystemColors.ControlText;
            this.BorcuAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BorcuAta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorcuAta.Location = new System.Drawing.Point(289, 199);
            this.BorcuAta.Margin = new System.Windows.Forms.Padding(4);
            this.BorcuAta.Name = "BorcuAta";
            this.BorcuAta.Size = new System.Drawing.Size(140, 39);
            this.BorcuAta.TabIndex = 20;
            this.BorcuAta.Text = "Borcu Ata";
            this.BorcuAta.UseVisualStyleBackColor = false;
            this.BorcuAta.Click += new System.EventHandler(this.BorcuAta_Click);
            // 
            // temizleHane
            // 
            this.temizleHane.BackColor = System.Drawing.SystemColors.WindowText;
            this.temizleHane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleHane.ForeColor = System.Drawing.SystemColors.Window;
            this.temizleHane.Location = new System.Drawing.Point(8, 203);
            this.temizleHane.Margin = new System.Windows.Forms.Padding(4);
            this.temizleHane.Name = "temizleHane";
            this.temizleHane.Size = new System.Drawing.Size(146, 36);
            this.temizleHane.TabIndex = 22;
            this.temizleHane.Text = "Temizle";
            this.temizleHane.UseVisualStyleBackColor = false;
            this.temizleHane.Click += new System.EventHandler(this.temizleHane_Click);
            // 
            // temizleBorcHesap
            // 
            this.temizleBorcHesap.BackColor = System.Drawing.SystemColors.WindowText;
            this.temizleBorcHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleBorcHesap.ForeColor = System.Drawing.SystemColors.Window;
            this.temizleBorcHesap.Location = new System.Drawing.Point(73, 199);
            this.temizleBorcHesap.Margin = new System.Windows.Forms.Padding(4);
            this.temizleBorcHesap.Name = "temizleBorcHesap";
            this.temizleBorcHesap.Size = new System.Drawing.Size(100, 38);
            this.temizleBorcHesap.TabIndex = 23;
            this.temizleBorcHesap.Text = "Temizle";
            this.temizleBorcHesap.UseVisualStyleBackColor = false;
            this.temizleBorcHesap.Click += new System.EventHandler(this.temizleBorcHesap_Click);
            // 
            // yilSec
            // 
            this.yilSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yilSec.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.yilSec.FormattingEnabled = true;
            this.yilSec.Location = new System.Drawing.Point(307, 158);
            this.yilSec.Margin = new System.Windows.Forms.Padding(4);
            this.yilSec.Name = "yilSec";
            this.yilSec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yilSec.Size = new System.Drawing.Size(123, 24);
            this.yilSec.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(267, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Yıl:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(109, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ay:";
            // 
            // aySec
            // 
            this.aySec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aySec.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aySec.Location = new System.Drawing.Point(151, 158);
            this.aySec.Margin = new System.Windows.Forms.Padding(4);
            this.aySec.Name = "aySec";
            this.aySec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aySec.Size = new System.Drawing.Size(107, 24);
            this.aySec.TabIndex = 27;
            // 
            // BorcDurum
            // 
            this.BorcDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorcDurum.Location = new System.Drawing.Point(13, 500);
            this.BorcDurum.Margin = new System.Windows.Forms.Padding(4);
            this.BorcDurum.Name = "BorcDurum";
            this.BorcDurum.Size = new System.Drawing.Size(1129, 162);
            this.BorcDurum.TabIndex = 29;
            // 
            // Hane_Bilgileri
            // 
            this.Hane_Bilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hane_Bilgileri.Location = new System.Drawing.Point(13, 313);
            this.Hane_Bilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.Hane_Bilgileri.Name = "Hane_Bilgileri";
            this.Hane_Bilgileri.Size = new System.Drawing.Size(776, 149);
            this.Hane_Bilgileri.TabIndex = 31;
            this.Hane_Bilgileri.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Hane_Bilgileri_RowEnter);
            // 
            // BorcDonemi
            // 
            this.BorcDonemi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorcDonemi.Location = new System.Drawing.Point(792, 39);
            this.BorcDonemi.Margin = new System.Windows.Forms.Padding(4);
            this.BorcDonemi.Name = "BorcDonemi";
            this.BorcDonemi.Size = new System.Drawing.Size(351, 214);
            this.BorcDonemi.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(787, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "Borç Dönemleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.daireNo);
            this.panel1.Controls.Add(this.temizleHane);
            this.panel1.Controls.Add(this.KaydetHane);
            this.panel1.Controls.Add(this.gsmNo);
            this.panel1.Controls.Add(this.soyadi);
            this.panel1.Controls.Add(this.adi);
            this.panel1.Controls.Add(this.aileAdi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 249);
            this.panel1.TabIndex = 36;
            // 
            // daireNo
            // 
            this.daireNo.Location = new System.Drawing.Point(99, 174);
            this.daireNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daireNo.Name = "daireNo";
            this.daireNo.Size = new System.Drawing.Size(209, 22);
            this.daireNo.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.aySec);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.yilSec);
            this.panel2.Controls.Add(this.temizleBorcHesap);
            this.panel2.Controls.Add(this.BorcuAta);
            this.panel2.Controls.Add(this.HesaplaBorc);
            this.panel2.Controls.Add(this.kisiBasiBorc);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dogalgazFiyat);
            this.panel2.Controls.Add(this.AidatTxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(333, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 247);
            this.panel2.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(8, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 25);
            this.label14.TabIndex = 38;
            this.label14.Text = "Hane Bilgileri";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(8, 473);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 25);
            this.label15.TabIndex = 39;
            this.label15.Text = "Tüm Borç Bilgileri";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.borcDonemSec);
            this.panel3.Controls.Add(this.Borc_Ode);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.daireNoSec);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(849, 313);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 149);
            this.panel3.TabIndex = 40;
            // 
            // borcDonemSec
            // 
            this.borcDonemSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borcDonemSec.FormattingEnabled = true;
            this.borcDonemSec.Location = new System.Drawing.Point(151, 73);
            this.borcDonemSec.Margin = new System.Windows.Forms.Padding(4);
            this.borcDonemSec.Name = "borcDonemSec";
            this.borcDonemSec.Size = new System.Drawing.Size(131, 24);
            this.borcDonemSec.TabIndex = 49;
            // 
            // Borc_Ode
            // 
            this.Borc_Ode.BackColor = System.Drawing.SystemColors.WindowText;
            this.Borc_Ode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Borc_Ode.ForeColor = System.Drawing.SystemColors.Window;
            this.Borc_Ode.Location = new System.Drawing.Point(9, 105);
            this.Borc_Ode.Margin = new System.Windows.Forms.Padding(4);
            this.Borc_Ode.Name = "Borc_Ode";
            this.Borc_Ode.Size = new System.Drawing.Size(265, 37);
            this.Borc_Ode.TabIndex = 48;
            this.Borc_Ode.Text = "Borcu Öde";
            this.Borc_Ode.UseVisualStyleBackColor = false;
            this.Borc_Ode.Click += new System.EventHandler(this.Borc_Ode_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(7, 74);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 20);
            this.label19.TabIndex = 44;
            this.label19.Text = "Borç Dönemleri:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.Window;
            this.label17.Location = new System.Drawing.Point(5, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 20);
            this.label17.TabIndex = 42;
            this.label17.Text = "Daire Numarası:";
            // 
            // daireNoSec
            // 
            this.daireNoSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daireNoSec.FormattingEnabled = true;
            this.daireNoSec.Location = new System.Drawing.Point(151, 41);
            this.daireNoSec.Margin = new System.Windows.Forms.Padding(4);
            this.daireNoSec.Name = "daireNoSec";
            this.daireNoSec.Size = new System.Drawing.Size(131, 24);
            this.daireNoSec.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(3, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 25);
            this.label16.TabIndex = 41;
            this.label16.Text = "Borç Ödeme";
            // 
            // KisiBorcDurum
            // 
            this.KisiBorcDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KisiBorcDurum.Location = new System.Drawing.Point(13, 713);
            this.KisiBorcDurum.Margin = new System.Windows.Forms.Padding(4);
            this.KisiBorcDurum.Name = "KisiBorcDurum";
            this.KisiBorcDurum.Size = new System.Drawing.Size(1129, 145);
            this.KisiBorcDurum.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(12, 684);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 25);
            this.label18.TabIndex = 42;
            this.label18.Text = "Kişi Borç Bilgileri";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(197, 686);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(520, 20);
            this.label20.TabIndex = 43;
            this.label20.Text = "(Hane Bilgilerinden seçtiğiniz kişinin tüm borç bilgilerini getirecektir.)\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1736, 922);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.KisiBorcDurum);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BorcDonemi);
            this.Controls.Add(this.Hane_Bilgileri);
            this.Controls.Add(this.BorcDurum);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bayındır Apartmanı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BorcDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hane_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorcDonemi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KisiBorcDurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aileAdi;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox gsmNo;
        private System.Windows.Forms.Button KaydetHane;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AidatTxt;
        private System.Windows.Forms.TextBox dogalgazFiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox kisiBasiBorc;
        private System.Windows.Forms.Button HesaplaBorc;
        private System.Windows.Forms.Button BorcuAta;
        private System.Windows.Forms.Button temizleHane;
        private System.Windows.Forms.Button temizleBorcHesap;
        private System.Windows.Forms.ComboBox yilSec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox aySec;
        private System.Windows.Forms.DataGridView BorcDurum;
        private System.Windows.Forms.DataGridView Hane_Bilgileri;
        private System.Windows.Forms.DataGridView BorcDonemi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Borc_Ode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox daireNoSec;
        private System.Windows.Forms.ComboBox borcDonemSec;
        private System.Windows.Forms.TextBox daireNo;
        private System.Windows.Forms.DataGridView KisiBorcDurum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
    }
}

