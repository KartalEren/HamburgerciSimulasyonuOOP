using HamburgeerciSimulasyonu.Menuler;
using HamburgeerciSimulasyonu.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciSimulasyonu.Interfaces
{
    public interface IMusteri
    {
        Menu SiparisVer();

        void SiparisiTeslimAl(ServisPersoneli servisPersoneli);

        void SiradaBekle();


    }
}
