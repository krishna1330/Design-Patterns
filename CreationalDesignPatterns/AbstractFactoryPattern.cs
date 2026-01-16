using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalDesignPatterns
{
    // ======================== Problem ============================

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Choose your cuisine: Indian or Chinese");
    //    string cuisine = "Indian";

    //    if (cuisine == "Chinese")
    //    {
    //        ChineseSoup soup = new ChineseSoup();
    //        ChineseMainCourse mainCourse = new ChineseMainCourse();
    //        ChineseDesert desert = new ChineseDesert();

    //        soup.Serve();
    //        mainCourse.Serve();
    //        desert.Serve();
    //    }

    //    else if (cuisine == "Indian")
    //    {
    //        IndianSoup soup = new IndianSoup();
    //        IndianMainCourse mainCourse = new IndianMainCourse();
    //        IndianDesert desert = new IndianDesert();

    //        soup.Serve();
    //        mainCourse.Serve();
    //        desert.Serve();
    //    }


    //    ChineseSoup soup2 = new ChineseSoup();
    //    IndianMainCourse main2 = new IndianMainCourse();  // WRONG!
    //    ChineseDesert dessert2 = new ChineseDesert();

    //    soup2.Serve();
    //    main2.Serve();
    //    dessert2.Serve();
    //}

    //public class ChineseSoup
    //{
    //    public void Serve()
    //    {
    //        Console.WriteLine("Serving Chinese soup.");
    //    }
    //}

    //public class ChineseMainCourse
    //{
    //    public void Serve()
    //    {
    //        Console.WriteLine("Serving Chinese main course.");
    //    }
    //}

    //public class ChineseDesert
    //{
    //    public void Serve()
    //    {
    //        Console.WriteLine("Serving Chinese desert.");
    //    }
    //}

    //public class IndianSoup
    //{
    //    public void Serve()
    //    {
    //        Console.WriteLine("Serving Indian soup.");
    //    }
    //}

    //public class IndianMainCourse
    //{
    //    public void Serve()
    //    {
    //        Console.WriteLine("Serving Indian main course.");
    //    }
    //}

    //public class IndianDesert
    //{
    //    public void Serve()
    //    {
    //        Console.WriteLine("Serving Indian desert.");
    //    }
    //}








    // ========================= Solution ============================

    // Step 1: Create Interfaces(What all dishes can do)
    public interface ISoup
    {
        void Serve();
    }

    public interface IMainCourse
    {
        void Serve();
    }

    public interface IDesert
    {
        void Serve();
    }

    // Step 2: Create Chinese Food Family
    public class ChineseSoup : ISoup
    {
        public void Serve()
        {
            Console.WriteLine("Serving Chinese soup.");
        }
    }

    public class ChineseMainCourse : IMainCourse
    {
        public void Serve()
        {
            Console.WriteLine("Serving Chinese main course.");
        }
    }

    public class ChineseDesert : IDesert
    {
        public void Serve()
        {
            Console.WriteLine("Serving Chinese desert.");
        }
    }

    // Step 3: Create Indian Food Family
    public class IndianSoup : ISoup
    {
        public void Serve()
        {
            Console.WriteLine("Serving Indian soup.");
        }
    }

    public class IndianMainCourse : IMainCourse
    {
        public void Serve()
        {
            Console.WriteLine("Serving Indian main course.");
        }
    }

    public class IndianDesert : IDesert
    {
        public void Serve()
        {
            Console.WriteLine("Serving Indian desert.");
        }
    }

    // Step 4: Create Abstract Factory Interface
    public interface IRestaurantFactory
    {
        ISoup CreateSoup();
        IMainCourse CreateMainCourse();
        IDesert CreateDesert();
    }

    // Step 5: Create Concrete Factories(Restaurants)
    public class ChineseRestaurent : IRestaurantFactory
    {
        public ISoup CreateSoup()
        {
            return new ChineseSoup();
        }
        public IMainCourse CreateMainCourse()
        {
            return new ChineseMainCourse();
        }
        public IDesert CreateDesert()
        {
            return new ChineseDesert();
        }
    }

    public class IndianRestaurant : IRestaurantFactory
    {
        public ISoup CreateSoup()
        {
            return new IndianSoup();
        }

        public IMainCourse CreateMainCourse()
        {
            return new IndianMainCourse();
        }

        public IDesert CreateDesert()
        {
            return new IndianDesert();
        }
    }

    // Step 6: Customer Orders Meal(Using Factory)
    //static void Main()
    //    {
    //        Console.WriteLine("=== Welcome to Multi-Cuisine Restaurant ===\n");

    //        // Customer 1: Orders Chinese meal
    //        Console.WriteLine("Customer 1: I want Chinese food");
    //        IRestaurantFactory chineseRestaurant = new ChineseRestaurant();
    //        ServeMeal(chineseRestaurant);

    //        Console.WriteLine("\n" + new string('-', 50) + "\n");

    //        // Customer 2: Orders Italian meal
    //        Console.WriteLine("Customer 2: I want Italian food");
    //        IRestaurantFactory italianRestaurant = new ItalianRestaurant();
    //        ServeMeal(italianRestaurant);

    //        Console.WriteLine("\n" + new string('-', 50) + "\n");

    //        // Customer 3: Orders Indian meal
    //        Console.WriteLine("Customer 3: I want Indian food");
    //        IRestaurantFactory indianRestaurant = new IndianRestaurant();
    //        ServeMeal(indianRestaurant);
    //    }

    //    // This method serves complete meal - all dishes from SAME cuisine
    //    static void ServeMeal(IRestaurantFactory restaurant)
    //    {
    //        // Get all dishes from the same restaurant
    //        ISoup soup = restaurant.CreateSoup();
    //        IMainCourse main = restaurant.CreateMainCourse();
    //        IDesert dessert = restaurant.CreateDesert();

    //        // Serve them
    //        Console.WriteLine("\n🍽️  Serving your meal:\n");
    //        soup.Serve();
    //        main.Serve();
    //        dessert.Serve();

    //        Console.WriteLine("\n✅ Enjoy your meal!");
    //    }
    }