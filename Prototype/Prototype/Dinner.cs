using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Dinner : IPrototype
    {
        public string Restaurant;
        public string ChefName; 

        public Dinner(string mainCourse, string dessert)
        {
            this.MainCourse = mainCourse;
            this.Dessert = dessert; 
        }

        public string MainCourse { get;  }
        public string Dessert { get;  }

        public IPrototype Clone()
        {
            return new Dinner(MainCourse, Dessert);
        }
    }
}
