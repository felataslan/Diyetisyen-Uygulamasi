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
using System.IO;

namespace YazilimMimarisi
{
    public partial class UserControlRapor : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ESCOBAR\\SQLEXPRESS;Initial Catalog=HastaBilgileri;Integrated Security=True");

        //field
        ReportInfoDB info = new ReportInfoDB();

        public UserControlRapor()
        {
            InitializeComponent();
        }

        private void UserControlRapor_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Hasta", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnHtml_Click(object sender, EventArgs e)
        {
            ReportBuildBase builder = new HtmlReportBuilder(info);
            string rapor;

            // İstenilen Sıralama kontrolü
            if (cmbSira.Text == "1)Kişisel Bilgi, Diyet Bilgisi")
            {
                ReportManager manager = new ReportManager(builder);
                rapor = manager.Build();
            }

            // Up side Down
            else
            {
                ReportManager manager = new ReportManager(builder);
                rapor = manager.BuildUpSideDown();
                // Diyet Bilgisi, Kişisel bilgi
            }

            //Save File Dialog nesnesi
            dosyaKaydet.Title = "Rapor Kaydet";
            dosyaKaydet.FileName = "HastaRapor";
            dosyaKaydet.Filter = "html Dosyası (*.html)|*.html";
            dosyaKaydet.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();

            dosyaKaydet.ShowDialog();
            string dosyaYolu = dosyaKaydet.FileName;

            //dosya oluşturma
            StreamWriter sw = new StreamWriter(File.Create(dosyaYolu));
            sw.WriteLine(rapor);
            sw.Dispose();

        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            ReportBuildBase builder = new JsonReportBuilder(info);

            if (cmbSira.Text == "1)Kişisel Bilgi, Diyet Bilgisi")
            {
                ReportManager manager = new ReportManager(builder);
                string rapor = manager.Build();
                //Kişisel bilgi, Diyet Bilgisi
                MessageBox.Show(rapor);
            }
            else
            {
                ReportManager manager = new ReportManager(builder);
                string rapor = manager.BuildUpSideDown();
                // Diyet Bilgisi, Kişisel bilgi
                MessageBox.Show(rapor);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            info.title = "HASTA RAPOR";
            info.KisiselBilgi = "Hasta TCNo: " + dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            info.KisiselBilgi += " Hasta Adı: " + dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            info.KisiselBilgi += " Hasta Soyadı: " + dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            info.DiyetBilgi = "Diyet Tipi: " + dataGridView1.Rows[secilenSatir].Cells[5].Value.ToString();
        }
    }
}
