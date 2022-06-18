namespace ITKariera_Module4
{
    public class CustomQueue<T>
    {
        private readonly int initialCapacity = 4;
        private int count;
        private T[] queue;
        public int Count { get { return count; } }
        public T this[int index]
        {
            get { return queue[index]; }
            set { queue[index] = value; }
        }
        public CustomQueue()
        {
            queue = new T[initialCapacity];
            count = 0;
        }
        private void Resize()
        {
            T[] tmp = new T[queue.Length * 2];
            queue.CopyTo(tmp, 0);
            queue = tmp;
        }
        public void Enqueue(T item)
        {
            if (Count == queue.Length) Resize();
            queue[count] = item;
            count++;
        }
        public T Dequeue()
        {
            if (Count > 0)
            {
                T item = queue[0];
                T[] tmp = new T[1];
                queue = queue.Skip(1).Concat(tmp).ToArray();
                count--;
                return item;
            }
            throw new InvalidOperationException("Queue is empty!");
        }
        public T Peek() { return queue[0]; }
        public bool IsEmpty() { return Count == 0 ? true : false; }
        public override string ToString()
        {
            if (IsEmpty()) return String.Empty;
            else return String.Join("\n", queue);
        }
        public string ToString(string separator)
        {
            if (IsEmpty()) return String.Empty;
            else return String.Join(separator, queue);
        }
    }
}
