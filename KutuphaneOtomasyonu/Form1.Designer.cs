namespace KutuphaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgrwUyeler = new DataGridView();
            label1 = new Label();
            btnUyeEkle = new Button();
            btnUyeSil = new Button();
            tbxUyeSehir = new TextBox();
            tbxUyeAd = new TextBox();
            tbxUyeSoyad = new TextBox();
            label2 = new Label();
            lblKitapYazari = new Label();
            lblBulunduguKisim = new Label();
            label6 = new Label();
            tbxKitapYazari = new TextBox();
            tbxKitapAdi = new TextBox();
            tbxBulunduguKisim = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnKitapEkle = new Button();
            groupBox1 = new GroupBox();
            label10 = new Label();
            tbxOduncUyeId = new TextBox();
            tbxOduncVer = new Button();
            label9 = new Label();
            tbxOduncKitapId = new TextBox();
            dgrwKitapListesi = new DataGridView();
            dgrwBookRent = new DataGridView();
            btnKitabıGeriAl = new Button();
            ((System.ComponentModel.ISupportInitialize)dgrwUyeler).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrwKitapListesi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrwBookRent).BeginInit();
            SuspendLayout();
            // 
            // dgrwUyeler
            // 
            dgrwUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwUyeler.Location = new Point(12, 32);
            dgrwUyeler.Name = "dgrwUyeler";
            dgrwUyeler.RowHeadersWidth = 51;
            dgrwUyeler.RowTemplate.Height = 29;
            dgrwUyeler.Size = new Size(1320, 249);
            dgrwUyeler.TabIndex = 0;
            dgrwUyeler.CellContentClick += dgrwUyeler_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Üyeler";
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Location = new Point(405, 289);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(94, 70);
            btnUyeEkle.TabIndex = 2;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // btnUyeSil
            // 
            btnUyeSil.Location = new Point(505, 288);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(94, 70);
            btnUyeSil.TabIndex = 3;
            btnUyeSil.Text = "Üye Sil";
            btnUyeSil.UseVisualStyleBackColor = true;
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // tbxUyeSehir
            // 
            tbxUyeSehir.Location = new Point(274, 311);
            tbxUyeSehir.Name = "tbxUyeSehir";
            tbxUyeSehir.Size = new Size(125, 27);
            tbxUyeSehir.TabIndex = 4;
            // 
            // tbxUyeAd
            // 
            tbxUyeAd.Location = new Point(12, 311);
            tbxUyeAd.Name = "tbxUyeAd";
            tbxUyeAd.Size = new Size(125, 27);
            tbxUyeAd.TabIndex = 6;
            // 
            // tbxUyeSoyad
            // 
            tbxUyeSoyad.Location = new Point(143, 311);
            tbxUyeSoyad.Name = "tbxUyeSoyad";
            tbxUyeSoyad.Size = new Size(125, 27);
            tbxUyeSoyad.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 680);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 8;
            label2.Text = "Kitap Adı";
            // 
            // lblKitapYazari
            // 
            lblKitapYazari.AutoSize = true;
            lblKitapYazari.Location = new Point(143, 680);
            lblKitapYazari.Name = "lblKitapYazari";
            lblKitapYazari.Size = new Size(87, 20);
            lblKitapYazari.TabIndex = 9;
            lblKitapYazari.Text = "Kitap Yazarı";
            // 
            // lblBulunduguKisim
            // 
            lblBulunduguKisim.AutoSize = true;
            lblBulunduguKisim.Location = new Point(274, 680);
            lblBulunduguKisim.Name = "lblBulunduguKisim";
            lblBulunduguKisim.Size = new Size(120, 20);
            lblBulunduguKisim.TabIndex = 11;
            lblBulunduguKisim.Text = "Bulunduğu Kısım";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 373);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 13;
            label6.Text = "Kitaplar";
            // 
            // tbxKitapYazari
            // 
            tbxKitapYazari.Location = new Point(143, 704);
            tbxKitapYazari.Name = "tbxKitapYazari";
            tbxKitapYazari.Size = new Size(125, 27);
            tbxKitapYazari.TabIndex = 17;
            // 
            // tbxKitapAdi
            // 
            tbxKitapAdi.Location = new Point(12, 704);
            tbxKitapAdi.Name = "tbxKitapAdi";
            tbxKitapAdi.Size = new Size(125, 27);
            tbxKitapAdi.TabIndex = 16;
            // 
            // tbxBulunduguKisim
            // 
            tbxBulunduguKisim.Location = new Point(274, 704);
            tbxBulunduguKisim.Name = "tbxBulunduguKisim";
            tbxBulunduguKisim.Size = new Size(125, 27);
            tbxBulunduguKisim.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 288);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 18;
            label5.Text = "Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 286);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 21;
            label4.Text = "Soyad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 288);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 22;
            label7.Text = "Şehir";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1568, 32);
            label8.Name = "label8";
            label8.Size = new Size(157, 20);
            label8.TabIndex = 24;
            label8.Text = "Ödünç Verilen Kitaplar";
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Location = new Point(424, 682);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(94, 70);
            btnKitapEkle.TabIndex = 25;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tbxOduncUyeId);
            groupBox1.Controls.Add(tbxOduncVer);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbxOduncKitapId);
            groupBox1.Location = new Point(1155, 396);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 280);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödünç Ver";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 114);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 4;
            label10.Text = "Üye Id";
            // 
            // tbxOduncUyeId
            // 
            tbxOduncUyeId.Location = new Point(6, 137);
            tbxOduncUyeId.Name = "tbxOduncUyeId";
            tbxOduncUyeId.Size = new Size(125, 27);
            tbxOduncUyeId.TabIndex = 3;
            // 
            // tbxOduncVer
            // 
            tbxOduncVer.Location = new Point(173, 70);
            tbxOduncVer.Name = "tbxOduncVer";
            tbxOduncVer.Size = new Size(136, 137);
            tbxOduncVer.TabIndex = 2;
            tbxOduncVer.Text = "Ödünç Ver";
            tbxOduncVer.UseVisualStyleBackColor = true;
            tbxOduncVer.Click += tbxOduncVer_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 47);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 1;
            label9.Text = "Kitap Id";
            // 
            // tbxOduncKitapId
            // 
            tbxOduncKitapId.Location = new Point(6, 70);
            tbxOduncKitapId.Name = "tbxOduncKitapId";
            tbxOduncKitapId.Size = new Size(125, 27);
            tbxOduncKitapId.TabIndex = 0;
            // 
            // dgrwKitapListesi
            // 
            dgrwKitapListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwKitapListesi.Location = new Point(12, 396);
            dgrwKitapListesi.Name = "dgrwKitapListesi";
            dgrwKitapListesi.RowHeadersWidth = 51;
            dgrwKitapListesi.RowTemplate.Height = 29;
            dgrwKitapListesi.Size = new Size(1137, 280);
            dgrwKitapListesi.TabIndex = 12;
            // 
            // dgrwBookRent
            // 
            dgrwBookRent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwBookRent.Location = new Point(1476, 55);
            dgrwBookRent.Name = "dgrwBookRent";
            dgrwBookRent.RowHeadersWidth = 51;
            dgrwBookRent.RowTemplate.Height = 29;
            dgrwBookRent.Size = new Size(436, 621);
            dgrwBookRent.TabIndex = 23;
            // 
            // btnKitabıGeriAl
            // 
            btnKitabıGeriAl.Location = new Point(1639, 680);
            btnKitabıGeriAl.Name = "btnKitabıGeriAl";
            btnKitabıGeriAl.Size = new Size(182, 88);
            btnKitabıGeriAl.TabIndex = 27;
            btnKitabıGeriAl.Text = "Kitabı Geri Al";
            btnKitabıGeriAl.UseVisualStyleBackColor = true;
            btnKitabıGeriAl.Click += btnKitabıGeriAl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 804);
            Controls.Add(btnKitabıGeriAl);
            Controls.Add(groupBox1);
            Controls.Add(btnKitapEkle);
            Controls.Add(label8);
            Controls.Add(dgrwBookRent);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(tbxKitapYazari);
            Controls.Add(tbxKitapAdi);
            Controls.Add(tbxBulunduguKisim);
            Controls.Add(label6);
            Controls.Add(dgrwKitapListesi);
            Controls.Add(lblBulunduguKisim);
            Controls.Add(lblKitapYazari);
            Controls.Add(label2);
            Controls.Add(tbxUyeSoyad);
            Controls.Add(tbxUyeAd);
            Controls.Add(tbxUyeSehir);
            Controls.Add(btnUyeSil);
            Controls.Add(btnUyeEkle);
            Controls.Add(label1);
            Controls.Add(dgrwUyeler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwUyeler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrwKitapListesi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrwBookRent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgrwUyeler;
        private Label label1;
        private Button btnUyeEkle;
        private Button btnUyeSil;
        private TextBox tbxUyeSehir;
        private TextBox tbxUyeAd;
        private TextBox tbxUyeSoyad;
        private Label label2;
        private Label lblKitapYazari;
        private Label lblBulunduguKisim;
        private Label label6;
        private TextBox tbxKitapYazari;
        private TextBox tbxKitapAdi;
        private TextBox tbxBulunduguKisim;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label8;
        private Button btnKitapEkle;
        private GroupBox groupBox1;
        private Label label10;
        private TextBox tbxOduncUyeId;
        private Button tbxOduncVer;
        private Label label9;
        private TextBox tbxOduncKitapId;
        private DataGridView dgrwKitapListesi;
        private DataGridView dgrwBookRent;
        private Button btnKitabıGeriAl;
    }
}