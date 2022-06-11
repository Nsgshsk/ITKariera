using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITKariera_Module4
{
    class CustomList
    {
        private object[] arr;
        private int capacity = 4;
        private int count;
        public int Count
        {
            get { return count; }
        }
        public object this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
        public CustomList()
        {
            arr = new object[capacity];
        }
        public void Add(object item)
        {
            if (Count == arr.Length) Resize();
            arr[Count] = item;
            count++;
        }
        private void Resize()
        {
            object[] tmp = new object[capacity * 2];
            arr.CopyTo(tmp, 0);
            arr = tmp;
        }
        public void Insert(int index, object item)
        {
            if (index > count || index < 0) throw new IndexOutOfRangeException();
            object[] tmp;
            if (index == arr.Length) tmp = new object[arr.Length * 2];
            else tmp = new object[arr.Length];

            Array.Copy(arr, tmp, index);
            count++;
            tmp[index] = item;
            Array.Copy(arr, index, tmp, index + 1, Count - index - 1);
            arr = tmp;
        }
        public int IndexOf(object item)
        {
            for (int i = 0; i < Count; i++)
            {
                Type t1 = item.GetType();
                Type t2 = arr[i].GetType();
                if (t1 == t2)
                    if ( (dynamic) item == (dynamic) arr[i]) return i;
            }
            return -1;
        }
        public void Clear()
        {
            arr = new object[capacity];
            count = 0;
        }
        public void Remove(object item)
        {
            int indexRemove = IndexOf(item);
            if (indexRemove < 0) throw new InvalidOperationException();
            object[] tmp = new object[arr.Length];
            Array.Copy(arr, tmp, indexRemove);
            Array.Copy(arr, indexRemove + 1, tmp, indexRemove, Count - indexRemove - 1);
            count--;
            arr = tmp;
        }
        public void RemoveAt(int index)
        {
            if (index >= Count || index < 0) throw new IndexOutOfRangeException();
            object[] tmp = new object[arr.Length];
            Array.Copy(arr, tmp, index);
            Array.Copy(arr, index + 1, tmp, index, Count - index - 1);
            count--;
            arr = tmp;
        }
    }
}
