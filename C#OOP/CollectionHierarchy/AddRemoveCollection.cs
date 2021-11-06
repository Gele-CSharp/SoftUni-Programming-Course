using System;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : Collection, IAddRemoveCollection
    {
        public override int Add(string element)
        {
            Elements.Insert(0, element);
            return 0;
        }

        public virtual string Remove()
        {
            if (Elements.Count == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }

            string element = Elements[Elements.Count - 1];
            Elements.RemoveAt(Elements.Count - 1);
            return element;
        }
    }
}
