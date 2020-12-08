using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    class HavaLimani
    {
        private string kodu;
        public string Kodu
        {
            get { return kodu; }
            set
            {
                if (value.Length > 3)
                {
                    MessageBox.Show("Havalimanı kodu sadece 3 karakterli olabilir.");
                }
                else
                {
                    kodu = value;
                }
            }
        }
        public string Isim { get; set; }
        public string Sehir { get; set; }
        public HavaLimani(string kodu, string ismi, string sehri)
        {
            this.Kodu = kodu;
            this.Isim = ismi;
            this.Sehir = sehri;
        }
    }
}
