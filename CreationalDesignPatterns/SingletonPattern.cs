using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalDesignPatterns
{
    // ======================= Problem ==============================
    //public class Logger
    //{
    //    public void Log(string message)
    //    {
    //        Console.WriteLine($"Log: {message}");
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    Logger log1 = new Logger();
    //    Logger log2 = new Logger();
    //    Logger log3 = new Logger();
    //}





    // ========================= Solution ============================

    public class Logger
    {
        public static Logger _instance = null;

        private Logger()
        {
            Console.WriteLine("Logger created.");
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
