using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler
{
   
    public abstract class Urun
    {
        public int HazirlanmaSuresi { get; set; }
        public int BegenilmeOrani { get; set; }

        public Boyut UrunBoyutu { get; set; }

       
    }
}
