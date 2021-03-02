using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();

        public void Ekle(Musteri musteri)
        {                      
            musteriler.Add(musteri);
            Console.WriteLine("Müşteri Eklendi : " + " " + musteri.Ad);
        }

        public void Sil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Müşteri Silindi : " + " " + musteri.Ad);
        }

        public void Listele()
        {
            Console.WriteLine("----------------Müşteri Listesi----------------");
            foreach (Musteri musteri in musteriler)
            {
                
                Console.WriteLine("Id :" + " " + musteri.Id);
                Console.WriteLine("Ad :" + " " + musteri.Ad);
                Console.WriteLine("Soyad :" + " " + musteri.Soyad);
                Console.WriteLine("Yas :" + " " + musteri.Yas);
                Console.WriteLine("--------------");
            }
        }

    }
}
