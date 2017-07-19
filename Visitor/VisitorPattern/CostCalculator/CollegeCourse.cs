using System;
using System.Collections.Generic;
using System.Text;

namespace CostCalculator
{
    class CollegeCourse : ICourse
    {
        public string CourseName { get; }
        public int CourseBasePrice { get; }

        public CollegeCourse(string name, int basePrice)
        {
            this.CourseName = name;
            this.CourseBasePrice = basePrice;
        }
    }
}
