using System;
using System.Collections.Generic;
using System.Text;

namespace L004_GenericsIntro
{
    // Type T
    class MyList<T>
    {
        T[] items;

        // Constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public void Print()
        {
            T[] tempArray = items;
            foreach (var temp in tempArray)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine(tempArray.Length);
        }
    }
}
/*
 * -> Constructor: class çalıştığında sürekli çalışacak method'tur, diyebiliriz.
 * ! Bir Class new'lendiğinde çalışan bloğa Constructor denir.
 * -> Type'ler bize kendi tipimizi oluşturmayı sunar.
 * string, int, float, boolean, class object, vs. gibi oluşturduğumuz tipe istediğimiz tipi tanımlayabiliriz.
 * class MyClass<T>{ public MyClass(){} }
*/