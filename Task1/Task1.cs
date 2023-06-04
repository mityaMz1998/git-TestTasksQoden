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
            PrintHashTable(hashTable);
            Console.ReadLine();
        }
        static void PrintHashTable(HashTable hashTable)
        {
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
        }
    }
    class ListNode
    {
        public int value;
        public ListNode next;

        public ListNode(int value)
        {
            this.value = value;
            next = null;
        }

        public void Insert(int newValue)
        {
            if (next == null)
                next = new ListNode(newValue);
            else
                next.Insert(newValue);
        }
    }

    class HashTable
    {
        public ListNode[] values;

        public HashTable(int size)
        {
            values = new ListNode[size];
        }

        public void Insert(int newValue)
        {
            int hashFunction = newValue % Task1.a;

            if (values[hashFunction] == null)
                values[hashFunction] = new ListNode(newValue);
            else
                values[hashFunction].Insert(newValue);
        }
    }
}
