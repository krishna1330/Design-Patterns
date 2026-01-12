using Design_Patterns.CreationalDesignPatterns;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new PizzaBuilder().SetSize("Large").AddCheese().AddPepperoni().AddOlives().Build();
            pizza.Display();
        }
    }
}