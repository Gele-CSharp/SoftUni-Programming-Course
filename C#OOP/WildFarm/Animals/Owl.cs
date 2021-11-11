using System;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double WeightFactor { get; protected set; } = 0.25;

        public override bool isFoodValid(IFood food)
        {
            if (food.GetType().Name == "Meat")
            {
                return true;
            }

            return false;
        }

        public override string AskForFood()
               => "Hoot Hoot";

    }
}
