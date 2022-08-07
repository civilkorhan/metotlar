using System;

namespace ReferenceTypes
{
   class Program
    {
        static void Main(string[] args)
        {   //int,double,boolen,float değer tiptir
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 30;
            Console.WriteLine(sayi1);//20

            //array,class,interface.. referans tiptir
            int[]sayilar1=new int[] {1,2,3};
            int[]sayilar2=new int[] {10,20,30};
            sayilar1 = sayilar2;
            sayilar2[0] = 99;
            Console.WriteLine(sayilar1[0]);//99

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Korhan";
            person2 = person1;  //adres eşitlemesi yaptık adresleri aynı
            person1.FirstName = "Yeşim";
            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Şevval";
            Employee employee = new Employee();
            employee.FirstName = "Coşkun";

            //customer=employee YAPAMAZSIN İNT LE STRİNGİ EŞİTLEMEK GİBİ OLUR!!!
            Person person3 = customer;
            
            //Console.WriteLine(person3.FirstName);//Şevval yazar

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);//Coşkun yazar
            personManager.Add(person1);//Yeşim yazar
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



    }
       
    class Customer:Person  //customer içinde aynı zamanda person özellikleri de vardır
    {
        public int CreditCard { get; set; }






    }
    class Employee : Person  // employee içinde aynı zamanda person özellikleri de vardır
    {
        public int EmployeeNumber { get; set; }


    }
    class PersonManager
    { public void Add(Person person)
        {
            Console.WriteLine(person.FirstName  );

        }



    }
}
