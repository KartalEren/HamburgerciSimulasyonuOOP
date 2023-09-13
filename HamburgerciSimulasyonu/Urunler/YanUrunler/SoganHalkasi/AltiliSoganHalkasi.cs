using HamburgeerciSimulasyonu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciSimulasyonu.Urunler.YanUrunler.SoganHalkalari
{
    internal class AltiliSoganHalkasi : SoganHalkasi
    {
        public AltiliSoganHalkasi() : base(SoganHalkaSayisi.Altili)
        {
            Fiyat = 20;
        }
    }
}
