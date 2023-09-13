using HamburgerciSimulasyonu.Urunler.HamburgerCesitleri.HamburgerMalzemeleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri
{
    public class DoubleKofteBurger : Hamburger
    {
        public DoubleKofteBurger()
        {
            HamburgerMalzemeleri = new List<Malzeme>() { new Domates(),new Sogan(), new Marul(), new Cheedar(),new Ketcap(),new Mayonez
                (),new Domates(),new Kofte(),new Kofte(),new HamburgerEkmegi()};
            HazirlanmaSuresi = 30;
            BegenilmeOrani = 80 / 100;


        }
    }
}
