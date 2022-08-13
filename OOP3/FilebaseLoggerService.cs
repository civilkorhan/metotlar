using System;

namespace OOP3
{
    class FilebaseLoggerService : ILoggerService   //loglama gerçekleştirelen etkinliğin kayıt altına alınması demektir..

    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
