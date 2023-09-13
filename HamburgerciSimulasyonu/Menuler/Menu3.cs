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
    public class Menu3 : Menu
    {

       
        public Menu3(Icecek icecek)
        {
            MenuUrunleri = new List<Urun>() { new KofteBurger(), new PatatesKizartmasi(Boyut.Normal) };
            Icecek = icecek;
            Fiyat = 130;
            MenuHazirlikSuresi = 40;
        }
    }
}
