using HamburgerciSimulasyonu.Urunler.HamburgerCesitleri.HamburgerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri
{
    
    public abstract class Hamburger : Urun
    {
        public List<Malzeme> HamburgerMalzemeleri { get; set; }

    }
}
