using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.SoyAdi = "Canbaz";
            musteri1.IdNumber = 12762318;
            musteri1.Yasi = 45;
            musteri1.ParaMiktari = 25000;
            musteri1.KrediNotu = 1550;
            musteri1.KartÇeşidi = "Kredi Kartı";


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Baki";
            musteri2.SoyAdi = "Yılmaz";
            musteri2.IdNumber = 78532413;
            musteri2.Yasi = 25;
            musteri2.ParaMiktari = 156000;
            musteri2.KrediNotu = 1900;
            musteri2.KartÇeşidi = "Banka Kartı";


            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Cansu";
            musteri3.SoyAdi = "Eydir";
            musteri3.IdNumber = 65321438;
            musteri3.Yasi = 30;
            musteri3.ParaMiktari = 86000;
            musteri3.KrediNotu = 1640;
            musteri3.KartÇeşidi = "Ön Ödemeli Kartı";



            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Alev";
            musteri4.SoyAdi = "Türkkan";
            musteri4.IdNumber = 78631047;
            musteri4.Yasi = 45;
            musteri4.ParaMiktari = 200000;
            musteri4.KrediNotu = 1150;
            musteri4.KartÇeşidi = "Kredi Kartı";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAdi);
                Console.WriteLine(musteri.IdNumber);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.ParaMiktari);
                Console.WriteLine(musteri.KrediNotu);
                Console.WriteLine(musteri.KartÇeşidi);
                Console.WriteLine("---------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.ekle(musteri1);
            musteriManager.ekle(musteri2);
            musteriManager.ekle(musteri3);
            musteriManager.ekle(musteri4);

            Console.WriteLine("\nMüşterinin Para Miktarı Bilgisi");
            musteriManager.bulParaMiktari(musteri1);
            musteriManager.bulParaMiktari(musteri2);
            musteriManager.bulParaMiktari(musteri3);
            musteriManager.bulParaMiktari(musteri4);

            Console.WriteLine("\nMüşterinin Kredi Bilgisi");
            musteriManager.bulKrediBilgi(musteri1);
            musteriManager.bulKrediBilgi(musteri2);
            musteriManager.bulKrediBilgi(musteri3);
            musteriManager.bulKrediBilgi(musteri4);

            Console.WriteLine("\nMüşteri Listesi");
            for (int i = 0; i < musteriler.Length; i++)
            {
                musteriManager.listele(musteriler[i]);
            }

            Console.WriteLine("\nMüşteri Silme");
            musteriManager.sil(musteri1);


        }
    }
}
