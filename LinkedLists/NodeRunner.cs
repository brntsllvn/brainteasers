using System;

namespace LinkedLists
{
    public class Node
    {
        public Node next = null;
        public int value;
        public Node(int value)
        {
            this.value = value;
        }
    }
    
    
    public class NodeRunner
    {
        public int FindKthToLastElement(Node head, int k)
        {
            if (head == null || k < 1) return -1;

            var n = head;
            var slow = head;
            var counter = 1;
            while (n != null)
            {
                if (counter > k) 
                    slow = slow.next;
                n = n.next;
                counter++;
            }

            return counter <= k ? -1 : slow.value;
        }
    }
}