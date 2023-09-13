using HamburgeerciSimulasyonu.Exceptions;
using HamburgeerciSimulasyonu.Menuler;
using HamburgerciSimulasyonu.Exceptions;
using HamburgerciSimulasyonu.Interfaces;
using HamburgerciSimulasyonu.Urunler.YanUrunler;

namespace HamburgeerciSimulasyonu.Personeller
{
    public class ServisPersoneli : Personel, IServisElemani
    {
        private bool yanUrunSiparisHazirMi;
        private List<Menu> ServisBolumuSiparisleri;
        private List<YanUrunler> ServisBolumuYanUrunSiparisleri;
        public ServisPersoneli() : base(Gorev.KasaPersoneli)
        {
            ServisBolumuSiparisleri = new List<Menu>();
        }
        public void KasaPersonelindenSiparisAl(KasaPersoneli kasaPersoneli)
        {
            try
            {
                Menu yeniSiparis = kasaPersoneli.SiparisiIlet();
                ServisBolumuSiparisleri.Add(yeniSiparis);
              
            }
            catch (YeniSiparisYokException)
            {

                MolayaCik(this);
            }

        }


        public Menu SiparisHazirlaVeTeslimEt()
        {

            if (ServisBolumuSiparisleri.Count == 0)
            {
                throw new YeniSiparisYokException();

            }

            if (yanUrunSiparisHazirMi)
            {
                Menu hazirSiparis = ServisBolumuSiparisleri[0];

                ServisBolumuSiparisleri.Remove(hazirSiparis);
                return hazirSiparis;
            }
            else
            {
                throw new SiparisHazirDegilException();

            }

        }



        public void KasaPersonelindenYanUrunSiparisAl(KasaPersoneli kasaPersoneli)
        {
            try
            {
                ServisBolumuYanUrunSiparisleri.Add(kasaPersoneli.YanUrunSiparisiIlet());

            }
            catch (YeniSiparisYokException)
            {

                MolayaCik(this);
            }

        }


        public YanUrunler YanUrunlerSiparisHazirlaVeTeslimEt()
        {

            if (ServisBolumuYanUrunSiparisleri.Count == 0)
            {
                throw new YeniSiparisYokException();

            }

            if (yanUrunSiparisHazirMi)
            {
                YanUrunler yanUrunHazirSiparis = ServisBolumuYanUrunSiparisleri[0];

                ServisBolumuYanUrunSiparisleri.Remove(yanUrunHazirSiparis);
                return yanUrunHazirSiparis;
            }
            else
            {
                throw new SiparisHazirDegilException();

            }

        }


        public ServisPersoneli MoladanDon()
        {
            ServisPersoneli servisPersoneli = new ServisPersoneli();
            return servisPersoneli;
        }

        public void MolayaCik(object value)
        {
            value = null;
        }

    }
}
