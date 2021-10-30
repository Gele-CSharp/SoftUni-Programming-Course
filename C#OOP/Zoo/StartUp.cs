namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Mammal mammal;

            mammal = new Gorilla("Peshko");

            System.Console.WriteLine(mammal.GetType().Name);
            System.Console.WriteLine(mammal.Name);

            Reptile reptile = new Reptile("ivo");
            System.Console.WriteLine(reptile.Name);

        }
    }
}