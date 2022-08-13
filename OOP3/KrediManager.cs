using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     interface IKrediManager //I ile başlatık ki interface olduğunu anlayalım..
                             // interface= ara yüz demek ve aşağıdaki şablona uymalıdır diyoruz..
                             // interface genellikle operasyonlarda kullanıyoruz..
                             // interface ler de kendisini imlament eden mirasını alan class ın referansını tutabilir
                             // interface ler birbirinin alternatifi olan ama içeriği farklı olan durumlarda kullanılır..
                             // inerface lere service deriz..
    {
        void Hesapla();
        void BiSeyYap();
        

        
    }
}

