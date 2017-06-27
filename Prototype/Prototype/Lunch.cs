using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Lunch : IPrototype
    {
        public TimeSpan AvailableTime;
        
        public Lunch(string lunchCourse)
        {
            this.LunchCourse = lunchCourse;
        }

        public string LunchCourse { get; }

        public IPrototype Clone()
        {
            return new Lunch(this.LunchCourse);
        }
    }
}
