using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20200226_List
{
    public class ArrayList
    {
        private int[] arr;
        private int count;


        public ArrayList()
        {
            this.arr = new int[10];
            this.count = 0;
        }
        public string ToString()
        {
            string List = "";
            for (int i = 0; i < arr.Length; i++)
            {
                List += arr[i] + (i == arr.Length - 1 ? "" : ",");
            }
            return List;

        }
        public bool Equals(ArrayList obj)
        {
            return arr.Equals(obj);
        }
        public void Add(int x)
        {
            AddSpace();
            arr[count++] = x;

        }
        private void AddSpace()
        {
            if (count == arr.Length)
            {
                /*
                 * זמן ריצה O(n*n)
                int[] temp = new int[count + 1]; 
                */
                // זמן ריצה O(n)
                int[] temp = new int[count * 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                this.arr = temp;
            }
        }
        public void Add(int index, int x)
        {
            if (index < 0 || index > count)
            {
                throw new Exception("the index out of bounds");
            }
            //check if the array is large enough
            AddSpace();
            //run from index to end of array
            for (int i = count; i >= index; i--)
            {
                arr[i + 1] = arr[i];
            }

            this.arr[index] = x;
        }
    public int Get(int index)
    {
        return this.arr[index];
    }
    /// <summary>
    /// מקבל ערך ומכניס אותו למקום
    /// </summary>
    /// <param name="index"></param>
    /// <param name="x"></param>
    public void Set(int index, int x)
    {
        this.arr[index] = x;
    }
    /// <summary>
    /// מוחק איבר מהמקום ה-INDEX
    /// </summary>
    /// <param name="index"></param>
    public void Remove(int index)
    {

    }
    /// <summary>
    /// מחזיר כמה איברים יש ברשימה
    /// </summary>
    /// <returns></returns>
    public int Count()
    {

        return arr.Length;
    }
    /// <summary>
    /// החזיר ערך לפי המיקום של האיבר
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public int IndexOf(int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != x)
                continue;
            return i;
        }
        return 0;
    }
    /// <summary>
    /// מחזיר את הרשימה כמערך
    /// </summary>
    /// <returns></returns>
    public int[] ToArray()
    {
        return arr;
    }
    /// <summary>
    /// איפוס של הרשימה
    /// </summary>
    public void Clear()
    {
        new ArrayList();
    }
}
}
