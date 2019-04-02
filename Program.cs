using System;
using System.Collections.Generic;

namespace buffet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human vlad = new Human("Vlad");
            // Human dima = new Human("Dima", 20, 30, 40, 3000);
            // vlad.Attack(dima);
            // vlad.Attack(dima);
            Buffet myBuffet = new Buffet();
            Console.WriteLine(myBuffet.Serve().Name);

        }
    }

    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("Example", 1000, false, false),
            new Food("Pepper", 1, true, false),
            new Food("Cake", 3000, false, true),
            new Food("Carrot", 50, false, false)
        };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}
