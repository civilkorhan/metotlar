using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //string[]isimler=new string[] {"Korhan","Yalçın","Tarık","Furkan"};
          //  Console.WriteLine(isimler[0]);
          //  Console.WriteLine(isimler[1]);
          //  Console.WriteLine(isimler[2]);
          //  Console.WriteLine(isimler[3]);

          //  isimler = new string[5];  //ctrlk+ctrlc toplu comment satırı için
          //  isimler[4] = "Şevval";    //geri almak için ctrlk+ctrlu

            List<string>isimler2=new List<string> { "Korhan","Yalçın","Tarık","Furkan"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Şevval");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
