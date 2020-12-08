using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class Yolcu
    {
        public int KoltukSiraNo { get; set; }
        public Kisi OturanKisi { get; set; }
        public string UcusKodu { get; set; }
        public Yolcu(int siraNo, Kisi oturanKisi)
        {
            KoltukSiraNo = siraNo;
            OturanKisi = oturanKisi;
        }
    }
}
