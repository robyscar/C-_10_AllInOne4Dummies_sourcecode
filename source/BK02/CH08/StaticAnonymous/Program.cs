using System;
using System.Collections.Generic;

namespace StaticAnonymous
{
    internal class WorkWithEats
    {
        const string outString = "{0} is a {1}.";

        internal struct EatItem
        {
            internal string Name;
            internal string Category;
        }

        internal void CreateEats(Func<string, string, string> func)
        {
            List<EatItem> Eats = new List<EatItem>
            {
                new EatItem() {Name="Apple", Category="Fruit"},
                new EatItem() {Name="Bread", Category="Grain"},
                new EatItem() {Name="Asparagus", Category="Vegetable"},
                new EatItem() {Name="Hamburger", Category="Meat"}
            };

            foreach (var item in Eats)
                Console.WriteLine(func(item.Name, item.Category));
        }

        internal void ShowEats()
        {
            CreateEats(static (name, category) => string.Format(
                outString, name, category));
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            WorkWithEats myEats = new WorkWithEats();
            myEats.ShowEats();
            Console.ReadLine();
        }
    }
}
