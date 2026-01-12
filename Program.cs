using Design_Patterns.CreationalDesignPatterns;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string paymentType = "Stripe";
            PaymentFactory paymentFactory = new PaymentFactory();
            IPayment payment = paymentFactory.CreatePayment(paymentType);
            payment.ProcessPayment(100);
        }
    }
}