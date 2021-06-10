using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimMimarisi
{
    public partial class UserControlHastaKayit : UserControl
    {
        public UserControlHastaKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2BOGKJG;Initial Catalog=Diet-App;Integrated Security=True");

        private void UserControlHastaKayit_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();

            hastaNesnesiDoldur(hasta);

            veriTabaniEkle(hasta);
        }

        // Hasta nesnesini label lardaki verilere göre doldurur
        private Hasta hastaNesnesiDoldur(Hasta hasta)
        {

            hasta.TCNo = txtTC.Text;
            hasta.Ad = txtAd.Text;
            hasta.Soyad = txtSoyad.Text;

            // Fabrikadan nesne yaratma
            Factory fabrika = new Factory();
            IHastalikTipi hastalik = fabrika.HastalikNesnesiOlustur(cmbHastalikTipi.Text);
            IDiyetTipi diyet = fabrika.DiyetNesnesiOlustur(cmbDiyetTipi.Text);

            // Fabriakdan dönen nesneyi hastaya eşitleme
            hasta.hastalikTipi = hastalik;
            hasta.diyetTipi = diyet;
            return hasta;
        }

        //Veri Tabanına hastayı kaydetme
        private void veriTabaniEkle(Hasta hasta)
        {
            baglanti.Open();
            SqlCommand komutHastaEkle = new SqlCommand("insert into Hasta (TCno,Ad,Soyad,HastalikTipi,DiyetTipi) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komutHastaEkle.Parameters.AddWithValue("@p1", hasta.TCNo);
            komutHastaEkle.Parameters.AddWithValue("@p2", hasta.Ad);
            komutHastaEkle.Parameters.AddWithValue("@p3", hasta.Soyad);
            komutHastaEkle.Parameters.AddWithValue("@p4", hasta.hastalikTipi.hastalikEkle());
            komutHastaEkle.Parameters.AddWithValue("@p5", hasta.diyetTipi.DiyetEkle());
            komutHastaEkle.ExecuteNonQuery();
            MessageBox.Show("Ekleme Başarılı");
            baglanti.Close();
            temizle();
        }

        //Kayıt işleminden sonra alanları temizleme fonksiyonu
        private void temizle()
        {
            txtTC.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbHastalikTipi.Text = "";
            cmbDiyetTipi.Text = "";
        }
    }
}
