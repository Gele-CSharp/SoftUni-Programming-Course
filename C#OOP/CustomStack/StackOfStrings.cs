﻿using System.Collections.Generic;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return Count == 0;
        }

        public Stack<string> AddRange(IEnumerable<string> range)
        {
            foreach (var item in range)
            {
                this.Push(item);
            }

            return this;
        }
    }
}
