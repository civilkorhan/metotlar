using System;

namespace OOP3
{
    class SmsbaseLoggerService : ILoggerService   //loglama gerçekleştirelen etkinliğin kayıt altına alınması demektir..

    {
        public void Log()
        {
            Console.WriteLine("Mesaja Loglandı");
        }
    }
}
