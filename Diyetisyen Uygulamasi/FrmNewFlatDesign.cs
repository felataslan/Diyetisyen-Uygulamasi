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
    public partial class FrmNewFlatDesign : Form
    {
        public FrmNewFlatDesign()
        {
            InitializeComponent();
            SidePanel.Height = btnMenu.Height;
            SidePanel.Top = btnMenu.Top;
            userControlHastaKayit1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMenu.Height;
            SidePanel.Top = btnMenu.Top;
            userControlHastaKayit1.BringToFront();
        }

        private void btnDiyetAdama_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDiyetAdama.Height;
            SidePanel.Top = btnDiyetAdama.Top;
            userControlDiyetAtama1.BringToFront();
        }
        private void BtnRapor_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnRapor.Height;
            SidePanel.Top = BtnRapor.Top;
            userControlRapor1.BringToFront();

        }

        //Form hareket
        bool move;
        int mouse_x;
        int mouse_y;
        private void FrmNewFlatDesign_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void FrmNewFlatDesign_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void FrmNewFlatDesign_MouseMove(object sender, MouseEventArgs e)
        {
            if(move== true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }

        
        // Oturum sonlandırma butonu
        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ferhateroglu");
        }
    }
}
