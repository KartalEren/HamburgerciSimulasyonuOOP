using HamburgerciSimulasyonu.Urunler.HamburgerCesitleri;
using HamburgerciSimulasyonu.Urunler.HamburgerCesitleri.HamburgerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri
{
    public class TavukBurger : Hamburger
    {
        public TavukBurger() 
        {
            HamburgerMalzemeleri = new List<Malzeme>() { new Domates(),new Sogan(), new Marul(), new Cheedar(),new Ketcap(),new Mayonez
                (),new Domates(),new TavukEti(),new HamburgerEkmegi()};
            HazirlanmaSuresi = 5;
            BegenilmeOrani = 60 / 100;
        }
    }
}
