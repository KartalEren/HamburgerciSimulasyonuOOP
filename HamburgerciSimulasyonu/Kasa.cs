using HamburgeerciSimulasyonu.Menuler;
using HamburgeerciSimulasyonu.Personeller;
using HamburgerciSimulasyonu.Urunler.YanUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu
{
    public class Kasa
    {
        public List<KasaPersoneli> KasaPersoneli { get; set; }

        private List<Menu> gunlukRapor;
        private List<YanUrunler> yanUrunGunlukRapor;



        public List<Menu> GunlukRapor
        {
            get
            { return this.gunlukRapor; }
            set
            { this.gunlukRapor = value; }
        }


        public List<YanUrunler> YanUrunGunlukRapor
        {
            get
            { return this.yanUrunGunlukRapor; }
            set
            { this.yanUrunGunlukRapor = value; }
        }


        public Kasa()
        {
            gunlukRapor = new List<Menu>();
            yanUrunGunlukRapor = new List<YanUrunler>();
        }



    }
}
