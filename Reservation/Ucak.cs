using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class Ucak
    {
        public string Kod { get; set; }
        public int Kapasite { get; set; }
        public Ucak(string kodu, int kapasite)
        {
            this.Kod = kodu;
            this.Kapasite = kapasite;
        }
    }
}
