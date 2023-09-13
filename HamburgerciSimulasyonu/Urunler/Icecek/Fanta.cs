using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler.Icecek
{
    public class Fanta : Icecek
    {
        public Fanta(Boyut urunBoyutu, Tip icecekTipi)
        {
            HazirlanmaSuresi = 1;
            UrunBoyutu = urunBoyutu;
            BegenilmeOrani = 70;
            IcecekTipi = icecekTipi;
        }

    }
}
