using System;
using System.Collections.Generic;

namespace Generickss
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            sehirler.Add("Kayseri");
            MyList<string> sehirler2 = new MyList<string>();
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Ankara");

        }
    }
    class MyList<T> //Generick Class

    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T items)
        {
            _tempArray = _array;
           _array=new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _tempArray[i] = _array[i];
            }
            _array[_array.Length-1] = items;
        }
       

        public int Count
        {
            get { return _array.Length; }
           
        }


    }
}
