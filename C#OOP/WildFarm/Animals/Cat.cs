using System;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightFactor { get; protected set; } = 0.30;

        public override string AskForFood()
               => "Meow";

        public override bool isFoodValid(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
            {
                return true;
            }

            return false;
        }

    }
}
