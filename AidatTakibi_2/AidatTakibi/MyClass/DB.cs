using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AidatTakibi.MyClass;
using System.Data;
using System.Collections;

namespace AidatTakibi.MyClass
{
    class DB
    {
        public SqlConnection baglanti;
        public DB()
        {
            baglanti = new SqlConnection("Data Source=MERTCAN\\MERTCAN; initial Catalog=aidatTakip; Integrated Security=true");
        }
    }
    class AidatTakipleri : DB
    {
        //Hane Prrperties oluşturdum.
        public int DaireNo { get; set; }
        public string AileAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string GsmNo { get; set; }

        //Borc Properties oluşturdum.
        public string borcunDonemi { get; set; }
        public string borcunDurumu { get; set; }
        public string odemeTarihi { get; set; }
        public string borcMiktari { get; set; }

        public int BorcID { get; set; }
        public int AileBilgiID { get; set; }


        //Okuma Properties oluşturdum.
        public DataTable haneBorcdt = new DataTable();
        public DataTable kisiHaneBorcdt = new DataTable();
        public DataTable hanedt = new DataTable();
        public DataTable borcdt = new DataTable();
        private DataSet haneBorcds = new DataSet();
        private DataSet kisiHaneBorcds = new DataSet();
        private DataSet haneds = new DataSet();
        private DataSet borcds = new DataSet();

        //Hane Bilgilerini veritabanındaki aile_bilgi tablosuna ekleme yapması için yazıldı.
        public void Ekle_Hane()
        {
            baglanti.Open();
            //Ekleme yapmak için insert sorgusu yazdık. Bu sorguda nesneden gelen aile bilgisi ile alakalı bilgileri aile_bilgi tablosuna ekliyor.
            SqlCommand ekle = new SqlCommand("insert into aile_bilgi(daire_no,ailenin_adi,adi,soyadi,gsm_no) values ('" + DaireNo + "','" + AileAdi + "','" + Adi + "','" + Soyadi + "','" + GsmNo + "')", baglanti);
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            ekle.ExecuteNonQuery();
            ekle.Dispose();

            baglanti.Close();

        }

        //Borç bilgilerini veritabanındaki borc_bilgisi tablosuna ekleme yapması için yazıldı.
        public bool Ekle_Borc()
        {
            bool kontrol = false;
            baglanti.Open(); // bağlantıyı açtık

            //Sorgumuzu yazdım. Ekleme işlemi yapan insert into sorgusu yazdım. Bu sorguda nesneden gelen borc bilgisi ile alakalı bilgileri borc_bilgisi tablosuna ekliyor.
            SqlCommand ekle = new SqlCommand("insert into borc_bilgisi(borc_donemi,borc_miktari) values ('" + borcunDonemi + "','" + borcMiktari + "')", baglanti);
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            //Değişiklik yaptığında komut.ExecuteNonQuery() sıfırdan büyük olacaktır. 
            //İşlemin gerçekleştiğini anlasın diye bir kontrol yaptım ve bunu geriye döndürdüm.
            //Ona göre sisteme mesaj verdirttim.
            if (ekle.ExecuteNonQuery() > 0)
            {
                kontrol = true;
            }
            ekle.Dispose();
            baglanti.Close();
            return kontrol;
        }

