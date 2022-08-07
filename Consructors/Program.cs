using System;

namespace Consructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1,FirsName="Korhan",LastName="Dalmaz" ,City="Kayseri"};
        }
    }
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");
            
        }
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
