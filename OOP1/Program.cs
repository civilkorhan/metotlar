using System;

namespace OOP1
{
     class Program
    {
        static void Main(string[] args)
        {
           Product product1=new Product(); //101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { UnitsInStock = 3, Id = 1, UnitPrice = 35,ProductName="Kalem" ,CategoryId=5};
            //PascalCase   //camelCase
            //case sensitive:büyük küçük harf duyarlılığı demek
            //sağ taraf heap kısmı sol taraf stack kısmı
          //  ProductManager productManager=new ProductManager();
            // add'in yanındaki parantez içi ne ekleyeceğini gösterir.
          //  productManager.Add(product1); //101
           // Console.WriteLine(product1.ProductName);//kamera yazdırır


           // int sayi = 100;
           // productManager.BiSeyYap(sayi);
           // Console.WriteLine(sayi);//100 yazdırır
           ProductManager productManager=new ProductManager();
            productManager.Add(product1);
            productManager.Uptade(product1);

            
        }
    }
}
