using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciSimulasyonu.Exceptions
{
    public class HamburgerIcindeBuMalzemeYokException : Exception
    {
        public HamburgerIcindeBuMalzemeYokException() : base("Hamburger içinde seçtiğininz malzeme bulunmuyor!")
        {

        }
    }
}
