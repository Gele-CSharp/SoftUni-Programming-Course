using WildFarm.Foods;

namespace WildFarm.Animals
{
    public interface IAnimal
    {
        public string Name { get; }

        public double Weight { get; }

        public int FoodEaten { get; }

        public double WeightFactor { get; }

        abstract bool isFoodValid(IFood food);

        abstract string AskForFood();

        virtual void Eat(IFood food)
        {
            
        }
    }
}
