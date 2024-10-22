namespace CustomList
{
    public static class List
    {
        public class CustomList<T>
        {
            private T[] _items;
            private int _size;

            public CustomList()
            {
                _items = new T[4];
                _size = 0;
            }

            public int Count => _size;

            public void Add(T item)
            {
                if (_size == _items.Length)
                {
                    Resize();
                }
                _items[_size++] = item;
            }

            public T Get(int index)
            {
                if (index < 0 || index >= _size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return _items[index];
            }

            public void Remove(int index)
            {
                if (index < 0 || index >= _size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                for (int i = index; i < _size - 1; i++)
                {
                    _items[i] = _items[i + 1];
                }
                _items[--_size] = default;
            }

            private void Resize()
            {
                int newCapacity = _items.Length * 2;
                T[] newArray = new T[newCapacity];
                Array.Copy(_items, newArray, _size);
                _items = newArray;
            }

            public void PrintList()
            {
                for (int i = 0; i < _size; i++)
                {
                    Console.Write(_items[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}