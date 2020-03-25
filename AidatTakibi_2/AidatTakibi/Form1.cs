/***********************************************************************************************************************************************
 *                                                                               SAKARYA ÜNİVERSİTESİ                                         **                  
 *                                                                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                             **    
 *                                                                       BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                               **       
 *                                                                         NESNEYE DAYALI PROGRAMLAMA DERSİ                                   **     
 *                                                                             2019-2020 BAHAR DÖNEMİ                                         **  
 *                                                                                                                                            **
 *                                                                                                                                            **
 *                                                                      ÖDEV NUMARASI..........: 1                                            **    
 *                                                                      ÖĞRENCİ ADI............: Mertcan Karakaya                             **    
 *                                                                      ÖĞRENCİ NUMARASI.......: B161200021                                   **                         
 *                                                                      DERSİN ALINDIĞI GRUP...: A                                            **          
 **********************************************************************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using AidatTakibi.MyClass;

namespace AidatTakibi
{


    public partial class Form1 : Form
    {
        //Sınıfımdan bir nesne yarattım.
        AidatTakipleri aidatTakip = new AidatTakipleri();

        public Form1()
        {
            InitializeComponent();
        }

        //Hane Başına düşen borç ücretini hesaplamak için böyle bir method oluşturdum.
        //İçerisinde Toplam doğalgaz ücreti (Hane sayisina bölünecek bu yüzden daire Sayisi lazım), Hane başına ödenecek aidat ücreti gerekli.
        public double BorcHesapla(double dogalgaz, double aidat, int daireSayisi)
        {
            //gerekli bilgileri textbox'tan aldım.
            dogalgaz = Convert.ToDouble(dogalgazFiyat.Text);
            aidat = Convert.ToDouble(this.AidatTxt.Text);
            //Ücreti atamak için bir değişken tanımladım.
            double kisiBasiUcret;
            //Kişi Başı ücreti hesaplattım.
            kisiBasiUcret = (dogalgaz / daireSayisi) + aidat;
            //Virgülden sonra 2 birim alacak şekilde değer döndürdüm.
            return Math.Round(kisiBasiUcret, 2);
        }
        #region |Hane Bilgi Girme|

        //Her Kaydet butonuna basınca çalışacaktır.
        private void KaydetHane_Click(object sender, EventArgs e)
        {
            //Aşağıdaki methodların ne işe yaradığını "ctrl+click" yaparak gidip görebilirsiniz.
            HaneEkle();
            HaneOku();
            //Her Kaydet dediğimde daireNoSec getir combobox'ına yeni daire eklenmeli.
            daireNoSec.DataSource = aidatTakip.daireNoSecGetir();
        }

        //Formdaki textbox'ları temizlemesi için yazıldı.
        private void temizleHane_Click(object sender, EventArgs e)
        {

            aileAdi.Text = "";
            adi.Text = "";
            soyadi.Text = "";
            gsmNo.Text = "";
            daireNo.Text = "";

        }

        //Bu methodu Hane Bilgilerini oluşturulan nesnedeki ilgili değerlere Textbox'tan alıp atama yapması için oluşturdum.
        public void HaneEkle()
        {
            //Textbox'lardan okuduklarını Crud nesnesindeki ilgili alana atama yapıyor.
            aidatTakip.DaireNo = Convert.ToInt32(daireNo.Text);
            aidatTakip.AileAdi = aileAdi.Text;
            aidatTakip.Adi = adi.Text;
            aidatTakip.Soyadi = soyadi.Text;
            aidatTakip.GsmNo = gsmNo.Text;

            bool var = false;
            //Hane Bilgilerinin olduğu tablodaki daire no bilgilerini gezip textbox'daki değerin olup olmadığını döndürmek için yazdım.
            foreach (DataGridViewRow row in Hane_Bilgileri.Rows)
            {
                //Tablonun 1. sütunundaki değer daireNo nesnesinin içindeki değere eşit olduğunda var anlamına gelsin diye yazdım.
                if (row.Cells[1].Value.ToString() == aidatTakip.DaireNo.ToString())
                {
                    var = true;
                }

            }

            if (var == true)
            {
                //Var olduğunda o dairenin değerindeki satırı textbox'dan gelen nesnelerin içindeki değerlerle güncellesin diye yazdığım methodu kullandım.
                HaneGuncelle();
            }
            else
            {
                //O daire numarası yok ise yenisi ekleyecek.
                //Bunun içinde yine sınıfımda oluşturduğum aşağıdaki meyhod'u kullandım.
                //Bu method veritabanında ilgili tabloya ekleme yapıyor.
                aidatTakip.Ekle_Hane();

            }
        }

        //Hane Bilgilerini güncelleme işini yapıyor.
        //Textbox'lardan aldığı verileri nesnedeki ilgili alanlara atıyor.
        public void HaneGuncelle()
        {
            aidatTakip.DaireNo = Convert.ToInt32(daireNo.Text);
            aidatTakip.AileAdi = aileAdi.Text;
            aidatTakip.Adi = adi.Text;
            aidatTakip.Soyadi = soyadi.Text;
            aidatTakip.GsmNo = gsmNo.Text;
            //Eğer işlem gerçekleşirse method true dönüyordu. Bu da güncelleme yaptığını gösterir.
            //Güncellendiğinde de mesaj döndürsün diye yazıldı.
            if (aidatTakip.Guncelle_Hane())
            {
                MessageBox.Show("Hane Bilgileri Güncellendi. !");
                //Güncelleme yapınca tekrar hane bilgilerini okuyup formdaki tabloyu güncellemesi gerekiyor.
                HaneOku();
            }

        }

        //Hane Bilgilerini veritabanından okuyup ilgili DataGridView'e atıyor.
        public void HaneOku()
        {
            //Hane_bilgileri DataGridView'in veri kaynağını null olarak atadım.
            Hane_Bilgileri.DataSource = null;
            //Daha sonra sınıfımda tanımladığım Oku_Hane methodu ile veritabanından ilgili yeri okuyup datatable'ına atama yapıyor.
            aidatTakip.Oku_Hane();
            Hane_Bilgileri.DataSource = aidatTakip.hanedt;
            //Tablonun ilk sütunu gözükmesin diye yazdım. Çünkü ilk sütunda id'ler var. Yöneticinin id'ler ile işi yok.
            Hane_Bilgileri.Columns[0].Visible = false;
            //Tablonun başındaki boşluk gözükmesin diye kullandık.
            Hane_Bilgileri.RowHeadersVisible = false;
            //Verileri tabloya sığdırmak için kullandık.
            Hane_Bilgileri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion
        #region |Aidat Borcu Atama/Hesapla|


        private void HesaplaBorc_Click(object sender, EventArgs e)
        {
            //Hesaplaya basınca çalışacak.
            //Borç Hesaplama yaparken lazım olan bilgileri oluşturulan nesnenin ilgili alanlarına atadık.
            int dairesayisi = Hane_Bilgileri.RowCount;
            double dogalgaz = Convert.ToDouble(dogalgazFiyat.Text);
            double aidat = Convert.ToDouble(AidatTxt.Text);
            kisiBasiBorc.Text = Convert.ToString(BorcHesapla(dogalgaz, aidat, dairesayisi));
        }

        //Borç Dönem bilgilerini veritabanından okuyup ilgili DataGridView'e atıyor.
        public void BorcDonemOku()
        {
            //BorcDonemi DataGridView'in veri kaynağını null olarak atadım.
            BorcDonemi.DataSource = null;
            //Daha sonra sınıfımda tanımladığım Oku_Borc methodu ile veritabanından ilgili yeri okuyup datatable'ına atama yapıyor.
            aidatTakip.Oku_Borc();
            BorcDonemi.DataSource = aidatTakip.borcdt;
            //Tablonun ilk sütunu gözükmesin diye yazdım. Çünkü ilk sütunda id'ler var. Yöneticinin id'ler ile işi yok.
            BorcDonemi.Columns[0].Visible = false;
            //Tablonun başındaki boşluk gözükmesin diye kullandık.
            BorcDonemi.RowHeadersVisible = false;
            //Verileri tabloya sığdırmak için kullandık.
            BorcDonemi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        //Veritabanındaki borc_bilgisi tablosuna yeni borç dönemleri ve miktarlarını girdirmek için böyle bir method yazdım.        
        public bool BorcEkle()
        {
            //Kişi başına düşen borcu hesaplaması için aşağıdaki ilgili değerler alındı.
            int dairesayisi = Hane_Bilgileri.RowCount;
            double dogalgaz = Convert.ToDouble(dogalgazFiyat.Text);
            double aidat = Convert.ToDouble(AidatTxt.Text);
            double borcmiktar = BorcHesapla(dogalgaz, aidat, dairesayisi);
            //borc_bilgisi tablosuna eklme yapması için aşağıdaki ilgili değerler Textbox'tan alındı.
            string borc_donem = aySec.Text + "/" + yilSec.Text;
            aidatTakip.borcunDonemi = borc_donem;
            aidatTakip.borcMiktari = borcmiktar.ToString();

            //içerisinde değerin olup olmadığını anlayabilmek için değişken oluşturdum.
            bool borcVarMi = false;
            bool var = false;
            //Borç Dönemi tablosundaki değerleri tek tek dönsün diye tanımladım.
            foreach (DataGridViewRow row in BorcDonemi.Rows)
            {
                //Eğer tablonun içerisindeki değerlerden biri nesnenin içerisindeki borcun dönemi bilgisine eşit ise var true dönsün. Anlayalım diye yazdım.
                if (row.Cells[1].Value.ToString() == aidatTakip.borcunDonemi)
                {
                    var = true;
                }

            }
            //Eğer o borç dönemi var ise Message versin.
            if (var == true)
            {
                //Borç var olduğunda aşağıdaki değer true'ya dönsün ki o dönemi tüm hanelere atama yapmayalım.
                borcVarMi = true;
                MessageBox.Show("Zaten bu döneme borç eklenmiş. Başka bir dönem seçiniz...");
            }
            else
            {
                //Eğer bu dönem yoksa da borcu tüm dairelere verecek şekilde ekleme yapsın.
                //Bu ekleme işlemi için sınıfımda bir method oluşturdum.
                //Bu method veritabanındaki ilgili tabloya ekleme yapıyor.
                //Eğer ekleme methodu true döndürürse işlem başarılıdır ve bir Message döndürdüm.
                if (aidatTakip.Ekle_Borc())
                {
                    MessageBox.Show("Borç Başarılı bir şekilde eklendi.!");
                    //ekleme işlemi yapıldığı için Boç Dönemi tablosu yeniden okunup tabloya yazdırılacak.
                    //O yüzden bu methodu çağırdım.
                    BorcDonemOku();
                }
            }
            return borcVarMi;
        }
        //Bu method da ise aile_borc_bilgi kısmına ödeme yapıp yapmadığı ve ödemenin tarihi bilgileri eklenmesi için yazıldı.
        public void OdemeBilgiEkle()
        {

            //Eğer borc ekle methodu false değeri döndürürse yeni dönem eklenmiş anlamına gelmekte.
            //Yeni bönem eklendiyse o döneme bağlı tüm hane sahiplerine borç atanacaktır.
            if (BorcEkle() == false)
            {
                //Borcu tüm dairelere atama işlemi yaparken bana bir boc_id ve aile_bilgi_id lazım olacak.
                //Çünkü bunu ilişkili bir tabloya atıyoruz.
                //borc_id benim borç dönemlerindeki son eklenen verinin id'si olacak o yüzden aşağıdakini yazdım.
                int borc_id = Convert.ToInt32(BorcDonemi.Rows[BorcDonemi.RowCount - 1].Cells[0].Value);
                //bunu da ilgili nesneye atadım.
                aidatTakip.BorcID = borc_id;
                //Sonra bunun tek tek atama yapması için 0'dan başlatıp Hane bilgisi tablosunun uzunluğuna kadar döndürdüm.
                for (int i = 0; i < Hane_Bilgileri.RowCount; i++)
                {
                    //Hane_Bilgileri tablosundaki 0.Sütun(id bilgilerinin olduğu sütun) daki bilgi i. satırdaki değeri alıp nesnedeki ilgili alana atıyorum.
                    aidatTakip.AileBilgiID = Convert.ToInt32(Hane_Bilgileri.Rows[i].Cells[0].Value);
                    //Sınıftaki ilgili metodda ekleme yapıyor. Nasıl yaptığını methoda girip görebilirsiniz.
                    aidatTakip.Ekle_Hane_Borc();
                }
            }
        }

        //Formdaki textbox'ları temizlemesi için yazıldı.
        private void temizleBorcHesap_Click(object sender, EventArgs e)
        {
            dogalgazFiyat.Text = "";
            kisiBasiBorc.Text = "";
            AidatTxt.Text = "";
        }


        private void BorcuAta_Click(object sender, EventArgs e)
        {
            //Borc Ata butonuna basınca çalışacak.
            //Aşağıdaki methodlar çalışmalı ne işe yaradığını methodlara giderek görebilirsiniz.
            OdemeBilgiEkle();
            HaneBorcDurumOku();
            KisiBorcDurumOku();
            borcDonemSec.DataSource = aidatTakip.BorcDonemSecGetir();
        }

        #endregion
        #region |Borç Ödeme|

        //Tüm borç bilgilerini veritabanından okuyup ilgili DataGridView'e atıyor.
        public void HaneBorcDurumOku()
        {
            //BorcDonemi DataGridView'in veri kaynağını null olarak atadım.
            BorcDurum.DataSource = null;
            //Daha sonra sınıfımda tanımladığım Oku_Borc methodu ile veritabanından ilgili yeri okuyup datatable'ına atama yapıyor.
            aidatTakip.Oku_Hane_Borc();
            BorcDurum.DataSource = aidatTakip.haneBorcdt;
            //Tablonun başındaki boşluk gözükmesin diye kullandık.
            BorcDurum.RowHeadersVisible = false;
            //Verileri tabloya sığdırmak için kullandık.
            BorcDurum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Kişi borç bilgilerini veritabanından okuyup ilgili DataGridView'e atıyor.
        public void KisiBorcDurumOku()
        {
            //BorcDonemi DataGridView'in veri kaynağını null olarak atadım.
            KisiBorcDurum.DataSource = null;
            //Daha sonra sınıfımda tanımladığım Oku_Borc methodu ile veritabanından ilgili yeri okuyup datatable'ına atama yapıyor.
            aidatTakip.Oku_Hane_Borc();
            KisiBorcDurum.DataSource = aidatTakip.kisiHaneBorcdt;
            //Tablonun başındaki boşluk gözükmesin diye kullandık.
            KisiBorcDurum.RowHeadersVisible = false;
            //Verileri tabloya sığdırmak için kullandık.
            KisiBorcDurum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Bu methodda aile_bilgi ve borc_bilgisi id'lerine göre ilgili veriyi aile_borc_bilgi tablosundan çağırıp ödeme bilgilerini güncelleme yapsın diye yazdım.
        public void BorcOde()
        {
            //Değerleri combobox'lardan alıp ona göre ilgili id verilerini getireceğim.
            //O yüzden değerleri alıp nesnenin ilgili alanlarına atama işlemi yaptım.
            aidatTakip.borcunDonemi = borcDonemSec.Text;
            aidatTakip.DaireNo = Convert.ToInt32(daireNoSec.Text);
            //ID bilgilerini almak için int bir değişken tanımladım. Başlangıç değeri atamak zorundaydım o yüzden -1 tanımladım.
            //ID -1 değer alamayacağı için.
            int aile_bilgi_id = -1;
            int borc_bilgi_id = -1;
            //Yeni kayıt eklenemesin yaparak sondaki sütunu boşlatmış oldum.
            BorcDonemi.AllowUserToAddRows = false;

            //0'dan başlatıp hane bilgilerinin uzunluğu kadar döndürüp id değerini aldık.
            for (int i = 0; i < Hane_Bilgileri.RowCount; i++)
            {
                //Verilen daire numarasıyla tablodaki daire numarası eşit olduğunda tablodaki ID bilgisini bir değişkene atadık.
                //O değişkeni sorguya gönderirken kullanacağım.
                if (Convert.ToInt32(Hane_Bilgileri.Rows[i].Cells[1].Value) == aidatTakip.DaireNo)
                {
                    aile_bilgi_id = Convert.ToInt32(Hane_Bilgileri.Rows[i].Cells[0].Value);
                    //Nesnedeki ilgili alana atadık.
                    aidatTakip.AileBilgiID = aile_bilgi_id;
                }

            }

            //0'dan başlatıp borç dönem bilgisinin uzunluğu kadar döndürüp id değerini aldık.
            for (int i = 0; i < BorcDonemi.RowCount; i++)
            {
                //Verilen borc dönemi tablodaki borc dönemine eşit olduğunda tablodaki ID bilgisini bir değişkene atadık.
                //O değişkeni sorguya gönderirken kullanacağım.
                if (BorcDonemi.Rows[i].Cells[1].Value.ToString() == aidatTakip.borcunDonemi.ToString())
                {
                    borc_bilgi_id = Convert.ToInt32(BorcDonemi.Rows[i].Cells[0].Value);
                    //Nesnedeki ilgili alana atadık.
                    aidatTakip.BorcID = borc_bilgi_id;
                }

            }
            //Hiç değer almazsa böyle bir MessageBox göndersin diye yazdım. Değer alırsa da o değerlerle güncelleme yapsın.
            if (aile_bilgi_id == -1 && borc_bilgi_id == -1)
            {
                MessageBox.Show("Lütfen Borç dönemi mevcut olan bir dönem giriniz");
            }
            else
            {
                //Değer aldığında da güncelleme yapacak.
                //Sınıfımızdan ilgili methodu çağırarak Borç durumunu "Ödendi" ve ödeme tarihini bu günün tarihi yaptık.
                //Sonra bilgi mesajı döndürdük.
                if (aidatTakip.Guncelle_Borc())
                {
                    MessageBox.Show("Borç Başarılı bir şekilde ödendi.!");
                }
            }
        }

        private void Borc_Ode_Click(object sender, EventArgs e)
        {
            //Aşağıdaki methodlar çalışmalı ne işe yaradığını methodlara giderek görebilirsiniz.
            BorcOde();
            HaneBorcDurumOku();
            KisiBorcDurumOku();
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //Borç Ödeme kısmındaki daire numarası seçtiğimiz combobox'a seçilecek verileri yazdığım methoddan alsın diye yazdım.
            daireNoSec.DataSource = aidatTakip.daireNoSecGetir();
            //Borç Ödeme kısmındaki borç dönemi seçtiğimiz combobox'a seçilecek verileri yazdığım methoddan alsın diye yazdım.
            borcDonemSec.DataSource = aidatTakip.BorcDonemSecGetir();
            //Aşağıdaki methodlar başlangıçta çalışsın diye tanımlandı.
            //Methodalara giderek ne işe yaradığına bakabilirsiniz.
            HaneOku();
            BorcDonemOku();
            HaneBorcDurumOku();
            //Yeni kayıt eklenemesin yaparak sondaki sütunu boşlatmış oldum.
            Hane_Bilgileri.AllowUserToAddRows = false;
            //Yeni kayıt eklenemesin yaparak sondaki sütunu boşlatmış oldum.
            BorcDonemi.AllowUserToAddRows = false;
            //Yeni kayıt eklenemesin yaparak sondaki sütunu boşlatmış oldum.
            BorcDurum.AllowUserToAddRows = false;
            //Yeni kayıt eklenemesin yaparak sondaki sütunu boşlatmış oldum.
            KisiBorcDurum.AllowUserToAddRows = false;
            //Aidat Borç Atama/Hesapla kısmındaki yıl ve ay seçme bölümüme seçenekleri atadım.
            string[] Yillar = { "2019", "2020", "2021" };
            string[] Aylar = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            //kisiBasiBorc textbox'ı hep kapalı kalsın diye yazdım. Çünkü o bilgi de oynama yapılmamalı.
            kisiBasiBorc.Enabled = false;
            //Yukarıdaki değerleri yilSec combobox'ını içerisine atadım.
            yilSec.Items.AddRange(Yillar);
            //Yukarıdaki değerleri aySec combobox'ını içerisine atadım.
            aySec.Items.AddRange(Aylar);
        }

        //Hane_Bilgileri DataGridView'e tıklandığında çalışacak.
        private void Hane_Bilgileri_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //seçilen index'i döndürmesi için değişken tanımladım.
            int index = e.RowIndex;
            //seçilen indexteki tüm satırı seçsin diye tanımladı.
            Hane_Bilgileri.Rows[index].Selected = true;
            //seçilen satırdaki ilgili bilgileri sütunlarına göre textbox'ları doldursun diye atama yaptım.
            daireNo.Text = (Hane_Bilgileri.Rows[index].Cells[1].Value.ToString());
            aileAdi.Text = (Hane_Bilgileri.Rows[index].Cells[2].Value.ToString());
            adi.Text = (Hane_Bilgileri.Rows[index].Cells[3].Value.ToString());
            soyadi.Text = (Hane_Bilgileri.Rows[index].Cells[4].Value.ToString());
            gsmNo.Text = (Hane_Bilgileri.Rows[index].Cells[5].Value.ToString());
            //Sınıfın ilgili methodunu içine daire numarasını girerek sadece o daire ait bilgileri getirmesi için tanımlandı.
            aidatTakip.Oku_Kisi_Borc(Convert.ToInt32(daireNo.Text));
            //Daha sonra okuma yapıp formdaki Kişi Borç Bilgi DataGridView'i dolduruyoruz.
            KisiBorcDurumOku();
        }
    }

}
