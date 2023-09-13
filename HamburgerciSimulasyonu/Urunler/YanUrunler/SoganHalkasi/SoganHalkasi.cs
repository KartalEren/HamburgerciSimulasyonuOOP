using HamburgeerciSimulasyonu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciSimulasyonu.Urunler.YanUrunler.SoganHalkalari
{
    public abstract class SoganHalkasi : YanUrunler
    {
        public SoganHalkaSayisi SoganHalkaSayisi { get; set; }


        public SoganHalkasi(SoganHalkaSayisi soganHalkaSayisi)
        {
            SoganHalkaSayisi = soganHalkaSayisi;



        }
    }
}
