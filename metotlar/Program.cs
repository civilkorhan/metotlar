using System;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyatı = 15;
            product1.Açıklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Sucuk";
            product2.Fiyatı = 115;
            product2.Açıklama = "Kayseri Sucuğu";

            Product[]products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyatı);
                Console.WriteLine(product.Açıklama);
                Console.WriteLine("----------");
            }
            Console.WriteLine("***METOTLAR***");
            Console.WriteLine();
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("Muz", "İyi Muz", 19, 38);
            Console.Read();
        }
    }

}

