using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
     class DortIslem
    {
        public void Topla(int sayı1, int sayı2)
        {
            int toplam = sayı1 + sayı2;
            Console.WriteLine("Sonuç:" + toplam);
        }
        public void Çarp(int sayı1, int sayı2)
        {
            int çarpım = sayı1 * sayı2;
            Console.WriteLine("Sonuç:" + çarpım);
        }

    }
}
