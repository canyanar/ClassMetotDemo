using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri banka listesine eklendi:" +" " + musteri.Adi + " " + musteri.SoyAdi + " " + musteri.IdNumber + " " + musteri.Yasi );
        }
        public void bulParaMiktari(Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi + " " + musteri.SoyAdi + " " + musteri.IdNumber + " " + musteri.Yasi + " " + musteri.ParaMiktari);
        }
        public void bulKrediBilgi(Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi + " " + musteri.SoyAdi + " " + musteri.IdNumber + " " + musteri.Yasi + " " + musteri.ParaMiktari + " " + musteri.KrediNotu + " " + musteri.KartÇeşidi);
        }
        public void sil(Musteri musteri) 
        {
            Console.WriteLine("Müşteri banka listesinden silindi:" + " " + musteri.Adi + " " + musteri.SoyAdi + " " + musteri.IdNumber );
        }
        public void listele(Musteri musteri)
        {
            Console.WriteLine("Eklenen müşteriler listelendi!!");
            Console.WriteLine("-" + " " + musteri.Adi + " " + musteri.SoyAdi + " " + musteri.IdNumber);
        }
    }
}
