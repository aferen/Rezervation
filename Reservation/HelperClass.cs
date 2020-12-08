using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    static class HelperClass
    {

        public static List<HavaLimani> HavaLimanlari = new List<HavaLimani>();
        public static List<HavaYolu> HavaYollari = new List<HavaYolu>();
        public static List<Ucak> Ucaklar = new List<Ucak>();
        public static List<Ucus> Ucuslar = new List<Ucus>();
        public static List<Yolcu> Yolcular = new List<Yolcu>();
        public static List<Kisi> Kisiler = new List<Kisi>();

        public static void HavalimaniOlustur(string sehir, string isim, string kod)
        {
            HavaLimani liman = new HavaLimani(kod, isim, sehir);
            HavaLimanlari.Add(liman);
        }

        public static void HavaYoluOlustur(string isim)
        {
            HavaYolu havaYolu = new HavaYolu(isim);
            HavaYollari.Add(havaYolu);
        }

        public static void UcakOlustur(string code, int kapasite)
        {
            Ucak ucak = new Ucak(code, kapasite);
            Ucaklar.Add(ucak);
        }

        public static void UcusOlustur(HavaLimani kalkis, HavaLimani varis, string ucusKodu, Ucak ucak, DateTime tarih, decimal ucret)
        {
            Ucus ucus = new Ucus(kalkis, varis, ucusKodu, ucak, ucret, tarih);
            Ucuslar.Add(ucus);
        }


        public static void YolcuEkle(Ucus ucus, Yolcu yolcu)
        {
            ucus.Yolcu = yolcu;
            Yolcular.Add(yolcu);
            yolcu.UcusKodu = ucus.UcusKodu;
        }

        //bir ucagı bir havayoluna ekle.
        public static void UcakEkle(Ucak ucak, HavaYolu havaYolu)
        {
            havaYolu.Filo = ucak;
        }


        public static void KisiEkle(string isim, string soyIsim, int id)
        {
            Kisi kisi = new Kisi(isim, soyIsim, id);
            Kisiler.Add(kisi);
        }


        //ucusa ait bos koltuklari listeler.
        //eğer bu metodu tamamlayamazsanız.
        //uçağın kapasitesi kadar int. değeri boş koltuklar
        //listesine ekleyin. Ancak puan kırılacak.
        public static List<int> BosKoltukListele(Ucus ucus)
        {
            List<int> bosKoltuklar = new List<int>();
            for (int i = 1; i < ucus.Ucak.Kapasite + 1; i++)
            {

                bosKoltuklar.Add(i);
            }

            if (Yolcular.Count() != 0)
            {
                foreach (Yolcu yolcu in Yolcular)
                {
                    if (yolcu.UcusKodu == ucus.UcusKodu)
                    {
                        bosKoltuklar.Remove(yolcu.KoltukSiraNo);
                    }
                }
            }
          
            return bosKoltuklar;
        }
    }
}
