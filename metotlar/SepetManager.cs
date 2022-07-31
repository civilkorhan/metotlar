using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class SepetManager
    {
      
        // metoda parametre ekliyoruz
        public void Ekle(Product product)
        {
            System.Console.WriteLine("Sepete Eklendi:"+product.Adi);
            }
        public void Ekle2(String Adi, String Acıklama, int Fiyatı, int StokAdedi)
        {
            Console.WriteLine("Sepete Eklendi:" + Adi);
        }
    }
}
