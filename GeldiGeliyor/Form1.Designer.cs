namespace GeldiGeliyor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.rdbShipper1 = new System.Windows.Forms.RadioButton();
            this.rdbShipper2 = new System.Windows.Forms.RadioButton();
            this.rdbShipper3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategoriler";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(83, 8);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(151, 21);
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 48);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(273, 111);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adi";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok";
            this.columnHeader3.Width = 99;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(12, 163);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(172, 50);
            this.btnSepeteEkle.TabIndex = 3;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparis.Location = new System.Drawing.Point(188, 163);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(95, 50);
            this.btnSiparis.TabIndex = 4;
            this.btnSiparis.Text = "Siparis Ver";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(12, 217);
            this.lstSepet.Margin = new System.Windows.Forms.Padding(2);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(167, 147);
            this.lstSepet.TabIndex = 5;
            this.lstSepet.SelectedIndexChanged += new System.EventHandler(this.lstSepet_SelectedIndexChanged);
            // 
            // rdbShipper1
            // 
            this.rdbShipper1.AutoSize = true;
            this.rdbShipper1.Location = new System.Drawing.Point(310, 50);
            this.rdbShipper1.Margin = new System.Windows.Forms.Padding(2);
            this.rdbShipper1.Name = "rdbShipper1";
            this.rdbShipper1.Size = new System.Drawing.Size(14, 13);
            this.rdbShipper1.TabIndex = 6;
            this.rdbShipper1.TabStop = true;
            this.rdbShipper1.UseVisualStyleBackColor = true;
            this.rdbShipper1.CheckedChanged += new System.EventHandler(this.rdbShipper1_CheckedChanged);
            // 
            // rdbShipper2
            // 
            this.rdbShipper2.AutoSize = true;
            this.rdbShipper2.Location = new System.Drawing.Point(310, 89);
            this.rdbShipper2.Margin = new System.Windows.Forms.Padding(2);
            this.rdbShipper2.Name = "rdbShipper2";
            this.rdbShipper2.Size = new System.Drawing.Size(14, 13);
            this.rdbShipper2.TabIndex = 7;
            this.rdbShipper2.TabStop = true;
            this.rdbShipper2.UseVisualStyleBackColor = true;
            // 
            // rdbShipper3
            // 
            this.rdbShipper3.AutoSize = true;
            this.rdbShipper3.Location = new System.Drawing.Point(310, 129);
            this.rdbShipper3.Margin = new System.Windows.Forms.Padding(2);
            this.rdbShipper3.Name = "rdbShipper3";
            this.rdbShipper3.Size = new System.Drawing.Size(14, 13);
            this.rdbShipper3.TabIndex = 8;
            this.rdbShipper3.TabStop = true;
            this.rdbShipper3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 373);
            this.Controls.Add(this.rdbShipper3);
            this.Controls.Add(this.rdbShipper2);
            this.Controls.Add(this.rdbShipper1);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.RadioButton rdbShipper1;
        private System.Windows.Forms.RadioButton rdbShipper2;
        private System.Windows.Forms.RadioButton rdbShipper3;
    }
}

