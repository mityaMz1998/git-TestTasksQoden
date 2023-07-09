using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Task1
    {
        public static int a;
        static void Main(string[] args)
        {
            a = Convert.ToInt32(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            HashTable hashTable = new HashTable(numbers.Length);

            foreach (string element in numbers)
            {
                hashTable.Insert(Convert.ToInt32(element));
            }

            for (int i = 0; i < a; i++)
            {
                Console.Write("{0}: ", i);
                ListNode current = hashTable.values[i];
                while (current != null)
                {
                    if (current.value % a == i)
                    {
                        Console.Write(current.value + " ");
                    }
                    current = current.next;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
