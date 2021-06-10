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
    public partial class FrmDiyetAtama : Form
    {
        public FrmDiyetAtama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2BOGKJG;Initial Catalog=Diet-App;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("Update Hasta set DiyetTipi=@p1 Where ID=@p2",baglanti);
            komutGuncelle.Parameters.AddWithValue("@p1",cmbDiyetTipi.Text);
            komutGuncelle.Parameters.AddWithValue("@p2",lblID.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            lblID.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            lblAd.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            lblSoyad.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            lblHastalik.Text = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            cmbDiyetTipi.Text = dataGridView1.Rows[secilenSatir].Cells[5].Value.ToString();
        }


    }
}
