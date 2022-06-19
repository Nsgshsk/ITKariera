using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITKariera_Module4
{
    public class CustomStack<T>
    {
        private readonly int initialCapacity = 4;
        private int count;
        private T[] stack;
        public CustomStack()
        {
            stack = new T[initialCapacity];
            count = 0;
        }
        public int Count { get { return count; } }
        public int Size { get { return stack.Length; } }
        public T this[int index]
        {
            get { return stack[index]; }
            set { stack[index] = value; }
        }
        private void Resize()
        {
            T[] tmp = new T[stack.Length * 2];
            stack.CopyTo(tmp, 0);
            stack = tmp;
        }
        public void Push(T item)
        {
            if (Count >= stack.Length) Resize();
            stack[Count] = item;
            count++;
        }
        public T Pop()
        {
            if (Count > 0)
            {
                T item = stack[Count - 1];
                T[] tmp = new T[1];
                Array.Copy(stack, stack, Count - 1);
                stack[Count - 1] = tmp[0];
                count--;
                return item;
            }
            throw new InvalidOperationException("Stack is empty!");
        }
        public T Peek() { return stack[Count - 1]; }
        public bool Contains(T item)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (EqualityComparer<T>.Default.Equals(stack[i], item)) return true;
            }
            return false;
        }
        public void Clear() { stack = new T[initialCapacity]; count = 0; }
        public override string ToString()
        {
            if (Count == 0) return string.Empty;
            string tmp = String.Empty;
            for (int i = Count - 1; i > 0; i--)
            {
                tmp += stack[i] + "\n";
            }
            tmp += stack[0];
            return tmp;
        }
    }
}
