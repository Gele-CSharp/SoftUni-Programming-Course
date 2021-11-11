using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double WeightFactor { get; protected set; } = 0.35;

        public override bool isFoodValid(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit"
                || food.GetType().Name == "Meat" || food.GetType().Name == "Seeds")
            {
                return true;
            }

            return false;
        }

        public override string AskForFood()
               => "Cluck";

    }
}
