using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Chocolate Mousse", 300, false, true),
                new Food("Creme Brulee", 600, false, true),
                new Food("Strawberries with Zabaglione", 200, false, true),
                new Food("Lemon Tart", 320, false, true),
                new Food("Boeuf Bourguignon", 600, true, false),
                new Food("Quiche Lorraine", 400, true, false),
                new Food("Salade Verte", 200, true, false),

            };
        }

        public Food Serve()
        {
            Random rand = new Random();

            int num = rand.Next(0,Menu.Count);
            Food f = Menu[num];
            System.Console.WriteLine($"Enjoy your delicious {f.Name}!!!");
            return f;
        }
    }

}