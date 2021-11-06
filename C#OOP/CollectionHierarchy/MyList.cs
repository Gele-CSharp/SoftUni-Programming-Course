using System;

namespace CollectionHierarchy
{
    public class MyList : AddRemoveCollection, IMyList
    {
        public int Used => Elements.Count;


        public override string Remove()
        {
            if (Elements.Count == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }

            string element = Elements[0];
            Elements.RemoveAt(0);
            return element;
        }
    }
}
