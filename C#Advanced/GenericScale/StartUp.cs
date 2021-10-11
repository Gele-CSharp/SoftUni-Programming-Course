namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> scale = new EqualityScale<int>(3, 5);
            System.Console.WriteLine(scale.AreEqual());
        }
    }
}
