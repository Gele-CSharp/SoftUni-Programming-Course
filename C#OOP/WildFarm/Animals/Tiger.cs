using System;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightFactor { get; protected set; } = 1;

        public override string AskForFood()
               => "ROAR!!!";

        public override bool isFoodValid(IFood food)
        {
            if (food.GetType().Name == "Meat")
            {
                return true;
            }

            return false;
        }
    }
}
