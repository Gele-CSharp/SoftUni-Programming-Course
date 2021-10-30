namespace Restaurant
{
    class Coffee : HotBeverage
    {
        private const decimal CoffeePrice = 3.50m;
        private const double CoffeMilliliters = 50;

        public Coffee(string name, double caffeine) 
            : base(name, CoffeePrice, CoffeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
