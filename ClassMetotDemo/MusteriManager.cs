using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //İKİNCİ KULLANIM MANAGER'I
        //Takip fonksiyonunun parametrelerine veri türleri dahil gerekenleri yazdık.
        //Fonksiyon içini yazdık.
        public void Takip(string Id, string Ad, string Soyad)
        {
            Console.WriteLine("Kullanıcı adınız: " + Id);
            Console.WriteLine("Adınız: " + Ad);
            Console.WriteLine("Soyadınız: " + Soyad);
            Console.WriteLine("");
        }

        //ÜÇÜNCÜ KULLANIM MANAGER'I
        //Takip fonksiyonunun içine alınması gereken bilgi yazılır.
        //Fonksiyon içini yazarız.
        public void Takip2(Musteri musteri)
        {
            Console.WriteLine("Kullanıcı adınız: " + musteri.Id);
            Console.WriteLine("Adınız: " + musteri.Ad);
            Console.WriteLine("Soyadınız: " + musteri.Soyad);
            Console.WriteLine("");
        }
    }
}
