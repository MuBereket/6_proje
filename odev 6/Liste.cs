using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_6
{
    public class Liste
    {
        List<Makine> Makineler;
        public StreamReader sr { get; set; }
        public string[] kume { get; set; }
        public List<string> MakineAdi { get => makineAdi; set => makineAdi = value; }
        public List<string> Tarih { get => tarih; set => tarih = value; }
        public List<string> HedafMiktar { get => hedafMiktar; set => hedafMiktar = value; }
        public List<string> UretilenMiktar { get => uretilenMiktar; set => uretilenMiktar = value; }

        List<string> makineAdi;
        List<string> tarih;
        List<string> hedafMiktar;
        List<string> uretilenMiktar;
        public Liste()
        {
            
            string cs ="Data.txt";
            var fs = new FileStream(cs, FileMode.OpenOrCreate);
            fs.Close();
            sr = new StreamReader(cs);
            MakineAdi = new List<string>();
            Tarih = new List<string>();
            HedafMiktar = new List<string>();
            UretilenMiktar = new List<string>();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                kume = line.Split(',');
                MakineAdi.Add(kume[0]);
                Tarih.Add(kume[1]);
                HedafMiktar.Add(kume[2]);
                UretilenMiktar.Add(kume[3]);

            }
            sr.Close();

        }

    
    }
}
