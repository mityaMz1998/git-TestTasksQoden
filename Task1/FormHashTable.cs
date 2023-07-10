using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FormHashTable
    {
        public HashTable GetHashTable(string[] numbers, int startInt)
        {
            HashTable hashTable = new HashTable(numbers.Length);

            foreach (string element in numbers)
            {
                hashTable.Insert(Convert.ToInt32(element));
            }

            for (int i = 0; i < startInt; i++)
            {
                Console.Write("{0}: ", i);
                ListNode current = hashTable.values[i];
                while (current != null)
                {
                    if (current.value % startInt == i)
                    {
                        Console.Write(current.value + " ");
                    }
                    current = current.next;
                }
                Console.WriteLine();
            }

            return hashTable;
        }
    }
}
