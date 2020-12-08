using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VeriTabaniOlustur();
            UcusEkleEkraninaBagla();
            KisiYukle();
        }

      

        private void VeriTabaniOlustur()
        {
            //havalimanları oluştur
            HelperClass.HavalimaniOlustur("Denizli", "Denizli Havalimanı", "DEN");
            HelperClass.HavalimaniOlustur("İstanbul", "İstanbul Havalimanı", "IST");
            HelperClass.HavalimaniOlustur("Ankara", "Ankara Havalimanı", "ANK");

            //havayolu olustur
            HelperClass.HavaYoluOlustur("Turk Hava Yollari");
            HelperClass.HavaYoluOlustur("Pegasus");
            HelperClass.HavaYoluOlustur("Anadolu Jet");
            HelperClass.HavaYoluOlustur("Atlas");

            //ucaklari olustur
            HelperClass.UcakOlustur("U001", 100);
            HelperClass.UcakOlustur("U002", 100);
            HelperClass.UcakOlustur("U003", 200);
            HelperClass.UcakOlustur("U004", 20);
            HelperClass.UcakOlustur("U005", 300);
            HelperClass.UcakOlustur("U006", 200);
            HelperClass.UcakOlustur("U007", 50);
            HelperClass.UcakOlustur("U008", 100);

            //ucaklari havayolu sirketlerine ata
            HelperClass.UcakEkle(HelperClass.Ucaklar[0], HelperClass.HavaYollari[0]);
            HelperClass.UcakEkle(HelperClass.Ucaklar[1], HelperClass.HavaYollari[0]);
            HelperClass.UcakEkle(HelperClass.Ucaklar[2], HelperClass.HavaYollari[0]);
            HelperClass.UcakEkle(HelperClass.Ucaklar[3], HelperClass.HavaYollari[1]);
            HelperClass.UcakEkle(HelperClass.Ucaklar[4], HelperClass.HavaYollari[1]);
            HelperClass.UcakEkle(HelperClass.Ucaklar[5], HelperClass.HavaYollari[2]);
            HelperClass.UcakEkle(HelperClass.Ucaklar[6], HelperClass.HavaYollari[2]);
            HelperClass.UcakEkle(HelperClass.Ucaklar[7], HelperClass.HavaYollari[3]);

            //kişi oluştur
            HelperClass.KisiEkle("Ali", "Can", 123);
            HelperClass.KisiEkle("Veli", "Can", 345);
            HelperClass.KisiEkle("Mehmet", "Can", 678);
            HelperClass.KisiEkle("Ahmet", "Can", 901);

        }

        private void UcusEkleEkraninaBagla()
        {
           
            comboBoxBaslangic.DataSource = HelperClass.HavaLimanlari;
            //!!!gösterilebilmesi için HavaLimani sinifinin Isim adında property' si olmalı!!!!
            comboBoxBaslangic.DisplayMember = "Isim";
            //iki combobox ayni data source oldugugundan 
            comboBoxVaris.BindingContext = new BindingContext();
            comboBoxVaris.DataSource = HelperClass.HavaLimanlari;
            //!!!gösterilebilmesi için HavaLimani sinifinin Isim adında property' si olmalı!!!!
            comboBoxVaris.DisplayMember = "Isim";
            comboBoxUcak.DataSource = HelperClass.Ucaklar;
            //!!!gösterilebilmesi için Ucak sinifinin Kod adında property' si olmalı!!!!
            comboBoxUcak.DisplayMember = "Kod";
        }

        private void buttonUcusOlustur_Click(object sender, EventArgs e)
        {
            //arayüzden parametreleri al.
            HavaLimani baslangic = (HavaLimani)comboBoxBaslangic.SelectedItem;
            HavaLimani varis = (HavaLimani)comboBoxVaris.SelectedItem;
            Ucak ucak = (Ucak)comboBoxUcak.SelectedItem;
            string ucusKodu = textBoxUcusKodu.Text;
            DateTime tarih = dateTimePickerTarih.Value;
            decimal ucret = Convert.ToDecimal(textBoxUcret.Text);
            //ucus olustur

            HelperClass.UcusOlustur(baslangic, varis, ucusKodu, ucak, tarih, ucret);
            UcuslariYukle();

        }

        private void UcuslariYukle()
        {
            //degisikliklerin yansimasi icin datasource degistir. boylece yeniden yukleyecek
            //bu arada selectedindexchanged event i calismasin.
            comboBoxUcuslar.SelectedIndexChanged -= comboBoxUcuslar_SelectedIndexChanged;
            comboBoxUcuslar.DataSource = null;
            //eventi tekrar ekle.
            comboBoxUcuslar.SelectedIndexChanged += comboBoxUcuslar_SelectedIndexChanged;
            
            comboBoxUcuslar.DataSource = HelperClass.Ucuslar;
            //!!!gösterilebilmesi için Ucus sinifinin UcusKodu adında property' si olmalı!!!!
            comboBoxUcuslar.DisplayMember = "UcusKodu";            
        }

        private void KisiYukle()
        {
            //guncellemenin aninda yanismasi icin datasource
            comboBoxKisiler.DataSource = null;
            comboBoxKisiler.DataSource = HelperClass.Kisiler;
            comboBoxKisiler.DisplayMember = "IsimSoyisim";
        }

        
        private void comboBoxUcuslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucus secilenUcus = (Ucus)comboBoxUcuslar.SelectedItem;
            textBoxNereden.Text = secilenUcus.Baslangic.Sehir;
            textBoxNereye.Text = secilenUcus.Varis.Sehir;
            KoltukYukle(secilenUcus);
        }
        private void KoltukYukle(Ucus ucus)
        {
            comboBoxKoltuk.DataSource = null;
            comboBoxKoltuk.DataSource = HelperClass.BosKoltukListele(ucus);
        }

        private void buttonYolcuEkle_Click(object sender, EventArgs e)
        {
            Kisi kisi = (Kisi)comboBoxKisiler.SelectedItem;
            Yolcu yolcu = new Yolcu((int)comboBoxKoltuk.SelectedItem, kisi);
            Ucus ucus = (Ucus)comboBoxUcuslar.SelectedItem;
            HelperClass.YolcuEkle(ucus, yolcu);
            BiletBilgi(ucus, yolcu);
            UcuslariYukle();
        }

        private void BiletBilgi(Ucus ucus, Yolcu yolcu)
        {
            labelUcus.Text = ucus.UcusKodu + " kodlu ucusunuz " + ucus.Baslangic.Sehir + " den " + ucus.Varis.Sehir + " sehrinedir. Ucus Tarihi: " + ucus.Tarih.ToShortDateString();
            labelYolcu.Text = yolcu.OturanKisi.IsimSoyisim;
        }
        
    }
}
