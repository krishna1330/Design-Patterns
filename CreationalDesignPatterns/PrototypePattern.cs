using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CreationalDesignPatterns
{
    // =================== Problem =====================

    //static void Main(string[] args)
    //{
    //    Invitation invitation1 = new Invitation();
    //    invitation1.Name = "JP";
    //    invitation1.Description = "Marriage";
    //    invitation1.Venue = "Vizag";

    //    Invitation invitation2 = new Invitation();
    //    invitation2.Name = "Sravan";
    //    invitation2.Description = "Marriage";
    //    invitation2.Venue = "Vizag";
    //}

    //public class Invitation
    //{
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public string Venue { get; set; }
    //}








    // ===================== Solution =====================
    public class Invitation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Venue { get; set; }

        public Invitation Clone()
        {
            return (Invitation)this.MemberwiseClone();
        }
    }

    //static void Main(string[] args)
    //{
    //        Invitation masterInvitation = new Invitation()
    //        {
    //            Name = "JP",
    //            Description = "Marriage",
    //            Venue = "Vizag"
    //        };

    //        Invitation invitation1 = masterInvitation.Clone();
    //        invitation1.Name = "Sravan";

    //        Invitation invitation2 = masterInvitation.Clone();
    //        invitation2.Name = "Satya";
    //
    //}
}
