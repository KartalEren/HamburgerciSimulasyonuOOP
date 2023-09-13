using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgeerciSimulasyonu.Personeller
{
    public abstract class Personel
    {
        public Gorev Gorev { get; set; }
        public Personel(Gorev gorev)
        {
            Gorev = gorev;
    }
}
