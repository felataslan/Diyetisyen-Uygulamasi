
namespace YazilimMimarisi
{
    partial class UserControlRapor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSira = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJson = new System.Windows.Forms.Button();
            this.btnHtml = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cmbSira);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnJson);
            this.panel1.Controls.Add(this.btnHtml);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 593);
            this.panel1.TabIndex = 2;
            // 
            // cmbSira
            // 
            this.cmbSira.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbSira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSira.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSira.FormattingEnabled = true;
            this.cmbSira.Items.AddRange(new object[] {
            "1)Kişisel Bilgi, Diyet Bilgisi",
            "2)Diyet Bilgisi, Kişisel Bilgi"});
            this.cmbSira.Location = new System.Drawing.Point(19, 234);
            this.cmbSira.Name = "cmbSira";
            this.cmbSira.Size = new System.Drawing.Size(222, 29);
            this.cmbSira.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "İÇERİK SIRASI:";
            // 
            // btnJson
            // 
            this.btnJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnJson.FlatAppearance.BorderSize = 0;
            this.btnJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJson.Font = new System.Drawing.Font("Century Gothic", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJson.Location = new System.Drawing.Point(3, 389);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(249, 36);
            this.btnJson.TabIndex = 3;
            this.btnJson.Text = "JSON OLUŞTUR";
            this.btnJson.UseVisualStyleBackColor = false;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnHtml
            // 
            this.btnHtml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnHtml.FlatAppearance.BorderSize = 0;
            this.btnHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHtml.Font = new System.Drawing.Font("Century Gothic", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHtml.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHtml.Location = new System.Drawing.Point(3, 334);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(249, 36);
            this.btnHtml.TabIndex = 3;
            this.btnHtml.Text = "HTML OLUŞTUR";
            this.btnHtml.UseVisualStyleBackColor = false;
            this.btnHtml.Click += new System.EventHandler(this.btnHtml_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.26866F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Rapor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 531);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UserControlRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlRapor";
            this.Size = new System.Drawing.Size(956, 593);
            this.Load += new System.EventHandler(this.UserControlRapor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHtml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSira;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
    }
}
