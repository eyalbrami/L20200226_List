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
        private Node last;
        private int count;
        public Linked()
        {
            anchor = new Node(123);
            last = anchor;
            count = 0;
        }
        public void Add(int x)
        {
            /*version 1*/
            //Node last = anchor;
            //while (last.Next != null)
            //{
            //    last = last.Next;
            //}
            //last.Next = new Node(x);

            last.Next = new Node(x);
            last = last.Next;

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
            Node node = anchor;
            for (int i = 0; i < count; i++)
            {
                node = node.Next;
                arr[i] = node.Value;
            }
            return arr;
        }
        public void Clear()
        {
            anchor.Next = null;
            count = 0;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{");
            Node node = anchor;
            for (int i = 0; i < count; i++)
            {
                node = node.Next;
                stringBuilder.Append(node.Value.ToString() + ", ");
            }
            if (count > 0)
                stringBuilder.Append(node.Value.ToString());
            stringBuilder.Append("}");
            return stringBuilder.ToString();

        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            if (obj == this)
                return false;
            if (!(obj is Linked))
                return false;
            Linked other = (Linked)obj;
            if (this.count != other.count)
                return false;

            Node start = this.anchor;
            Node end = other.anchor;

            for (int i = 0; i < this.count; i++)
            {
                start = start.Next;
                end = end.Next;
                if (start.Value != end.Value)
                    return false;
            }
            return true;
        }
    }
}
