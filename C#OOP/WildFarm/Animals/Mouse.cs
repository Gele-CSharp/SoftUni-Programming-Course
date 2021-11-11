using System;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightFactor { get; protected set; } = 0.10;

        public override bool isFoodValid(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
            {
                return true;
            }

            return false;
        }

        public override string AskForFood()
               => "Squeak";

        
    }
}
