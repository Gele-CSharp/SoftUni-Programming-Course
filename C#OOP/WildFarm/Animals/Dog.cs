using System;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightFactor { get; protected set; } = 0.40;

        public override bool isFoodValid(IFood food)
        {
            if (food.GetType().Name == "Meat")
            {
                return true;
            }

            return false;
        }

        public override string AskForFood()
               => "Woof!";

    }
}