        //Bu method aile__bilgi_id ve borc_bilgi_id bilgisini alıp ödeme tarihi ve borc durumunu default olarak ekleme işlemi yapsın diye yazıldı.
        //aile__bilgi_id ve borc_bilgi_id bilgisini oluşturulmuş nesnelerden alıyor.
        public void Ekle_Hane_Borc()
        {
            string borc_durumu = "Ödenmedi";
            baglanti.Open();
            //Sorgumuzu yazdık. Borç ücreti ve durumu ekleyecek ama ilişkisel bir tablo olduğu için borç_bilgisi ve aile_bilgisi ID'lerini de girmeli.
            SqlCommand ekle = new SqlCommand("insert into aile_borc_bilgi(aile_bilgi_id,borc_bilgisi_id,borcun_durumu,odeme_tarihi) values (@aile_id,@borc_donemi,@borc_durumu,@odeme_tarihi)", baglanti);
            //Yukarıdaki sorguda aşağıdaki parametrelerdeki bilgileri kullanması için tanımladı.
            ekle.Parameters.AddWithValue("@aile_id", AileBilgiID);
            //Borç dönemindeki id'ye 1 eklenmesinin sebebi son id'nin değerinin 1 fazlası buraya gelince ekleniyor. Yeni dönemin id'sini alabilmek için yaptık yani.
            ekle.Parameters.AddWithValue("@borc_donemi", BorcID);
            ekle.Parameters.AddWithValue("@borc_durumu", borc_durumu);
            //Ödeme tarihi default olarak boş tanımlandı.
            ekle.Parameters.AddWithValue("@odeme_tarihi", "");
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            baglanti.Close();
        }

        //Bu methodu aile_bilgi tablosunu daire_no değerine göre güncelleme yapsın diye oluşturdum.        
        public bool Guncelle_Hane()
        {
            bool kontrol = false;
            baglanti.Open();
            //Aile bilgisi tablosunun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            string kayit = "update aile_bilgi set ailenin_adi=@aileAdi,adi=@adi,soyadi=@soyadi,gsm_no=@gsmNo where daire_no=@daireNo";
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgunun içerisinde ilgili alanları doldurabilmek için aşağıdaki parametreleri oluşturdum.
            komut.Parameters.AddWithValue("@aileAdi", AileAdi);
            komut.Parameters.AddWithValue("@adi", Adi);
            komut.Parameters.AddWithValue("@soyadi", Soyadi);
            komut.Parameters.AddWithValue("@gsmNo", GsmNo);
            komut.Parameters.AddWithValue("@daireNo", DaireNo);
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            //Değişiklik yaptığında komut.ExecuteNonQuery() sıfırdan büyük olacaktır. 
            //İşlemin gerçekleştiğini anlasın diye bir kontrol yaptım ve bunu geriye döndürdüm.
            //Ona göre sisteme mesaj verdirttim.
            if (komut.ExecuteNonQuery() > 0)
            {
                kontrol = true;
            }

            baglanti.Close();
            return kontrol;
        }

        //Bu methodu hane bilgilerini aile_bilgi tablosundan okusun diye yazdım. 
        //Okuduğu bilgileri oluşturduğum datatable nesnesine aktardım.
        //datatable nesnesini formda çağırarak bir liste alıp ekrana bastırdım.
        public void Oku_Hane()
        {
            hanedt.Clear();
            //aile_bilgi tablosundaki tüm alanların bilgilerini çağırdığım bir sorgu yazdım.
            string kayit = "SELECT id,daire_no as 'Daire Numarası',ailenin_adi as 'Ailenin Adı',adi as 'Adı', soyadi as 'Soyadı',gsm_no as 'Telefon No' from aile_bilgi order by daire_no asc";
            SqlDataAdapter adapter = new SqlDataAdapter(kayit, baglanti);
            //Gelen verileri dataset nesnesine gönderdim.
            adapter.Fill(haneds);
            //Dataset nesnesindeki değerleri de datatable nesnesine gönderdim.
            hanedt = haneds.Tables[0];
        }

