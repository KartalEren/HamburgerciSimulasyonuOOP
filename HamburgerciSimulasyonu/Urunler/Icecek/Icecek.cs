using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler.Icecek
{
    public abstract class Icecek : Urun
    {
        public Tip IcecekTipi { get; set; }
    }
}
