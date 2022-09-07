using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Adam";
            musteri1.Soyad = "Adamoğlu";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Adama";
            musteri2.Soyad = "Traure";
            musteri2.Id = 2;
            Console.WriteLine(musteri1.Ad);
            
            MusteriManager manager = new MusteriManager();
            manager.Add(musteri1);
            manager.Add(musteri2);

            manager.Delete(musteri1);
            manager.Delete(musteri2);

            manager.Kimlik(musteri1);
            manager.Kimlik(musteri2);
        }
         
    }




}


