using System.Collections.Generic;

namespace CollectionHierarchy
{
    public abstract class Collection
    {
        private List<string> elements;

        public Collection()
        {
            elements = new List<string>();
        }

        protected List<string> Elements
        {
            get => elements;

            private set => elements = value;
        }

        public abstract int Add(string element);
    }
}
