using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            Ninja tony = new Ninja("Tony");



            for (int i = 0; i < 10; i++)
            {
                tony.Eat(buffet.Serve());
            }
        }
    }
}
