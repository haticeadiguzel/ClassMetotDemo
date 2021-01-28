using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****BİRİNCİ KULLANIM*****");
            Console.WriteLine(" ");
            //MusteriManager kullanılmadan sadece Musteri class'ı kullanarak yapabiliriz.
            //Musteri class'taki verileri yukarıdaki gibi yazarız.
            //Yazılanları bir diziye aktarırız.
            //Diziyi foreach döngüsü ile yazdırırız.

            Musteri musteri1 = new Musteri();
            musteri1.Id = "Adiguzel.dicle";
            musteri1.Ad = "Dicle";
            musteri1.Soyad = "Adıgüzel";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "Adiguzel.hatice";
            musteri2.Ad = "Hatice";
            musteri2.Soyad = "Adıgüzel";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "Ozdemir.umut";
            musteri3.Ad = "Umut";
            musteri3.Soyad = "Özdemir";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Kullanıcı adınız: " + musteri.Id);
                Console.WriteLine("Adınız: " + musteri.Ad);
                Console.WriteLine("Soyadınız: " + musteri.Soyad);
                Console.WriteLine("");
            }

            Console.WriteLine("*****İKİNCİ KULLANIM*****");
            Console.WriteLine(" ");
            //Bu kullanımda bir Musteri class'ına ek bir Manager class kullandık.
            //MusteriManager'daki İKİNCİ KULLANIM yorumunu oku.
            //Bu kullanımda tüm ifadeleri kendimiz parametre kısmına yazarız
            //En üstte yazılan uzun işlemlere gerek yoktur.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Takip("Adiguzel.dicle", "Dicle", "Adiguzel");
            musteriManager.Takip("Adiguzel.hatice", "Hatice", "Adiguzel");
            musteriManager.Takip("Odemir.umut", "Umut", "Özdemir");

            Console.WriteLine("*****ÜÇÜNCÜ KULLANIM*****");
            Console.WriteLine(" ");
            //Bu kullanımda bir Musteri class'ına ek bir Manager class kullandık.
            //MusteriManager'daki ÜÇÜNCÜ KULLANIM yorumunu oku.
            //Bu kullanımdada ilk kullanım gibi en üstteki ifadeleri tek tek yazmak gerekir.

            MusteriManager mustereriManager = new MusteriManager();
            mustereriManager.Takip2(musteri1);
            mustereriManager.Takip2(musteri2);
            mustereriManager.Takip2(musteri3);


        }
    }
}
