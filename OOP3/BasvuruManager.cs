using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            
            krediManager.Hesapla();  //spesifik bir kredi türü seçmedik onların tümüne miras bırakan ebeveyn base olan IKrediManger ı seçtik..
                                     // şu anda barındırdığımız kredileri gönderebiliriz..
                                     //TasıtKrediManager tasıtKrediManager=new TasıtKrediManager();
                                     //tasıtKrediManager.Hesapla(); // yapmış olsaydım basvuru yapılan bütün kredileri tasıt kredisi üzerinden hesaplardım ve bu da yanlış olurdu..
            loggerService.Log();
        }
        public void KrediOnBilgilendirme(List<IKrediManager> krediler)  //burada tek bir seçenek yok o yüzden liste kullandık..
                                                                        //  IKrediManager lsitenin türüdür int gibi string gibi..
                                                                        //krediler yazısı nesne durumunda..
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();     // her bir kredi için hesaplamasını yap dedik..
                
            }

        }
    }
}
