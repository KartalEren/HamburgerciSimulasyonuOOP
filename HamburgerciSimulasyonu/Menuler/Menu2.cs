using HamburgeerciSimulasyonu.Urunler;
using HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri;
using HamburgeerciSimulasyonu.Urunler.Icecek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Menuler
{
    internal class Menu2 : Menu
    {
     
        public Menu2(Icecek icecek)
        {
            MenuUrunleri = new List<Urun>() { new DoubleTavukBurger(), new PatatesKizartmasi(Boyut.Normal) };//burada standart olan elemanları listeye gömmüş olduk, eğer ki istemediği ürün varsa indeksini belirtip çıkarabilsin diye.
            Icecek = icecek;
            Fiyat = 100;
            MenuHazirlikSuresi = 35;
        }
    }
}
