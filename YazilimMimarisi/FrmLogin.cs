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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2BOGKJG;Initial Catalog=Diet-App;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Kullanici where KullaniciAdi=@p1 and Parola=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1",txtadmin.Text);
            komut.Parameters.AddWithValue("@p2",txtPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmMenu form2 = new FrmMenu();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı girş yaptınız");
            }
            baglanti.Close();
        }
    }
}
