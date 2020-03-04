using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20200226_List
{
    public class Linked
    {
        private readonly Node anchor;
        private int count;
        public Linked()
        {
            anchor = new Node(123);
        }
        public void Add(int x)
        {
            Node last = anchor;
            while (last.Next != null)
            {
                last = last.Next;
            }
            last.Next = new Node(x);
            count++;
        }
        public void Add(int x, int index)
        {
            Node theOneBefore = anchor;
            for (int i = 0; i < index; i++)
            {
                theOneBefore = theOneBefore.Next;
            }
            Node node = new Node(x);
            node.Next = theOneBefore.Next;
            theOneBefore.Next = node;
            count++;
        }
        public int Get(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("Out of Bounds");
            Node current = anchor;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
        public void Set(int index, int x)
        {
            if (index < 0 || index >= count)
                throw new Exception("Out of Bounds");
            Node current = anchor;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Value = x;
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("Out of Bounds");
            Node theOneBefore = anchor;
            for (int i = 0; i < index; i++)
            {
                theOneBefore = theOneBefore.Next;
            }
            theOneBefore.Next = theOneBefore.Next.Next;
            count--;
        }
        public int Count()
        {
            return count;
        }
        public int IndexOf(int x)
        {
            Node node = anchor.Next;
            int index = 0;
            while (node != null)
            {
                if (node.Value == x)
                    return index;
                node = node.Next;
                index++;
            }
            return -1;
        }
        public int[] ToArray()
        {
            int[] arr = new int[count];
            Node node = anchor.Next;
            for (int i = 0; i < count; i++)
            {
                arr[i] = node.Value;
                node = node.Next;
            }
            return arr;
        }
        public override string  ToString()
        {
            Node node = anchor;
            string list = "{";
            while(node !=null)
            {
                
                list += node.Value+", ";
            }

            list += "}";
            return list;

        }
            
            }
}
