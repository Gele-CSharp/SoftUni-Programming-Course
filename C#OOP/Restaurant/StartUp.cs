namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Product product = new Food("meat", 5.87m, 500);
            Product product1 = new Fish("tuna", 5.3m);

            System.Console.WriteLine(product1.Name);
            System.Console.WriteLine(product1.Price);
            System.Console.WriteLine(product.GetType().Name);
            Food food = new Food("bob", 2.3m, 300);
            System.Console.WriteLine(food.Grams);
        }
    }
}