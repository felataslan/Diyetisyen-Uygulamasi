
namespace YazilimMimarisi
{
    partial class FrmNewFlatDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewFlatDesign));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.BtnRapor = new System.Windows.Forms.Button();
            this.btnDiyetAdama = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.userControlDiyetAtama1 = new YazilimMimarisi.UserControlDiyetAtama();
            this.userControlHastaKayit1 = new YazilimMimarisi.UserControlHastaKayit();
            this.userControlRapor1 = new YazilimMimarisi.UserControlRapor();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.BtnRapor);
            this.panel1.Controls.Add(this.btnDiyetAdama);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 720);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 104);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(17, 88);
            this.SidePanel.TabIndex = 2;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Century Gothic", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(12, 386);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(243, 88);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "   ÇIKIŞ";
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // BtnRapor
            // 
            this.BtnRapor.FlatAppearance.BorderSize = 0;
            this.BtnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRapor.Font = new System.Drawing.Font("Century Gothic", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRapor.ForeColor = System.Drawing.Color.White;
            this.BtnRapor.Image = ((System.Drawing.Image)(resources.GetObject("BtnRapor.Image")));
            this.BtnRapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRapor.Location = new System.Drawing.Point(12, 292);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(243, 88);
            this.BtnRapor.TabIndex = 2;
            this.BtnRapor.Text = "   RAPOR";
            this.BtnRapor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRapor.UseVisualStyleBackColor = true;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click);
            // 
            // btnDiyetAdama
            // 
            this.btnDiyetAdama.FlatAppearance.BorderSize = 0;
            this.btnDiyetAdama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiyetAdama.Font = new System.Drawing.Font("Century Gothic", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiyetAdama.ForeColor = System.Drawing.Color.White;
            this.btnDiyetAdama.Image = ((System.Drawing.Image)(resources.GetObject("btnDiyetAdama.Image")));
            this.btnDiyetAdama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiyetAdama.Location = new System.Drawing.Point(12, 198);
            this.btnDiyetAdama.Name = "btnDiyetAdama";
            this.btnDiyetAdama.Size = new System.Drawing.Size(243, 88);
            this.btnDiyetAdama.TabIndex = 1;
            this.btnDiyetAdama.Text = "   DİYET ATAMA";
            this.btnDiyetAdama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiyetAdama.UseVisualStyleBackColor = true;
            this.btnDiyetAdama.Click += new System.EventHandler(this.btnDiyetAdama_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(12, 104);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(243, 88);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "   HASTA KAYIT";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(243, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 40);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.26866F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(249, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "C# Diet-App";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1129, 46);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userControlDiyetAtama1
            // 
            this.userControlDiyetAtama1.Location = new System.Drawing.Point(243, 127);
            this.userControlDiyetAtama1.Name = "userControlDiyetAtama1";
            this.userControlDiyetAtama1.Size = new System.Drawing.Size(956, 593);
            this.userControlDiyetAtama1.TabIndex = 6;
            // 
            // userControlHastaKayit1
            // 
            this.userControlHastaKayit1.Location = new System.Drawing.Point(243, 127);
            this.userControlHastaKayit1.Name = "userControlHastaKayit1";
            this.userControlHastaKayit1.Size = new System.Drawing.Size(956, 593);
            this.userControlHastaKayit1.TabIndex = 5;
            // 
            // userControlRapor1
            // 
            this.userControlRapor1.Location = new System.Drawing.Point(243, 127);
            this.userControlRapor1.Name = "userControlRapor1";
            this.userControlRapor1.Size = new System.Drawing.Size(956, 593);
            this.userControlRapor1.TabIndex = 7;
            // 
            // FrmNewFlatDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 720);
            this.Controls.Add(this.userControlRapor1);
            this.Controls.Add(this.userControlDiyetAtama1);
            this.Controls.Add(this.userControlHastaKayit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewFlatDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewFlatDesign";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmNewFlatDesign_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmNewFlatDesign_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmNewFlatDesign_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button BtnRapor;
        private System.Windows.Forms.Button btnDiyetAdama;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private UserControlHastaKayit userControlHastaKayit1;
        private UserControlDiyetAtama userControlDiyetAtama1;
        private UserControlRapor userControlRapor1;
    }
}