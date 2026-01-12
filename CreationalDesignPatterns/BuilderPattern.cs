using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalDesignPatterns
{
    // =========================== Problem =================================
    //public class Pizza
    //{
    //    public string Size { get; set; }
    //    public bool Cheese { get; set; }
    //    public bool Pepperoni { get; set; }
    //    public bool Mushrooms { get; set; }
    //    public bool Olives { get; set; }

    //    public Pizza(string Size, bool Cheese, bool Pepperoni, bool Mushrooms, bool Olives)
    //    {
    //        this.Size = Size;
    //        this.Cheese = Cheese;
    //        this.Pepperoni = Pepperoni;
    //        this.Mushrooms = Mushrooms;
    //        this.Olives = Olives;   
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    Pizza pizza = new Pizza("Large", true, true, false, true);
    //}




    // ============================== Solution ===============================
    public class Pizza
    {
        public string Size { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mushrooms { get; set; }
        public bool Olives { get; set; }

        public void Display()
        {
            Console.WriteLine($"Pizza Size: {Size}");
            Console.WriteLine($"Cheese: {Cheese}");
            Console.WriteLine($"Pepperoni: {Pepperoni}");
            Console.WriteLine($"Mushrooms: {Mushrooms}");
            Console.WriteLine($"Olives: {Olives}");
        }
    }

    public class PizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public PizzaBuilder SetSize(string size)
        {
            this.pizza.Size = size;
            return this;
        }

        public PizzaBuilder AddCheese()
        {
            this.pizza.Cheese = true;
            return this;
        }

        public PizzaBuilder AddPepperoni()
        {
            this.pizza.Pepperoni = true;
            return this;
        }

        public PizzaBuilder AddMushrooms()
        {
            this.pizza.Mushrooms = true;
            return this;
        }

        public PizzaBuilder AddOlives()
        {
            this.pizza.Olives = true;
            return this;
        }

        public Pizza Build()
        {
            return pizza;
        }
    }

    //static void Main(string[] args)
    //{
    //    Pizza pizza = new PizzaBuilder().SetSize("Large").AddCheese().AddPepperoni().AddOlives().Build();
    //    pizza.Display();
    //}
}
