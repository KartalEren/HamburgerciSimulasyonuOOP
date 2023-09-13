﻿using HamburgeerciSimulasyonu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciSimulasyonu.Urunler.YanUrunler.SoganHalkalari
{
    public class DortluSoganHalkasi : SoganHalkasi
    {
        public DortluSoganHalkasi() : base(SoganHalkaSayisi.Dortlu)
        {
            Fiyat = 15;
        }
    }
}
