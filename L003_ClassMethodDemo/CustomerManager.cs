using System;
using System.Collections.Generic;
using System.Text;

namespace L003_ClassMethodDemo
{
    class CustomerManager
    {
        Customer[] list;

        public CustomerManager()
        {
            list = new Customer[0];
        }

        public void Add(Customer person)
        {
            Customer[] tempArray;
            tempArray = list;
            list = new Customer[list.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                list[i] = tempArray[i];
            }
            list[list.Length - 1] = person;

            Console.WriteLine(person.FirstName + " " + person.LastName + " Eklendi.");
        }
        public void List()
        {
            var i = 1;
            foreach (var item in list)
            {
                Console.WriteLine(i + " -> " + item.FirstName + " " + item.LastName);
                i++;
            }
        }
        public void Delete(Customer person)
        {
            List<Customer> newList = new List<Customer>();
            foreach (var item in list)
            {
                newList.Add(item);
            }

            newList.Remove(person);

            list = new Customer[list.Length - 1];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = newList[i];
            }

            Console.WriteLine(person.FirstName + " " + person.LastName + " Silindi.");
        }
    }
}
