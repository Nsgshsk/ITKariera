namespace ITKariera_Module4
{
    class CustomArrayList<T>
    {
        private readonly int Inital_Capacity = 2;
        public int Count { get; private set; }
        public int Capacity { get { return items.Length; } }
        private T[] items;
        public T this[int index]
        {
            set
            {
                if (index >= items.Length)
                    throw new ArgumentOutOfRangeException("Index is out of bounds!");
                items[index] = value;
            }
            get
            {
                if (index >= items.Length)
                    throw new ArgumentOutOfRangeException("Index is out of bounds!");
                return items[index];
            }
        }
        public CustomArrayList()
        {
            items = new T[Inital_Capacity];
        }
        private void Resize()
        {
            T[] tmp = new T[items.Length * 2];
            items.CopyTo(tmp, 0);
            items = tmp;
        }
        public void Add(T item)
        {
            if (Count < items.Length)
                items[Count++] = item;
            else
            {
                Resize();
                items[Count++] = item;
            }
        }
        public void RemoveAt(int index)
        {
            if (index >= items.Length)
                throw new ArgumentOutOfRangeException("Index is out of bounds!");
            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
            Count--;

            if (Count <= items.Length / 4)
                TrimExcess(items.Length / 2);
        }
        private void TrimExcess(int capacity)
        {
            T[] tmp = new T[capacity];
            for (int i = 0; i < Count; i++)
            {
                tmp[i] = items[i];
            }
            items = tmp;
        }
        public void TrimExcess()
        {
            T[] tmp = new T[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                tmp[i] = items[i];
            }
            items = tmp;
        }
        public T First { get { return items[0]; } }
        public T Last { get { return items[Count - 1]; } }
    }
}
