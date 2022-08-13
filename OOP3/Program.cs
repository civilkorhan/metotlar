using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager(); //instance ettik kullanımı bu şekilde ..
           

            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            

            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService=new DatabaseLoggerService();   
            ILoggerService fileLoggerService=new FilebaseLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager,databaseLoggerService);  // şu anda basvuru yap metodunda süslü parantez içinde hesalama işlevi var onu yapacak ama ihtiyaç kredisine göre hesaplayacak
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsbaseLoggerService()); // burada direkt new ledik bize zaten burası lazım..

            //IKrediManager ıhtiyacKrediManager2 = new IhtiyacKrediManager(); //instance ettik kullanımı bu şekilde ..
            //ıhtiyacKrediManager.Hesapla();

            //IKrediManager tasıtKrediManager2 = new TasıtKrediManager();
            //tasıtKrediManager2.Hesapla();

            //IKrediManager konutKrediManager2= new KonutKrediManager();
            //konutKrediManager2.Hesapla();
            //polimorfizim ??

            //List<IKrediManager> krediler = new List<IKrediManager>() { }; // listemizi oluşturduk ama içi boş durumda hiçbir kredi türü yok süslü parantez içinde 
            List<IKrediManager> krediler = new List<IKrediManager>() { tasıtKrediManager};
            basvuruManager.KrediOnBilgilendirme(krediler); // parantez içine nesnemiz yazılır..
        }
    }
}
