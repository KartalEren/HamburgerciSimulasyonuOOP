using HamburgerciSimulasyonu.Urunler.HamburgerCesitleri.HamburgerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri
{
    public class DoubleTavukBurger : Hamburger
    {



        public DoubleTavukBurger()
        {
            HamburgerMalzemeleri = new List<Malzeme>() { new Domates(),new Sogan(), new Marul(), new Cheedar(),new Ketcap(),new Mayonez
                (),new Domates(),new TavukEti(),new TavukEti(),new HamburgerEkmegi()};
            HazirlanmaSuresi = 10;
            BegenilmeOrani = 70 / 100;

        }
    }
}
