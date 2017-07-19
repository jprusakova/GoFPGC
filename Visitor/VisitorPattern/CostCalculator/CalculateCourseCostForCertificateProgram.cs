using System;
using System.Collections.Generic;
using System.Text;

namespace CostCalculator
{
    class CalculateCourseCostForCertificateProgram : ICalculateCourseCost
    {
        public int TotalCost { get; private set; }

        public void AddCourse(ICourse course)
        {
            if (typeof(CollegeCourse) == course.GetType())
            {
                AddCourse((CollegeCourse)course);
            }

            if (typeof(CertificateCourse) == course.GetType())
            {
                AddCourse((CertificateCourse)course);
            }
        }

        private void AddCourse(CollegeCourse course)
        {
            TotalCost += 25;
        }

        private void AddCourse(CertificateCourse course)
        {
            TotalCost += course.CourseBasePrice;
        }
    }
}
