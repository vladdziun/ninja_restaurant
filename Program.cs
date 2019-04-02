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
            // Console.WriteLine(Buffet.Serve().Name);
            Ninja vlad = new Ninja();
            vlad.Eat();
            vlad.Eat();
            vlad.Eat();
            Console.WriteLine(vlad.Calories);

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
        public static List<Food> Menu;

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

        public static Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public int Calories
        {
            get {return calorieIntake;}
        }
        public List<Food> FoodHistory;
        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                    return true;
                else
                    return false;
            }
        }

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        // add a public "getter" property called "IsFull"

        // build out the Eat method
        public void Eat()
        {
            if (!IsFull)
            {
                Food foodToServe = Buffet.Serve();
                calorieIntake = foodToServe.Calories;
                FoodHistory.Add(foodToServe);
                Console.WriteLine(foodToServe.Name+" "+ foodToServe.IsSpicy);
            }
            else
                Console.WriteLine("I am full!");
        }
    }
}
