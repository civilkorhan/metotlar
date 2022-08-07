using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
  class MyDictionary<K,V>
    {
        KeyValuePair<K,V>[] items; // KeyValuePair int gibi string gibi bir veri tipidir.
        //ctor kullanarak consructor'ı oluşturduk
        public MyDictionary()
        {
            items = new KeyValuePair<K, V>[0];
        }
        public void Add(K _key, V _value) //K tipinde key,V tipinde value değeri ekle demiş olduk.
        {
            KeyValuePair<K, V>[] tempArray = items; // değerlerimizi tutması amacıyla geçici dizimizi oluşturduk.
            items=new KeyValuePair<K,V>[items.Length+1];
            for (int i = 0; i <tempArray .Length; i++)
            {
                items[i] = tempArray[i]; //ödünç verdiğimiz elemanları asıl dizimize geri koyduk.
            }
            items[items.Length - 1] = new KeyValuePair<K,V>(_key, _value);
            Console.WriteLine(items[items.Length-1]);
        }
    }
}
