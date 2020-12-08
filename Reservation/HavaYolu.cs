using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class HavaYolu
    {
        public string Sirket { get; set; }
        public Ucak Filo { get; set; }
        public HavaYolu(string sirket)
        {
            Sirket = sirket;
        }
    }
}
