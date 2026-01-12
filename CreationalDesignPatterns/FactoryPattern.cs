using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalDesignPatterns
{
    // ========================== Problem ==============================

    //public class Stripe
    //{
    //    public void processPayment(decimal amount)
    //    {
    //        Console.WriteLine($"Payment of {amount} done via stripe.");
    //    }
    //}

    //public class Razorpay
    //{
    //    public void ProcessPayment(decimal amount)
    //    {
    //        Console.WriteLine($"Payment of {amount} done via Razorpay.");
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    string paymentType = "Stripe";
    //    decimal amount = 100.00m;

    //    if (paymentType == "Stripe")
    //    {
    //        Stripe stripe = new Stripe();
    //        stripe.processPayment(amount);
    //    }
    //    else if (paymentType == "Razorpay")
    //    {
    //        Razorpay razorpay = new Razorpay();
    //        razorpay.ProcessPayment(amount);
    //    }
    //}





    // ============================ Solution =================================

    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }

    public class Stripe : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} done via Stripe.");
        }
    }

    public class RazorPay : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} done via Razorpay.");
        }
    }

    public class PaymentFactory
    {
        public IPayment CreatePayment(string paymentType)
        {
            switch (paymentType)
            {
                case "Stripe": return new Stripe();
                case "RazorPay": return new RazorPay();
                default: throw new ArgumentException("Invalid payment type.");
            }
        }
    }

    //static void Main(string[] args)
    //{
    //    string paymentType = "Stripe";
    //    PaymentFactory paymentFactory = new PaymentFactory();
    //    IPayment payment = paymentFactory.CreatePayment(paymentType);
    //    payment.ProcessPayment(100);
    //}
}

