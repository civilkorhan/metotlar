using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager //Ürünle ilgili operasyonlar var demek
        //add yanındaki parantez string isim gibi düşün bu bana string türünde bi şey ver demektir.
        //encapsulatıon yaptık
    { public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+ " eklendi.");
         // product.ProductName="Kamera";

        }

        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }


       // public void BiSeyYap(int sayi)
      //  {
        //  sayi = 99;

       // }
    }
}
