using HamburgeerciSimulasyonu.Urunler;
using HamburgeerciSimulasyonu.Urunler.HamburgerCesitleri;
using HamburgeerciSimulasyonu.Urunler.Icecek;


namespace HamburgeerciSimulasyonu.Menuler
{
    public class Menu1 : Menu
    {
       
        public Menu1(Icecek icecek)
        {
            MenuUrunleri = new List<Urun>() { new TavukBurger(), new PatatesKizartmasi(Boyut.Normal) };
            Icecek = icecek;
            Fiyat = 90;
            MenuHazirlikSuresi = 30;
        }





    }
}
