using System;
using System.Collections.Generic;
using WildFarm.Foods;
using WildFarm.Animals;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();

            while (true)
            {
                string[] animalInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IAnimal animal = null;
                IFood food = null;
                string animalType = animalInfo[0];

                if (animalType == "End")
                {
                    break;
                }

                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);

                string[] foodInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string foodType = foodInfo[0];
                int foodQuantity = int.Parse(foodInfo[1]);

                switch (animalType)
                {
                    case "Owl":
                        double wingSize = double.Parse(animalInfo[3]);
                        animal = new Owl(name, weight, wingSize);
                        break;
                    case "Hen":
                        wingSize = double.Parse(animalInfo[3]);
                        animal = new Hen(name, weight, wingSize);
                        break;
                    case "Mouse":
                        string livingRegion = animalInfo[3];
                        animal = new Mouse(name, weight, livingRegion);
                        break;
                    case "Dog":
                        livingRegion = animalInfo[3];
                        animal = new Dog(name, weight, livingRegion);
                        break;
                    case "Cat":
                        livingRegion = animalInfo[3];
                        string breed = animalInfo[4];
                        animal = new Cat(name, weight, livingRegion, breed);
                        break;
                    case "Tiger":
                        livingRegion = animalInfo[3];
                        breed = animalInfo[4];
                        animal = new Tiger(name, weight, livingRegion, breed);
                        break;
                }

                animals.Add(animal);
                Console.WriteLine(animal.AskForFood());

                switch (foodType)
                {
                    case "Vegetable":
                        food = new Vegetable(foodQuantity);
                        break;
                    case "Fruit":
                        food = new Fruit(foodQuantity);
                        break;
                    case "Seeds":
                        food = new Seeds(foodQuantity);
                        break;
                    case "Meat":
                        food = new Meat(foodQuantity);
                        break;
                }

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
