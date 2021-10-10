using System;

namespace CustomList
{
    public class CustomList
    {
        private const int defaultCapacity = 2;
        private int[] items;

        public CustomList()
        {
            this.items = new int[defaultCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.items[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.items[index] = value;
            }
        }

        private void Resize()
        {
            int[] tempArray = new int[this.items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                tempArray[i] = items[i];
            }

            items = tempArray;
        }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            int value = this.items[index];
            Shift(index);

            if (this.Count == this.items.Length / 2)
            {
                Shrink();
            }

            Count--;
            return value;
        }

        public void Shift(int index)
        {
            int[] tempArray = new int[this.items.Length];

            for (int i = 0; i < items.Length - 1; i++)
            {
                if (i < index)
                {
                    tempArray[i] = items[i];
                }
                else if (i >= index)
                {
                    tempArray[i] = items[i + 1];
                }
            }

            items = tempArray;
        }

        public void Shrink()
        {
            int[] tempArray = new int[this.items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                tempArray[i] = items[i];
            }

            items = tempArray;
        }

        public void InsertAt(int index, int item)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Count == this.items.Length)
            {
                Resize();
            }

            int[] tempArray = new int[items.Length];

            for (int i = 0; i <= Count; i++)
            {
                if (i < index)
                {
                    tempArray[i] = items[i];
                }
                else if (i == index)
                {
                    tempArray[i] = item;
                }
                else
                {
                    tempArray[i] = items[i - 1];
                }
            }

            items = tempArray;
        }

        public bool Contains(int item)
        {
            bool isContains = false;

            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    isContains = true;
                    break;
                }
            }

            return isContains;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The List is empty");
            }

            if (firstIndex < 0 || firstIndex >= Count || secondIndex < 0 || secondIndex >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            int value = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = value;
        }
    }
}
