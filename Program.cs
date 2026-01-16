using Design_Patterns.CreationalDesignPatterns;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your cuisine: Indian or Chinese");
            string cuisine = "Indian";

            if (cuisine == "Chinese")
            {
                ChineseSoup soup = new ChineseSoup();
                ChineseMainCourse mainCourse = new ChineseMainCourse();
                ChineseDesert desert = new ChineseDesert();

                soup.Serve();
                mainCourse.Serve();
                desert.Serve();
            }

            else if (cuisine == "Indian")
            {
                IndianSoup soup = new IndianSoup();
                IndianMainCourse mainCourse = new IndianMainCourse();
                IndianDesert desert = new IndianDesert();

                soup.Serve(); 
                mainCourse.Serve(); 
                desert.Serve();
            }


            ChineseSoup soup2 = new ChineseSoup();
            IndianMainCourse main2 = new IndianMainCourse();  // WRONG!
            ChineseDesert dessert2 = new ChineseDesert();

            soup2.Serve();
            main2.Serve();
            dessert2.Serve();
        }
    }
}