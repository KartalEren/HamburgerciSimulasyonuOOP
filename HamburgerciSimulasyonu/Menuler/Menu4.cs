using HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri;
using HamburgeerciSimulasyonu.Urunler.Icecek;
using HamburgeerciSimulasyonu.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HamburgeerciSimulasyonu.Menuler
{
    public class Menu4 : Menu
    {

  
        public Menu4(Icecek icecek)
        {
            MenuUrunleri = new List<Urun>() { new DoubleKofteBurger(), new PatatesKizartmasi(Boyut.Normal) };
            Icecek = icecek;
            Fiyat = 150;
            MenuHazirlikSuresi = 45;
        }

    }
}
