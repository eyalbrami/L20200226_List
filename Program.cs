using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20200226_List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Node n1 = new Node(1000);
            //Node n2 = new Node(-700);
            //n1.Next = n2;
            //Node n3 = new Node(800);
            //n2.Next = n3;
            //Node n4 = new Node(2000);
            //n3.Next = n4;
            //Node n5 = new Node(230);
            //n4.Next = n5;
            //PrintLinkedList(n1);
            //Console.WriteLine($"Biggest { Biggest(n1)} ");
            //Console.WriteLine($"Sum { Sum(n1)} ");
            //Console.WriteLine($"Count { Count(n1)} "); 
            #endregion


            Linked linked = new Linked();
            linked.Add(99);
            linked.Add(100);
            int[] arr = new int[2];
            arr.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {

            }
            Console.WriteLine(linked.ToString());




            #region ArrayList
            //ArrayList arrayList = new ArrayList();
            //ArrayList arrayList2= new ArrayList();

            //arrayList.Add(25);
            //arrayList.Add(10);
            //arrayList.Add(14);
            //arrayList.Add(3);
            //arrayList.Add(400);

            //arrayList2.Add(25);
            //arrayList2.Add(10);
            //arrayList2.Add(14);
            //arrayList2.Add(3);
            //arrayList2.Add(400);


            //arrayList.Equals(arrayList2);
            ////int n = 100;
            ////for (int j = 0; j < n; j++)
            ////{
            ////    arrayList.Add(j + 1000);
            ////}
            //arrayList.Add(1, 700);
            //Console.WriteLine(arrayList.ToString());

            //Console.WriteLine($"The index is : { arrayList.IndexOf(14)}");

            //Console.WriteLine("Get Hash Code : " + arrayList.GetHashCode());




            //////אפשרות לרוקן את הרשימה
            ////while(arrayList.Count() > 0)
            ////{
            ////    arrayList.Remove(arrayList.Count() - 1);
            ////}

            #endregion

            Console.ReadLine();
        }
        static void PrintLinkedList(Node first)
        {
            Console.WriteLine("the connected list is : ");
            while (first != null)
            {
                Console.WriteLine(first.Value);
                first = first.Next;
            }
        }
        static int Biggest(Node first)
        {
            if (first == null)
            {
                throw new Exception("list is empty");
            }
            int max = first.Value;
            while (first != null)
            {
                if (first.Value > max)
                {
                    max = first.Value;
                }
                first = first.Next;
            }
            return max;
        }
        static int Sum(Node first)
        {
            if (first == null)
            {
                throw new Exception("list is empty");
            }
            int sum = 0;
            while (first != null)
            {
                sum += first.Value;
                first = first.Next;
            }
            return sum;
        }
        static int Count(Node first)
        {
            int count = 0;
            while (first != null)
            {
                count++;
                first = first.Next;
            }
            return count;
        }
        static bool Exists(Node first)
        {
            if (first == null)
            {
                throw new Exception("list is empty");
            }
            while (first != null)
            {
                if (first.Value == first.Next.Value)
                {
                    Exists(first.Next);
                    return true;
                }
                first = first.Next;
            }
            return true;
        }
    }
}
