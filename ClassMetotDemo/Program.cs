using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Efecan";
            musteri1.Soyad = "Bayat";
            musteri1.Yas = 24;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Mücahit";
            musteri2.Soyad = "Düz";
            musteri2.Yas = 24;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Onur";
            musteri3.Soyad = "Temel";
            musteri3.Yas = 24;

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Sil(musteri2);

            musteriManager.Listele();

            
        }
    }
}
