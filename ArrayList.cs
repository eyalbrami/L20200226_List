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
        private int count; //גודל המערך


        public ArrayList()
        {
            this.arr = new int[10];
            this.count = 0;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{");

            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(arr[i] + ",");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();

        }
        //נממש את STRINGBUILDER

        public override bool Equals(object obj)
        {
            //compare count
            if (obj == null)
                return false;
            if (obj == this)
                return true;
            if (!(obj is ArrayList))
                return false;
            ArrayList other = (ArrayList)obj;
            for (int i = 0; i < other.count; i++)
            {
                if (this.arr[i] != other.arr[i])
                    return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            int result = 0;
            for (int i = 0; i < count; i++)
            {
                result = result ^ arr[i];
            }
            return result;
        }
        public void Add(int x)
        {
            AddSpace();
            arr[count++] = x; //קידום בא אחרי ההשמה ומקדם את גודל המערך
            
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
            for (int i = count; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }
            this.arr[index] = x;
            count++; //update the number of items
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
            if (index < 0 || index > count)
            {
                throw new Exception("the index out of bounds");
            }
            //check if the array is large enough
            AddSpace();
            //run from index to end of array
            for (int i = index; i < count; i--)
            {
                arr[i] = arr[i + 1];
            }
            count--; //update the number of items

        }
        /// <summary>
        /// מחזיר כמה איברים יש ברשימה
        /// </summary>
        /// <returns></returns>
        public int Count()
        {

            return count;
        }
        /// <summary>
        /// החזיר ערך לפי המיקום של האיבר
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int IndexOf(int x)
        {
            for (int i = 0; i < count; i++)
            {
                if (arr[i] == x)
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
            int[] temp = new int[count];
            for (int i = 0; i < count; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }
        /// <summary>
        /// איפוס של הרשימה
        /// </summary>
        public void Clear()
        {
            count = 0;
        }
    }
}
