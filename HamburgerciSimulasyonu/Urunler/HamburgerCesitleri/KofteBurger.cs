using HamburgerciSimulasyonu.Urunler.HamburgerCesitleri;
using HamburgerciSimulasyonu.Urunler.HamburgerCesitleri.HamburgerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri
{
    public class KofteBurger : Hamburger
    {
        public KofteBurger()
        {
            HamburgerMalzemeleri = new List<Malzeme>() { new Domates(),new Sogan(), new Marul(), new Cheedar(),new Ketcap(),new Mayonez
                (),new Domates(),new Kofte(),new HamburgerEkmegi()};
            HazirlanmaSuresi = 20;
            BegenilmeOrani = 80 / 100;
        }
    }
}
