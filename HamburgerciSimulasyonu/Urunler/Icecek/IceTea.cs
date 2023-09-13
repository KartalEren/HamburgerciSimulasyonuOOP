using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler.Icecek
{
    public class IceTea : Icecek
    {
        public IceTea(Boyut urunBoyutu, Tip icecekTipi)
        {

            HazirlanmaSuresi = 1;
            UrunBoyutu = urunBoyutu;
            BegenilmeOrani = 90;
            IcecekTipi = icecekTipi;
        }
    }
}
