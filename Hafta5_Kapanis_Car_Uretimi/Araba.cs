using System;

namespace Hafta5_Kapanis_Car_Uretimi
{
    public class Araba
    {
        public int KapiSayisi { get; set; }
        public string Marka { get; set; }
        public string Renk { get; set; }
        public string Model { get; set; }
        public DateTime UretimTarihi { get; private set; }
        public string SeriNumarasi { get; set; }

        public Araba()
        {
            UretimTarihi = DateTime.Now;
        }
    }
}
