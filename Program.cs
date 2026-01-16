using Design_Patterns.CreationalDesignPatterns;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invitation masterInvitation = new Invitation()
            {
                Name = "JP",
                Description = "Marriage",
                Venue = "Vizag"
            };

            Invitation invitation1 = masterInvitation.Clone();
            invitation1.Name = "Sravan";

            Invitation invitation2 = masterInvitation.Clone();
            invitation2.Name = "Satya";
        }
    }
}