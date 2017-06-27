using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class PrototypePattern
    {
        static void Main(string[] args)
        {
            Lunch mondayLunch = new Lunch("Turkey Sandwich")
            {
                AvailableTime = new TimeSpan(1, 20, 0)
            };
            Lunch tuesdayLunch = (Lunch)mondayLunch.Clone();
            tuesdayLunch.AvailableTime = new TimeSpan(0, 45, 0);

            Dinner fridayDinner = new Dinner("Steak and potatoes", "Key lime pie");
            fridayDinner.Restaurant = "Fancy Steaks And Drinks";
            fridayDinner.ChefName = "Alexander The Great";

            Dinner saturdayDinner = (Dinner)fridayDinner.Clone();
            saturdayDinner.Restaurant = "Applebees";
        }
    }
}
