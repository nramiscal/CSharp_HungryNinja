using System;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;

        public Food()
        {
            Name = "fud";
            Calories = 100;
            IsSpicy = false;
            IsSweet = false;
        }

        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int cal, bool iSpicy, bool iSweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = iSpicy;
            IsSweet = iSweet;
        }
    }

}