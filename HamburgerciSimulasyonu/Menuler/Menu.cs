using HamburgeerciSimulasyonu.Urunler;
using HamburgeerciSimulasyonu.Urunler.Icecek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Menuler
{
    
    public abstract class Menu
    {

        public Icecek Icecek { get; set; }

        public decimal Fiyat { get; set; }

        public decimal BuyukBoyFiyatFarki { get; set; } = 20;

        public int MenuHazirlikSuresi { get; set; }

        public List<Urun> MenuUrunleri { get; set; }
    }
}
