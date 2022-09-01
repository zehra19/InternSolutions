using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosyalYardimPaymentForm.DTO
{ 
    public class ApiSosyalOdeme
    {
        public int odemeNo { get; set; }
        public string tckn { get; set; }
        public string adi { get; set; }
        public string soyAdi { get; set; }
        public int odemeKd { get; set; }
        public float odenecekTtr { get; set; }
        public DateTime odenecekDt { get; set; }
    }

}