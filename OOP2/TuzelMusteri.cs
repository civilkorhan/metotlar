using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{  //Coorpered=Tüzel Müşteri   
    //implementation=uygulama demek
    // miras=inharitions
    class TuzelMusteri:Musteri   //musterinin içinde olan tüm özellikelr tuzelmusteride de var demektir..
    {
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }

    
    }
}
