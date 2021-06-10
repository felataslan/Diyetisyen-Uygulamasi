using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisi
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FrmLogin form1 = new FrmLogin();
            form1.Show();
            this.Close();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            FrmHastaKayit form3 = new FrmHastaKayit();
            form3.Show();
            this.Hide();
        }

        private void BtnDiyetEkle_Click(object sender, EventArgs e)
        {
            FrmDiyetAtama form4 = new FrmDiyetAtama();
            form4.Show();
            this.Hide();
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {
            FrmRapor frmRapor = new FrmRapor();
            frmRapor.Show();
            this.Close();
        }
    }
}
