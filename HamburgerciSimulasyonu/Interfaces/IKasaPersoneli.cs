using HamburgeerciSimulasyonu;
using HamburgeerciSimulasyonu.Menuler;
using HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri;
using HamburgerciSimulasyonu.Urunler.HamburgerCesitleri.HamburgerMalzemeleri;
using HamburgerciSimulasyonu.Urunler.YanUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciSimulasyonu.Interfaces
{
    public interface IKasaPersoneli
    {
        public void MusteridenSiparisAl(Musteri musteri);
        Menu SiparisiIlet();
        decimal ToplamMenuUcretiniAl(Menu menu, YanUrunler yanUrunler);
        void IcecekVePatatesKizartmasiBoyutunuDegistir(Menu menu);
        void MenudenUrunCikar(Hamburger hamburger, Malzeme malzeme);

        public void MusteridenYanUrunSiparisAl(Musteri musteri);

        public YanUrunler YanUrunSiparisiIlet();
    }
}
