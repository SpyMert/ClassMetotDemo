using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Add (Musteri musteri)//Müşteri class'ına ait bir müşteri parametresi yaz ayraçın içine. Örnek musteri1
        {
            Console.WriteLine("Adı:" + musteri.Ad + " " + "Soyadı:" + musteri.Soyad +" " + "müşteri eklendi!");//Sonra parametrede girdiğin elemanın adını soyadını bu şablona koy.
            
        }
        public void Delete(Musteri musteri)// sonucun bir değer olmadığı zamanlarda void kullanırız.
        {
            Console.WriteLine("Adı:" + musteri.Ad + " " + "Soyadı:" + musteri.Soyad + " " + "müşteri silindi!");
        }

        public void Kimlik(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Id + " ");
        }


    }
}
