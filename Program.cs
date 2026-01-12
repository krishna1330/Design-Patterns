using Design_Patterns.CreationalDesignPatterns;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger log1 = Logger.GetInstance();
            Logger log2 = Logger.GetInstance();
        }
    }
}