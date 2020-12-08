using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class Ucus
    {
        public HavaLimani Baslangic;
        public HavaLimani Varis;
        public string UcusKodu { get; set; }
        public Ucak Ucak { get; set; }
        public decimal Ucret { get; set; }
        public DateTime Tarih { get; set; }
        public Yolcu Yolcu { get; set; }
        public Ucus(HavaLimani baslangic, HavaLimani varis, string kodu, Ucak ucak, decimal ucret, DateTime tarih)
        {
            Baslangic = baslangic;
            Varis = varis;
            UcusKodu = kodu;
            Ucak = ucak;
            Ucret = ucret;
            Tarih = tarih;
            
        }
    }
}
