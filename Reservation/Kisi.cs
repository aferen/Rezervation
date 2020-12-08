using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class Kisi
    {
        private string Isim { get; set; }
        private string Soyisim { get; set; }
        public string IsimSoyisim
        {
            get
            {
                return Isim + " " + Soyisim;
            }
        }
        public int KimlikNo { get; set; }
        public Kisi(string isim, string soyisim, int no)
        {
            Isim = isim;
            Soyisim = soyisim;
            KimlikNo = no;
        }

    }
}
