namespace CollectionHierarchy
{
    public class AddCollection : Collection
    {
        public override int Add(string element)
        {
            Elements.Add(element);
            int index = Elements.Count - 1;
            return index;
        }
    }
}
