using System;
using System.Collections.Generic;

namespace TargetType1
{
    internal enum FoodGroups
    {
        Meat,
        Vegetables,
        Fruit,
        Grain,
        Dairy
    }

    internal class MyFavorteFoods
    {
        internal int Rank { get; set; }
        internal string Name { get; set; }
        internal FoodGroups Group { get; set; }

        public MyFavorteFoods(int Position, 
            string Food, FoodGroups Category)
        {
            Rank = Position;
            Name = Food;
            Group = Category;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Foods = new List<MyFavorteFoods>
            {
                new (1, "Apples", FoodGroups.Fruit),
                new (2, "Steaks", FoodGroups.Meat),
                new (3, "Asparagus", FoodGroups.Vegetables)
            };

            foreach (MyFavorteFoods Item in Foods)
                Console.WriteLine($"Food #{Item.Rank} is {Item.Name} " +
                    $"of {Item.Group} food category.");
            Console.ReadLine();
        }
    }
}
