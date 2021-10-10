using System;

namespace CustomStack
{
    public class CustomStack
    {
        private const int defaultCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            items = new int[defaultCapacity];
            Count = 0;
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index <0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                items[index] = value;
            }
        }

        public void Push(int element)
        {
            if (this.Count == items.Length)
            {
                int[] tempArray = new int[items.Length * 2];

                for (int i = 0; i < Count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }

            items[Count] = element;
            Count++;
        }

        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty!");
            }

            int value = items[Count - 1];
            items[Count - 1] = default;
            Count--;
            return value;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty!");
            }

            int value = items[Count - 1];
            return value;
        }

    }
}
