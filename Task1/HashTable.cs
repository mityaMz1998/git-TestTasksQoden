using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
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
