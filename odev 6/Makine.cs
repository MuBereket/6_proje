using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_6
{
    public class Makine
    {
       private String MakineAdi;
        private String Tarih;
        private int HedafMiktar;
        private int UretilenMiktar;

        public Makine(string makineAdi, string tarih, int hedafMiktar, int uretilenMiktar)
        {
            MakineAdi1 = makineAdi;
            Tarih1 = tarih;
            HedafMiktar1 = hedafMiktar;
            UretilenMiktar1 = uretilenMiktar;
        }

        public string MakineAdi1 { get => MakineAdi; set => MakineAdi = value; }
        public string Tarih1 { get => Tarih; set => Tarih = value; }
        public int HedafMiktar1 { get => HedafMiktar; set => HedafMiktar = value; }
        public int UretilenMiktar1 { get => UretilenMiktar; set => UretilenMiktar = value; }
        public override string ToString()
        {
            return $"Adi: {MakineAdi}, Tarih: {Tarih}, Baslangic: {HedafMiktar}, Bitis: {UretilenMiktar}";
        }
    }
}
