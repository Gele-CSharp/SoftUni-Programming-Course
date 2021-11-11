using System;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public virtual double WeightFactor { get; protected set; } = 1;

        public abstract bool isFoodValid(IFood food);

        public abstract string AskForFood();

        public virtual void Eat(IFood food)
        {
            if (isFoodValid(food))
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * WeightFactor;
            }
            else
            {
                ThrowArgumentExeptionForFood(food);
                return;
            }
        }

        private void ThrowArgumentExeptionForFood(IFood food)
        {
            throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}