        //Bu methodu hanelerin borç bilgilerini olduğu aile_borc_bilgi tablosundan okusun diye yazdım. 
        //Okuduğu bilgileri oluşturduğum datatable nesnesine aktardım.
        //datatable nesnesini formda çağırarak bir liste alıp ekrana bastırdım.
        public void Oku_Hane_Borc()
        {
            
            haneBorcdt.Clear();
            //aile_borc_bilgi tablosundaki verileri okuyan bir sorgu yazdım.
            //aile_borc_bilgi tablosu aile_bilgi ve borc_bilgisi tablosu ile ileşkili olduğu için o diğer taablolarla join yapıp diğer tablodaki bilgilere de eriştim.
            string kayit = "Select ab.daire_no as 'Daire Numarası',ab.ailenin_adi as 'Ailenin Adı',bb.borc_donemi as 'Borç Dönemi',bb.borc_miktari as 'Borç Ücreti',abb.borcun_durumu as 'Borcun Durumu',abb.odeme_tarihi as 'Ödeme Tarihi' from aile_borc_bilgi abb join aile_bilgi ab on abb.aile_bilgi_id=ab.id join borc_bilgisi bb on bb.borc_id=abb.borc_bilgisi_id order by bb.borc_id desc";
            SqlDataAdapter adapter = new SqlDataAdapter(kayit, baglanti);
            //Gelen verileri dataset nesnesine gönderdim.
            adapter.Fill(haneBorcds);
            //Dataset nesnesindeki değerleri de datatable nesnesine gönderdim.
            haneBorcdt = haneBorcds.Tables[0];
        }

        //Bu methodu hanelerin borç bilgilerini olduğu aile_borc_bilgi tablosundan daire numarasına göre okusun diye yazdım.
        //Okuduğu bilgileri oluşturduğum datatable nesnesine aktardım.
        //datatable nesnesini formda çağırarak bir liste alıp ekrana bastırdım.
        public void Oku_Kisi_Borc(int daireNumarasi)
        {
            kisiHaneBorcdt.Clear();
            //aile_borc_bilgi tablosundaki verileri okuyan bir sorgu yazdım.
            //aile_borc_bilgi tablosu aile_bilgi ve borc_bilgisi tablosu ile ileşkili olduğu için o diğer taablolarla join yapıp diğer tablodaki bilgilere de eriştim.
            //Ve buradaki bilgileri daire numarasına göre getiriyor.
            string kayit = "Select ab.daire_no as 'Daire Numarası',ab.ailenin_adi as 'Ailenin Adı',bb.borc_donemi as 'Borç Dönemi',bb.borc_miktari as 'Borç Ücreti',abb.borcun_durumu as 'Borcun Durumu',abb.odeme_tarihi as 'Ödeme Tarihi' from aile_borc_bilgi abb join aile_bilgi ab on abb.aile_bilgi_id=ab.id join borc_bilgisi bb on bb.borc_id=abb.borc_bilgisi_id where ab.daire_no='" + daireNumarasi + "' order by bb.borc_id desc";
            SqlDataAdapter adapter = new SqlDataAdapter(kayit, baglanti);
            //Gelen verileri dataset nesnesine gönderdim.
            adapter.Fill(kisiHaneBorcds);
            //Dataset nesnesindeki değerleri de datatable nesnesine gönderdim.
            kisiHaneBorcdt = kisiHaneBorcds.Tables[0];
        }

        //Bu methodu borç bilgilerinin olduğu borc_bilgisi tablosunu okusun diye yazdım.
        //Okuduğu bilgileri oluşturduğum datatable nesnesine aktardım.
        //datatable nesnesini formda çağırarak bir liste alıp ekrana bastırdım.
        public void Oku_Borc()
        {
            borcdt.Clear();
            //Borç dönem bilgisi ve miktarının olduğu borc_bilgisi tablosundaki bilgileri döndürmek için bir sorgu yazdım.
            string kayit = "SELECT borc_id,borc_donemi as 'Borç Dönemi', borc_miktari as 'Ücret Bilgisi' from borc_bilgisi order by borc_id desc";
            SqlDataAdapter adapter = new SqlDataAdapter(kayit, baglanti);
            //Gelen verileri dataset nesnesine gönderdim.
            adapter.Fill(borcds);
            //Dataset nesnesindeki değerleri de datatable nesnesine gönderdim.
            borcdt = borcds.Tables[0];
        }

