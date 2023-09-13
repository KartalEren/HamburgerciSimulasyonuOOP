using HamburgeerciSimulasyonu.Menuler;
using HamburgeerciSimulasyonu.Personeller;
using HamburgerciSimulasyonu.Urunler.YanUrunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciSimulasyonu.Interfaces
{
    public interface IServisElemani
    {
        void KasaPersonelindenSiparisAl(KasaPersoneli kasaPersoneli);
        void MolayaCik(object value);
        Menu SiparisHazirlaVeTeslimEt();
        ServisPersoneli MoladanDon();
        public void KasaPersonelindenYanUrunSiparisAl(KasaPersoneli kasaPersoneli);
        public YanUrunler YanUrunlerSiparisHazirlaVeTeslimEt();
    }
}
