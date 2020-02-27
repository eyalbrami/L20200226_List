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
            ArrayList arrayList = new ArrayList();
            arrayList.Add(25);
            arrayList.Add(10);
            arrayList.Add(14);
            arrayList.Add(3);
            arrayList.Add(400);

            int n = 100;
            for (int j = 0; j < n; j++)
            {
                arrayList.Add(j + 1000);
            }

            Console.WriteLine("{" + arrayList.ToString() + "}");

            Console.WriteLine($"The index is : { arrayList.IndexOf(14)}");





            ////אפשרות לרוקן את הרשימה
            //while(arrayList.Count() > 0)
            //{
            //    arrayList.Remove(arrayList.Count() - 1);
            //}

            
            Console.ReadLine();
        }
    }
}
