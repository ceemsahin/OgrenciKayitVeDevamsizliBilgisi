namespace OgrenciKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioKadın = new System.Windows.Forms.RadioButton();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.txtOgrenciTCNO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciCepNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dvOgrenci = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbOgrenciSec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rbGeldi = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbRaporlu = new System.Windows.Forms.RadioButton();
            this.rbİzinli = new System.Windows.Forms.RadioButton();
            this.rbGelmedi = new System.Windows.Forms.RadioButton();
            this.btnDevamsizliSil = new System.Windows.Forms.Button();
            this.btnDevamsizlikEkle = new System.Windows.Forms.Button();
            this.dtDevamsizlik = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOgrenci)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDevamsizlik)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKayit);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioKadın);
            this.groupBox1.Controls.Add(this.radioErkek);
            this.groupBox1.Controls.Add(this.txtOgrenciTCNO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOgrenciCepNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOgrenciAdiSoyadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(38, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cinsiyet:";
            // 
            // radioKadın
            // 
            this.radioKadın.AutoSize = true;
            this.radioKadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKadın.Location = new System.Drawing.Point(222, 191);
            this.radioKadın.Name = "radioKadın";
            this.radioKadın.Size = new System.Drawing.Size(57, 17);
            this.radioKadın.TabIndex = 7;
            this.radioKadın.TabStop = true;
            this.radioKadın.Text = "Kadın";
            this.radioKadın.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioErkek.Location = new System.Drawing.Point(128, 191);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(58, 17);
            this.radioErkek.TabIndex = 6;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // txtOgrenciTCNO
            // 
            this.txtOgrenciTCNO.Location = new System.Drawing.Point(113, 130);
            this.txtOgrenciTCNO.Name = "txtOgrenciTCNO";
            this.txtOgrenciTCNO.Size = new System.Drawing.Size(249, 29);
            this.txtOgrenciTCNO.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ogrenci TC NO:";
            // 
            // txtOgrenciCepNo
            // 
            this.txtOgrenciCepNo.Location = new System.Drawing.Point(113, 84);
            this.txtOgrenciCepNo.Name = "txtOgrenciCepNo";
            this.txtOgrenciCepNo.Size = new System.Drawing.Size(249, 29);
            this.txtOgrenciCepNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ogrenci Cep No:";
            // 
            // txtOgrenciAdiSoyadi
            // 
            this.txtOgrenciAdiSoyadi.Location = new System.Drawing.Point(113, 36);
            this.txtOgrenciAdiSoyadi.Name = "txtOgrenciAdiSoyadi";
            this.txtOgrenciAdiSoyadi.Size = new System.Drawing.Size(249, 29);
            this.txtOgrenciAdiSoyadi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ogrenci Adı Soyadı:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(115, 227);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(247, 110);
            this.txtAdres.TabIndex = 10;
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(47, 353);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(108, 32);
            this.btnKayit.TabIndex = 11;
            this.btnKayit.Text = "Ogrenci Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(308, 353);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 32);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Ogrenci Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(176, 353);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(126, 32);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Ogrenci Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dvOgrenci
            // 
            this.dvOgrenci.AllowUserToAddRows = false;
            this.dvOgrenci.AllowUserToDeleteRows = false;
            this.dvOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvOgrenci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvOgrenci.Location = new System.Drawing.Point(38, 432);
            this.dvOgrenci.Name = "dvOgrenci";
            this.dvOgrenci.ReadOnly = true;
            this.dvOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvOgrenci.Size = new System.Drawing.Size(512, 248);
            this.dvOgrenci.TabIndex = 1;
            this.dvOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvOgrenci_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDevamsizlikEkle);
            this.groupBox2.Controls.Add(this.btnDevamsizliSil);
            this.groupBox2.Controls.Add(this.rbGelmedi);
            this.groupBox2.Controls.Add(this.rbİzinli);
            this.groupBox2.Controls.Add(this.rbRaporlu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rbGeldi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtTarih);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbOgrenciSec);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(583, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 412);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Devam/Devamsızlık İşlemleri";
            // 
            // cbOgrenciSec
            // 
            this.cbOgrenciSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOgrenciSec.FormattingEnabled = true;
            this.cbOgrenciSec.Location = new System.Drawing.Point(186, 41);
            this.cbOgrenciSec.Name = "cbOgrenciSec";
            this.cbOgrenciSec.Size = new System.Drawing.Size(249, 32);
            this.cbOgrenciSec.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ogrenci Seç:";
            // 
            // dtTarih
            // 
            this.dtTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(187, 92);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(249, 26);
            this.dtTarih.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(57, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tarih Seç:";
            // 
            // rbGeldi
            // 
            this.rbGeldi.AutoSize = true;
            this.rbGeldi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbGeldi.Location = new System.Drawing.Point(187, 171);
            this.rbGeldi.Name = "rbGeldi";
            this.rbGeldi.Size = new System.Drawing.Size(57, 20);
            this.rbGeldi.TabIndex = 17;
            this.rbGeldi.TabStop = true;
            this.rbGeldi.Text = "Geldi";
            this.rbGeldi.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(240, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(248, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // rbRaporlu
            // 
            this.rbRaporlu.AutoSize = true;
            this.rbRaporlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRaporlu.Location = new System.Drawing.Point(361, 215);
            this.rbRaporlu.Name = "rbRaporlu";
            this.rbRaporlu.Size = new System.Drawing.Size(73, 20);
            this.rbRaporlu.TabIndex = 20;
            this.rbRaporlu.TabStop = true;
            this.rbRaporlu.Text = "Raporlu";
            this.rbRaporlu.UseVisualStyleBackColor = true;
            // 
            // rbİzinli
            // 
            this.rbİzinli.AutoSize = true;
            this.rbİzinli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbİzinli.Location = new System.Drawing.Point(187, 215);
            this.rbİzinli.Name = "rbİzinli";
            this.rbİzinli.Size = new System.Drawing.Size(79, 20);
            this.rbİzinli.TabIndex = 21;
            this.rbİzinli.TabStop = true;
            this.rbİzinli.Text = "İdari İzinli";
            this.rbİzinli.UseVisualStyleBackColor = true;
            // 
            // rbGelmedi
            // 
            this.rbGelmedi.AutoSize = true;
            this.rbGelmedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbGelmedi.Location = new System.Drawing.Point(361, 171);
            this.rbGelmedi.Name = "rbGelmedi";
            this.rbGelmedi.Size = new System.Drawing.Size(76, 20);
            this.rbGelmedi.TabIndex = 22;
            this.rbGelmedi.TabStop = true;
            this.rbGelmedi.Text = "Gelmedi";
            this.rbGelmedi.UseVisualStyleBackColor = true;
            // 
            // btnDevamsizliSil
            // 
            this.btnDevamsizliSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamsizliSil.Location = new System.Drawing.Point(133, 279);
            this.btnDevamsizliSil.Name = "btnDevamsizliSil";
            this.btnDevamsizliSil.Size = new System.Drawing.Size(160, 32);
            this.btnDevamsizliSil.TabIndex = 23;
            this.btnDevamsizliSil.Text = "Devamsızlık Sil";
            this.btnDevamsizliSil.UseVisualStyleBackColor = true;
            this.btnDevamsizliSil.Click += new System.EventHandler(this.btnDevamsizliSil_Click);
            // 
            // btnDevamsizlikEkle
            // 
            this.btnDevamsizlikEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamsizlikEkle.Location = new System.Drawing.Point(315, 279);
            this.btnDevamsizlikEkle.Name = "btnDevamsizlikEkle";
            this.btnDevamsizlikEkle.Size = new System.Drawing.Size(143, 32);
            this.btnDevamsizlikEkle.TabIndex = 24;
            this.btnDevamsizlikEkle.Text = "Devamsızlık Ekle";
            this.btnDevamsizlikEkle.UseVisualStyleBackColor = true;
            this.btnDevamsizlikEkle.Click += new System.EventHandler(this.btnDevamsizlikEkle_Click);
            // 
            // dtDevamsizlik
            // 
            this.dtDevamsizlik.AllowUserToAddRows = false;
            this.dtDevamsizlik.AllowUserToDeleteRows = false;
            this.dtDevamsizlik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDevamsizlik.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtDevamsizlik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDevamsizlik.Location = new System.Drawing.Point(583, 432);
            this.dtDevamsizlik.Name = "dtDevamsizlik";
            this.dtDevamsizlik.ReadOnly = true;
            this.dtDevamsizlik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDevamsizlik.Size = new System.Drawing.Size(549, 248);
            this.dtDevamsizlik.TabIndex = 3;
            this.dtDevamsizlik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDevamsizlik_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 673);
            this.Controls.Add(this.dtDevamsizlik);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dvOgrenci);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOgrenci)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDevamsizlik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioKadın;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.TextBox txtOgrenciTCNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrenciCepNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciAdiSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.DataGridView dvOgrenci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDevamsizlikEkle;
        private System.Windows.Forms.Button btnDevamsizliSil;
        private System.Windows.Forms.RadioButton rbGelmedi;
        private System.Windows.Forms.RadioButton rbİzinli;
        private System.Windows.Forms.RadioButton rbRaporlu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbGeldi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOgrenciSec;
        private System.Windows.Forms.DataGridView dtDevamsizlik;
    }
}

