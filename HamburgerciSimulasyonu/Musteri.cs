using HamburgeerciSimulasyonu.Menuler;
using HamburgeerciSimulasyonu.Personeller;
using HamburgerciSimulasyonu.Interfaces;
using HamburgerciSimulasyonu.Urunler.YanUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu
{
    public class Musteri : IMusteri
    {

        public Menu MenuTipi { get; set; }

        public Menu Siparisim { get; set; }

        public YanUrunler YanUrunlerTipi { get; set; }

        public decimal MusteriParasi { get; set; }

        public decimal KrediKartiBakiyesi { get; set; }




        public Menu SiparisVer()
        {
            return this.MenuTipi;
        }


        public void ToplamUcretiOde(KasaPersoneli kasaPersoneli, Menu menu, YanUrunler yanUrunler, OdemeYontemleri odemeYontemleri)
        {
            if (OdemeYontemleri.Nakit == odemeYontemleri)
            {
                this.MusteriParasi -= kasaPersoneli.ToplamMenuUcretiniAl(Siparisim, YanUrunlerTipi);
                
            }
            else
            {
                this.KrediKartiBakiyesi -= kasaPersoneli.ToplamMenuUcretiniAl(Siparisim, YanUrunlerTipi);
            }




        }



        public void SiparisiTeslimAl(ServisPersoneli servisPersoneli)
        {
            this.Siparisim = servisPersoneli.SiparisHazirlaVeTeslimEt();
        }



        public YanUrunler YanUrunSiparisVer()
        {
            return this.YanUrunlerTipi;
        }

        public void SiradaBekle()
        {

        }

    }


}
