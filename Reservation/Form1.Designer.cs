namespace Reservation
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
            this.comboBoxUcak = new System.Windows.Forms.ComboBox();
            this.comboBoxBaslangic = new System.Windows.Forms.ComboBox();
            this.comboBoxVaris = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.textBoxUcret = new System.Windows.Forms.TextBox();
            this.buttonUcusOlustur = new System.Windows.Forms.Button();
            this.groupBoxUcusOlustur = new System.Windows.Forms.GroupBox();
            this.labelUcakKod = new System.Windows.Forms.Label();
            this.labelVaris = new System.Windows.Forms.Label();
            this.labelBaslangic = new System.Windows.Forms.Label();
            this.labelUcret = new System.Windows.Forms.Label();
            this.labelUcusKodu = new System.Windows.Forms.Label();
            this.textBoxUcusKodu = new System.Windows.Forms.TextBox();
            this.groupBoxYolcuEkle = new System.Windows.Forms.GroupBox();
            this.buttonYolcuEkle = new System.Windows.Forms.Button();
            this.labelKoltuk = new System.Windows.Forms.Label();
            this.comboBoxKoltuk = new System.Windows.Forms.ComboBox();
            this.labelKisiler = new System.Windows.Forms.Label();
            this.comboBoxKisiler = new System.Windows.Forms.ComboBox();
            this.labelNereye = new System.Windows.Forms.Label();
            this.labelNereden = new System.Windows.Forms.Label();
            this.textBoxNereye = new System.Windows.Forms.TextBox();
            this.textBoxNereden = new System.Windows.Forms.TextBox();
            this.labelKodlar = new System.Windows.Forms.Label();
            this.comboBoxUcuslar = new System.Windows.Forms.ComboBox();
            this.groupBoxBiletBilgileri = new System.Windows.Forms.GroupBox();
            this.labelUcus = new System.Windows.Forms.Label();
            this.labelYolcu = new System.Windows.Forms.Label();
            this.groupBoxUcusOlustur.SuspendLayout();
            this.groupBoxYolcuEkle.SuspendLayout();
            this.groupBoxBiletBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxUcak
            // 
            this.comboBoxUcak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUcak.FormattingEnabled = true;
            this.comboBoxUcak.Location = new System.Drawing.Point(499, 36);
            this.comboBoxUcak.Name = "comboBoxUcak";
            this.comboBoxUcak.Size = new System.Drawing.Size(131, 21);
            this.comboBoxUcak.TabIndex = 2;
            // 
            // comboBoxBaslangic
            // 
            this.comboBoxBaslangic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaslangic.FormattingEnabled = true;
            this.comboBoxBaslangic.Location = new System.Drawing.Point(82, 36);
            this.comboBoxBaslangic.Name = "comboBoxBaslangic";
            this.comboBoxBaslangic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaslangic.TabIndex = 0;
            // 
            // comboBoxVaris
            // 
            this.comboBoxVaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVaris.FormattingEnabled = true;
            this.comboBoxVaris.Location = new System.Drawing.Point(269, 36);
            this.comboBoxVaris.Name = "comboBoxVaris";
            this.comboBoxVaris.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVaris.TabIndex = 1;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(188, 87);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTarih.TabIndex = 4;
            // 
            // textBoxUcret
            // 
            this.textBoxUcret.Location = new System.Drawing.Point(433, 90);
            this.textBoxUcret.Name = "textBoxUcret";
            this.textBoxUcret.Size = new System.Drawing.Size(100, 20);
            this.textBoxUcret.TabIndex = 5;
            // 
            // buttonUcusOlustur
            // 
            this.buttonUcusOlustur.Location = new System.Drawing.Point(549, 89);
            this.buttonUcusOlustur.Name = "buttonUcusOlustur";
            this.buttonUcusOlustur.Size = new System.Drawing.Size(128, 23);
            this.buttonUcusOlustur.TabIndex = 6;
            this.buttonUcusOlustur.Text = "Uçuş Oluştur";
            this.buttonUcusOlustur.UseVisualStyleBackColor = true;
            this.buttonUcusOlustur.Click += new System.EventHandler(this.buttonUcusOlustur_Click);
            // 
            // groupBoxUcusOlustur
            // 
            this.groupBoxUcusOlustur.Controls.Add(this.labelUcakKod);
            this.groupBoxUcusOlustur.Controls.Add(this.labelVaris);
            this.groupBoxUcusOlustur.Controls.Add(this.labelBaslangic);
            this.groupBoxUcusOlustur.Controls.Add(this.labelUcret);
            this.groupBoxUcusOlustur.Controls.Add(this.labelUcusKodu);
            this.groupBoxUcusOlustur.Controls.Add(this.textBoxUcusKodu);
            this.groupBoxUcusOlustur.Controls.Add(this.buttonUcusOlustur);
            this.groupBoxUcusOlustur.Controls.Add(this.comboBoxUcak);
            this.groupBoxUcusOlustur.Controls.Add(this.textBoxUcret);
            this.groupBoxUcusOlustur.Controls.Add(this.comboBoxBaslangic);
            this.groupBoxUcusOlustur.Controls.Add(this.dateTimePickerTarih);
            this.groupBoxUcusOlustur.Controls.Add(this.comboBoxVaris);
            this.groupBoxUcusOlustur.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUcusOlustur.Name = "groupBoxUcusOlustur";
            this.groupBoxUcusOlustur.Size = new System.Drawing.Size(762, 132);
            this.groupBoxUcusOlustur.TabIndex = 6;
            this.groupBoxUcusOlustur.TabStop = false;
            this.groupBoxUcusOlustur.Text = "Uçuş Oluştur";
            // 
            // labelUcakKod
            // 
            this.labelUcakKod.AutoSize = true;
            this.labelUcakKod.Location = new System.Drawing.Point(430, 44);
            this.labelUcakKod.Name = "labelUcakKod";
            this.labelUcakKod.Size = new System.Drawing.Size(61, 13);
            this.labelUcakKod.TabIndex = 102;
            this.labelUcakKod.Text = "Ucak Kodu";
            // 
            // labelVaris
            // 
            this.labelVaris.AutoSize = true;
            this.labelVaris.Location = new System.Drawing.Point(233, 39);
            this.labelVaris.Name = "labelVaris";
            this.labelVaris.Size = new System.Drawing.Size(30, 13);
            this.labelVaris.TabIndex = 101;
            this.labelVaris.Text = "Varis";
            // 
            // labelBaslangic
            // 
            this.labelBaslangic.AutoSize = true;
            this.labelBaslangic.Location = new System.Drawing.Point(19, 44);
            this.labelBaslangic.Name = "labelBaslangic";
            this.labelBaslangic.Size = new System.Drawing.Size(53, 13);
            this.labelBaslangic.TabIndex = 17;
            this.labelBaslangic.Text = "Baslangic";
            // 
            // labelUcret
            // 
            this.labelUcret.AutoSize = true;
            this.labelUcret.Location = new System.Drawing.Point(394, 94);
            this.labelUcret.Name = "labelUcret";
            this.labelUcret.Size = new System.Drawing.Size(33, 13);
            this.labelUcret.TabIndex = 8;
            this.labelUcret.Text = "Ücret";
            // 
            // labelUcusKodu
            // 
            this.labelUcusKodu.AutoSize = true;
            this.labelUcusKodu.Location = new System.Drawing.Point(16, 90);
            this.labelUcusKodu.Name = "labelUcusKodu";
            this.labelUcusKodu.Size = new System.Drawing.Size(60, 13);
            this.labelUcusKodu.TabIndex = 100;
            this.labelUcusKodu.Text = "Uçuş Kodu";
            // 
            // textBoxUcusKodu
            // 
            this.textBoxUcusKodu.Location = new System.Drawing.Point(82, 87);
            this.textBoxUcusKodu.Name = "textBoxUcusKodu";
            this.textBoxUcusKodu.Size = new System.Drawing.Size(100, 20);
            this.textBoxUcusKodu.TabIndex = 3;
            // 
            // groupBoxYolcuEkle
            // 
            this.groupBoxYolcuEkle.Controls.Add(this.buttonYolcuEkle);
            this.groupBoxYolcuEkle.Controls.Add(this.labelKoltuk);
            this.groupBoxYolcuEkle.Controls.Add(this.comboBoxKoltuk);
            this.groupBoxYolcuEkle.Controls.Add(this.labelKisiler);
            this.groupBoxYolcuEkle.Controls.Add(this.comboBoxKisiler);
            this.groupBoxYolcuEkle.Controls.Add(this.labelNereye);
            this.groupBoxYolcuEkle.Controls.Add(this.labelNereden);
            this.groupBoxYolcuEkle.Controls.Add(this.textBoxNereye);
            this.groupBoxYolcuEkle.Controls.Add(this.textBoxNereden);
            this.groupBoxYolcuEkle.Controls.Add(this.labelKodlar);
            this.groupBoxYolcuEkle.Controls.Add(this.comboBoxUcuslar);
            this.groupBoxYolcuEkle.Location = new System.Drawing.Point(12, 194);
            this.groupBoxYolcuEkle.Name = "groupBoxYolcuEkle";
            this.groupBoxYolcuEkle.Size = new System.Drawing.Size(762, 163);
            this.groupBoxYolcuEkle.TabIndex = 9;
            this.groupBoxYolcuEkle.TabStop = false;
            this.groupBoxYolcuEkle.Text = "Yolcu Ekle";
            // 
            // buttonYolcuEkle
            // 
            this.buttonYolcuEkle.Location = new System.Drawing.Point(16, 108);
            this.buttonYolcuEkle.Name = "buttonYolcuEkle";
            this.buttonYolcuEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonYolcuEkle.TabIndex = 12;
            this.buttonYolcuEkle.Text = "Yolcu Ekle";
            this.buttonYolcuEkle.UseVisualStyleBackColor = true;
            this.buttonYolcuEkle.Click += new System.EventHandler(this.buttonYolcuEkle_Click);
            // 
            // labelKoltuk
            // 
            this.labelKoltuk.AutoSize = true;
            this.labelKoltuk.Location = new System.Drawing.Point(233, 73);
            this.labelKoltuk.Name = "labelKoltuk";
            this.labelKoltuk.Size = new System.Drawing.Size(58, 13);
            this.labelKoltuk.TabIndex = 16;
            this.labelKoltuk.Text = "Bos Koltuk";
            // 
            // comboBoxKoltuk
            // 
            this.comboBoxKoltuk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKoltuk.FormattingEnabled = true;
            this.comboBoxKoltuk.Location = new System.Drawing.Point(297, 65);
            this.comboBoxKoltuk.Name = "comboBoxKoltuk";
            this.comboBoxKoltuk.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKoltuk.TabIndex = 11;
            // 
            // labelKisiler
            // 
            this.labelKisiler.AutoSize = true;
            this.labelKisiler.Location = new System.Drawing.Point(9, 74);
            this.labelKisiler.Name = "labelKisiler";
            this.labelKisiler.Size = new System.Drawing.Size(34, 13);
            this.labelKisiler.TabIndex = 14;
            this.labelKisiler.Text = "Kişiler";
            // 
            // comboBoxKisiler
            // 
            this.comboBoxKisiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKisiler.FormattingEnabled = true;
            this.comboBoxKisiler.Location = new System.Drawing.Point(86, 66);
            this.comboBoxKisiler.Name = "comboBoxKisiler";
            this.comboBoxKisiler.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKisiler.TabIndex = 10;
            // 
            // labelNereye
            // 
            this.labelNereye.AutoSize = true;
            this.labelNereye.Location = new System.Drawing.Point(524, 22);
            this.labelNereye.Name = "labelNereye";
            this.labelNereye.Size = new System.Drawing.Size(41, 13);
            this.labelNereye.TabIndex = 12;
            this.labelNereye.Text = "Nereye";
            // 
            // labelNereden
            // 
            this.labelNereden.AutoSize = true;
            this.labelNereden.Location = new System.Drawing.Point(233, 22);
            this.labelNereden.Name = "labelNereden";
            this.labelNereden.Size = new System.Drawing.Size(48, 13);
            this.labelNereden.TabIndex = 11;
            this.labelNereden.Text = "Nereden";
            // 
            // textBoxNereye
            // 
            this.textBoxNereye.Location = new System.Drawing.Point(571, 19);
            this.textBoxNereye.Name = "textBoxNereye";
            this.textBoxNereye.ReadOnly = true;
            this.textBoxNereye.Size = new System.Drawing.Size(177, 20);
            this.textBoxNereye.TabIndex = 9;
            // 
            // textBoxNereden
            // 
            this.textBoxNereden.Location = new System.Drawing.Point(306, 19);
            this.textBoxNereden.Name = "textBoxNereden";
            this.textBoxNereden.ReadOnly = true;
            this.textBoxNereden.Size = new System.Drawing.Size(177, 20);
            this.textBoxNereden.TabIndex = 8;
            // 
            // labelKodlar
            // 
            this.labelKodlar.AutoSize = true;
            this.labelKodlar.Location = new System.Drawing.Point(13, 22);
            this.labelKodlar.Name = "labelKodlar";
            this.labelKodlar.Size = new System.Drawing.Size(67, 13);
            this.labelKodlar.TabIndex = 8;
            this.labelKodlar.Text = "Uçuş Kodlari";
            // 
            // comboBoxUcuslar
            // 
            this.comboBoxUcuslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUcuslar.FormattingEnabled = true;
            this.comboBoxUcuslar.Location = new System.Drawing.Point(86, 19);
            this.comboBoxUcuslar.Name = "comboBoxUcuslar";
            this.comboBoxUcuslar.Size = new System.Drawing.Size(137, 21);
            this.comboBoxUcuslar.TabIndex = 7;
            this.comboBoxUcuslar.SelectedIndexChanged += new System.EventHandler(this.comboBoxUcuslar_SelectedIndexChanged);
            // 
            // groupBoxBiletBilgileri
            // 
            this.groupBoxBiletBilgileri.Controls.Add(this.labelUcus);
            this.groupBoxBiletBilgileri.Controls.Add(this.labelYolcu);
            this.groupBoxBiletBilgileri.Location = new System.Drawing.Point(12, 382);
            this.groupBoxBiletBilgileri.Name = "groupBoxBiletBilgileri";
            this.groupBoxBiletBilgileri.Size = new System.Drawing.Size(762, 186);
            this.groupBoxBiletBilgileri.TabIndex = 10;
            this.groupBoxBiletBilgileri.TabStop = false;
            this.groupBoxBiletBilgileri.Text = "Bilgi";
            // 
            // labelUcus
            // 
            this.labelUcus.AutoSize = true;
            this.labelUcus.Location = new System.Drawing.Point(185, 32);
            this.labelUcus.Name = "labelUcus";
            this.labelUcus.Size = new System.Drawing.Size(0, 13);
            this.labelUcus.TabIndex = 1;
            // 
            // labelYolcu
            // 
            this.labelYolcu.AutoSize = true;
            this.labelYolcu.Location = new System.Drawing.Point(19, 32);
            this.labelYolcu.Name = "labelYolcu";
            this.labelYolcu.Size = new System.Drawing.Size(0, 13);
            this.labelYolcu.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 575);
            this.Controls.Add(this.groupBoxBiletBilgileri);
            this.Controls.Add(this.groupBoxYolcuEkle);
            this.Controls.Add(this.groupBoxUcusOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxUcusOlustur.ResumeLayout(false);
            this.groupBoxUcusOlustur.PerformLayout();
            this.groupBoxYolcuEkle.ResumeLayout(false);
            this.groupBoxYolcuEkle.PerformLayout();
            this.groupBoxBiletBilgileri.ResumeLayout(false);
            this.groupBoxBiletBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUcak;
        private System.Windows.Forms.ComboBox comboBoxBaslangic;
        private System.Windows.Forms.ComboBox comboBoxVaris;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.TextBox textBoxUcret;
        private System.Windows.Forms.Button buttonUcusOlustur;
        private System.Windows.Forms.GroupBox groupBoxUcusOlustur;
        private System.Windows.Forms.TextBox textBoxUcusKodu;
        private System.Windows.Forms.Label labelUcret;
        private System.Windows.Forms.Label labelUcusKodu;
        private System.Windows.Forms.GroupBox groupBoxYolcuEkle;
        private System.Windows.Forms.Label labelNereye;
        private System.Windows.Forms.Label labelNereden;
        private System.Windows.Forms.TextBox textBoxNereye;
        private System.Windows.Forms.TextBox textBoxNereden;
        private System.Windows.Forms.Label labelKodlar;
        private System.Windows.Forms.ComboBox comboBoxUcuslar;
        private System.Windows.Forms.Label labelKisiler;
        private System.Windows.Forms.ComboBox comboBoxKisiler;
        private System.Windows.Forms.Label labelKoltuk;
        private System.Windows.Forms.ComboBox comboBoxKoltuk;
        private System.Windows.Forms.Button buttonYolcuEkle;
        private System.Windows.Forms.GroupBox groupBoxBiletBilgileri;
        private System.Windows.Forms.Label labelUcus;
        private System.Windows.Forms.Label labelYolcu;
        private System.Windows.Forms.Label labelUcakKod;
        private System.Windows.Forms.Label labelVaris;
        private System.Windows.Forms.Label labelBaslangic;
    }
}

