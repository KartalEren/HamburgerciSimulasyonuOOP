using HamburgeerciSimulasyonu.Exceptions;
using HamburgeerciSimulasyonu.Menuler;
using HamburgeerciSimulasyonu.Urunler;
using HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri;
using HamburgeerciSimulasyonu.Urunler.Icecek;
using HamburgerciSimulasyonu.Exceptions;
using HamburgerciSimulasyonu.Interfaces;
using HamburgerciSimulasyonu.Urunler.HamburgerCesitleri.HamburgerMalzemeleri;
using HamburgerciSimulasyonu.Urunler.YanUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Personeller
{
    public class KasaPersoneli : Personel, IKasaPersoneli
    {
        private bool buyukBoyMu;
        private bool servisElemanlariBosMu;
        private bool buyukBoyIsterMisin;
        private bool yanUrunIsterMisin;

        private List<Menu> Siparisler = new List<Menu>();
        private List<YanUrunler> YanUrunSiparisleri;
        private bool yanUrunVarMi;

        public KasaPersoneli() : base(Gorev.KasaPersoneli)
        {
            Siparisler = new List<Menu>();
        }


        public Kasa Kasa { get; set; }
        public void MusteridenSiparisAl(Musteri musteri)
       
        {
            if (!servisElemanlariBosMu)
            {
                throw new BostaServisElemaniYokException();
            }
            if (buyukBoyIsterMisin)
            {
                IcecekVePatatesKizartmasiBoyutunuDegistir(musteri.SiparisVer());
            }
            Siparisler.Add(musteri.SiparisVer());
            Kasa.GunlukRapor.Add(musteri.SiparisVer());


        }



        public Menu SiparisiIlet()
        {
            if (Siparisler.Count == 0)
            {
                throw new YeniSiparisYokException();
            }
            Menu yenisiparis = Siparisler[0];
            Siparisler.Remove(yenisiparis);
            return yenisiparis;

        }



        public void MusteridenYanUrunSiparisAl(Musteri musteri)
        {
            YanUrunSiparisleri.Add(musteri.YanUrunSiparisVer());
            Kasa.YanUrunGunlukRapor.Add(musteri.YanUrunSiparisVer());
        }


        public YanUrunler YanUrunSiparisiIlet()
        {
            if (YanUrunSiparisleri.Count == 0)
            {
                throw new YeniSiparisYokException();
            }
            YanUrunler yenisiparis = YanUrunSiparisleri[0];
            YanUrunSiparisleri.Remove(yenisiparis);
            return yenisiparis;

        }




        public decimal ToplamMenuUcretiniAl(Menu menu, YanUrunler yanUrunler)
        {
            decimal fiyat = menu.Fiyat;

            if (buyukBoyMu)
            {
                fiyat += menu.BuyukBoyFiyatFarki;
            }
            if (yanUrunVarMi)
            {
                fiyat += yanUrunler.Fiyat;
            }

            return fiyat;
        }


        public void IcecekVePatatesKizartmasiBoyutunuDegistir(Menu menu) 
        {
            menu.Icecek.UrunBoyutu = Boyut.Buyuk;
            menu.MenuUrunleri[1].UrunBoyutu = Boyut.Buyuk;


        }
        public void MenudenUrunCikar(Hamburger hamburger, Malzeme malzeme)
        {
            if (hamburger.HamburgerMalzemeleri.Contains(malzeme))
            {
                hamburger.HamburgerMalzemeleri.Remove(malzeme);
            }
            else
            {

                throw new HamburgerIcindeBuMalzemeYokException();
            }







        }

        
    }
}
