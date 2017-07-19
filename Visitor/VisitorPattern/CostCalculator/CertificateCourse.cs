using System;
using System.Collections.Generic;
using System.Text;

namespace CostCalculator
{
    class CertificateCourse : ICourse
    {
        public string CourseName { get; }
        public int CourseBasePrice { get; }

        public CertificateCourse(string name, int basePrice)
        {
            this.CourseName = name;
            this.CourseBasePrice = basePrice;
        }
    }
}
