
namespace YazilimMimarisi
{
    partial class FrmMenu
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
            this.BtnKayit = new System.Windows.Forms.Button();
            this.BtnDiyetEkle = new System.Windows.Forms.Button();
            this.BtnRapor = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnKayit
            // 
            this.BtnKayit.Location = new System.Drawing.Point(130, 172);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(187, 44);
            this.BtnKayit.TabIndex = 0;
            this.BtnKayit.Text = "Hasta Kayıt";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // BtnDiyetEkle
            // 
            this.BtnDiyetEkle.Location = new System.Drawing.Point(130, 253);
            this.BtnDiyetEkle.Name = "BtnDiyetEkle";
            this.BtnDiyetEkle.Size = new System.Drawing.Size(187, 44);
            this.BtnDiyetEkle.TabIndex = 1;
            this.BtnDiyetEkle.Text = "Diyet Atama";
            this.BtnDiyetEkle.UseVisualStyleBackColor = true;
            this.BtnDiyetEkle.Click += new System.EventHandler(this.BtnDiyetEkle_Click);
            // 
            // BtnRapor
            // 
            this.BtnRapor.Location = new System.Drawing.Point(130, 334);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(187, 44);
            this.BtnRapor.TabIndex = 3;
            this.BtnRapor.Text = "Rapor";
            this.BtnRapor.UseVisualStyleBackColor = true;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(130, 416);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(187, 44);
            this.BtnCikis.TabIndex = 2;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(151, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(447, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRapor);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnDiyetEkle);
            this.Controls.Add(this.BtnKayit);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.Button BtnDiyetEkle;
        private System.Windows.Forms.Button BtnRapor;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label1;
    }
}