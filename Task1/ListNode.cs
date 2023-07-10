using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
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
}
