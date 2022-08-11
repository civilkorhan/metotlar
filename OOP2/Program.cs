using System;

namespace OOP2
{
     class Program
    {
        static void Main(string[] args)
        {   // Korhan DALMAZ müşterimiz bu durumda aşağıdaki durum geçerli..
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Ismi = "Korhan";
            musteri1.Soyismi = "Dalmaz";
            musteri1.TcNo = "121221231";

            // Dalmaz Market tüzel müşteridir bu durumda aşağıdaki geçerli..
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "Dalmaz Market";
            musteri2.MusteriNo = "54321";
            musteri2.VergiNo = "123456789";


            Musteri musteri3 = new GercekMusteri(); //new lediğimiz de referens no aldı
            Musteri musteri4 = new TuzelMusteri();  // musteri class'ı hem gerçek hem de tüzel müşteri referansını alabildi..
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);  // miras bırakan ebeveynlik yapan base class onun mirasını paylaşan inherid eden  class'ın referansını tutabilir..
            // base sınıf referans tutucudur.

            // Müşteri Gerçel-Müşteri Tüzel
            //SOLID
        }
    }
}
