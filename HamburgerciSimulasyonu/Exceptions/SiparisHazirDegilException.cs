﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciSimulasyonu.Exceptions
{
    public class SiparisHazirDegilException : Exception
    {
        public SiparisHazirDegilException() : base("Sipariş Hazır Değil!")
        {

        }
    }
}