        //Bu method'da aile_bilgi tablosundaki daire numaraları sıralı bir şekilde gelsin diye yazıldı.
        //Gelen daire numaralarını bir listeye atarak geriye döndürdük.
        //Listedeki verileri daireNoSec combobox'ına atacağız.
        public List<int> daireNoSecGetir()
        {
            //SQL komut nesnesi oluşturdum.
            SqlCommand cmd = new SqlCommand();
            //Bağlantı adresimi tanımladım.
            cmd.Connection = baglanti;
            //Sorgumuzu yazdık. Sorguyu sırası düzgün sırada gelecek şekilde yazdık.
            cmd.CommandText = "SELECT * FROM aile_bilgi order by daire_no asc";
            baglanti.Open();
            //Sql sorgu çıktısını okuması için böyle bir nesne oluşturdum.
            SqlDataReader dr = cmd.ExecuteReader();
            //Okunan değerleri atamak için bir List tanımladım.
            List<int> daireler = new List<int>();
            //Okuma devam ettiği sürece tanımladığım listeye "daire_no" sütunundaki bilgileri ekleyecek.
            while (dr.Read())
            {
                daireler.Add(Convert.ToInt32(dr["daire_no"]));
            }

            dr.Close();
            baglanti.Close();
            return daireler;
        }

        //Bu method'da borc_bilgisi tablosundaki borç dönem bilgileri en son eklenen dönem gelecek şekilde yazıldı.
        //Gelen borç dönem bilgilerini bir listeye atarak geriye döndürdük.
        //Listedeki verileri borcDonemSec combobox'ına atacağız.
        public List<string> BorcDonemSecGetir()
        {
            //SQL komut nesnesi oluşturdum.
            SqlCommand cmd = new SqlCommand();
            //Bağlantı adresimi tanımladım.
            cmd.Connection = baglanti;
            //Sorgumuzu yazdık. Sorguyu sırası düzgün sırada gelecek şekilde yazdık.
            cmd.CommandText = "SELECT * FROM borc_bilgisi order by borc_id desc";
            baglanti.Open();
            //Sql sorgu çıktısını okuması için böyle bir nesne oluşturdum.
            SqlDataReader dr = cmd.ExecuteReader();
            //Okunan değerleri atamak için bir ArrayList tanımladım.
            List<string> borcdonemleri = new List<string>();
            //Okuma devam ettiği sürece tanımladığım listeye "daire_no" sütunundaki bilgileri ekleyecek.
            while (dr.Read())
            {
                borcdonemleri.Add(dr["borc_donemi"].ToString());
            }

            dr.Close();
            baglanti.Close();
            return borcdonemleri;
        }

        //Borç ödemesi yapıldığında borcun durumunu "Ödendi" ve Ödeme tarihini günümüz olacak şekilde güncelleme yapsın diye böyle bir method yazdım.
        public bool Guncelle_Borc()
        {
            bool kontrol = false;
            baglanti.Open();
            //Aile bilgisi tablosunun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            string kayit = "update aile_borc_bilgi set borcun_durumu=@borcunDurumu,odeme_tarihi=@odemeTarihi where borc_bilgisi_id=@borc_bilgisi_id and aile_bilgi_id=@aile_bilgi_id";
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgunun içerisinde ilgili alanları doldurabilmek için aşağıdaki parametreleri oluşturdum.
            komut.Parameters.AddWithValue("@borc_bilgisi_id", BorcID);
            komut.Parameters.AddWithValue("@aile_bilgi_id", AileBilgiID);
            komut.Parameters.AddWithValue("@borcunDurumu", "Ödendi");
            komut.Parameters.AddWithValue("@odemeTarihi", DateTime.Now.ToLongDateString());
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            //Değişiklik yaptığında komut.ExecuteNonQuery() sıfırdan büyük olacaktır. 
            //İşlemin gerçekleştiğini anlasın diye bir kontrol yaptım ve bunu geriye döndürdüm.
            //Ona göre sisteme mesaj verdirttim.
            if (komut.ExecuteNonQuery() > 0)
            {
                kontrol = true;
            }
            baglanti.Close();
            return kontrol;
        }
        
    }
}
