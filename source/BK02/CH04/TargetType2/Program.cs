using System;

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

    internal class MyLuxuryFoods : MyFavorteFoods
    {
        internal decimal HowMuch { get; set; }

        public MyLuxuryFoods(int Position,
            string Food, FoodGroups Category, decimal Cost) :
            base(Position, Food, Category)
        {
            HowMuch = Cost;
        }
    }

    internal class MyComfortFoods: MyFavorteFoods
    {
        internal string HowOften { get; set; }
        public MyComfortFoods(int Position,
            string Food, FoodGroups Category, string Time) :
            base(Position, Food, Category)
        {
            HowOften = Time;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyLuxuryFoods GreatFood = new MyLuxuryFoods(
                1, "Salmon", FoodGroups.Meat, 35.95M);
            MyComfortFoods SatisfyingFood = new MyComfortFoods(
                1, "Oatmeal", FoodGroups.Grain, "Weekly");
            MyFavorteFoods Choice = (MyFavorteFoods)GreatFood ?? (MyFavorteFoods)SatisfyingFood;
            Console.WriteLine(Choice.Name);
            Console.ReadLine();
        }
    }
}
