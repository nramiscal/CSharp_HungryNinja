using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        public string Name;
        private int calorieIntake;
        public List<Food> FoodHistory;

        public int CalorieIntake
        {
            get
            {
                return calorieIntake;
            }
            set
            {
                calorieIntake = value;
            }
        }

        // add a constructor
        public Ninja(string name)
        {
            Name = name;
            calorieIntake = 0;
            FoodHistory = new List<Food>(){};
        }

        // add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories

        public bool IsFull()
        {
            if (CalorieIntake > 1200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
            build out the Eat method that:
            
            if the Ninja IS full:
            - issues a warning to the console that the ninja is full and cannot eat anymore

            if the Ninja is NOT full:
            - adds calorie value to ninja's total calorieIntake
            - adds the randomly selected Food object to ninja's FoodHistory list
            - writes the Food's Name - and if it is spicy/sweet to the console
         */

        public void Eat(Food item)
        {
            if (IsFull())
            {
                System.Console.WriteLine($"{Name} is full and cannot eat anymore...");
            }
            else
            {
                CalorieIntake += item.Calories;
                FoodHistory.Add(item);
                System.Console.WriteLine($"Yummy, yummy {item.Name}");
                if (item.IsSpicy)
                {
                    System.Console.WriteLine($"Yeow! That was spicy!!!");
                }
                if (item.IsSweet)
                {
                    System.Console.WriteLine($"Mmmm, that was deliciously sweet!");
                }
            }
        }
    }

}