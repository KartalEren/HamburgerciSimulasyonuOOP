using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler.Icecek
{
    internal class Sprite : Icecek
    {
        public Sprite(Boyut urunBoyutu, Tip icecekTipi)
        {
            HazirlanmaSuresi = 1;
            UrunBoyutu = urunBoyutu;
            BegenilmeOrani = 80;
            IcecekTipi = icecekTipi;
        }
    }
}
