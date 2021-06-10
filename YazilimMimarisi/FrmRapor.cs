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
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2BOGKJG;Initial Catalog=Diet-App;Integrated Security=True");

        ReportInfoDB info = new ReportInfoDB();

        private void FrmRapor_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            // İstenilen Format kontrolü
            if(comboBox1.Text == "HTML")
            {
                ReportBuildBase builder = new HtmlReportBuilder(info);

                // İstenilen Sıralama kontrolü
                if(comboBox2.Text == "1)Kişisel Bilgi, Diyet Bilgisi")
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
            else if (comboBox1.Text == "JSON")
            {
                ReportBuildBase builder = new JsonReportBuilder(info);

                if (comboBox2.Text == "1)Kişisel Bilgi, Diyet Bilgisi")
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            info.title = "HASTA RAPOR";
            info.KisiselBilgi = "Hasta TCNo: " + dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString() ;
            info.KisiselBilgi +=" Hasta Adı: "+ dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString() ;
            info.KisiselBilgi += " Hasta Soyadı: " + dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            info.DiyetBilgi = "Diyet Tipi: " + dataGridView1.Rows[secilenSatir].Cells[5].Value.ToString();
        }

        
        
        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }


    }
}
