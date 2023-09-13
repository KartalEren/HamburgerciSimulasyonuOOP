using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler
{
    public class PatatesKizartmasi : Urun
    {
        public PatatesKizartmasi(Boyut urunBoyutu)
        {
            HazirlanmaSuresi = 30;
            BegenilmeOrani = 80 / 100;
            UrunBoyutu = urunBoyutu;
        }
    }
}
