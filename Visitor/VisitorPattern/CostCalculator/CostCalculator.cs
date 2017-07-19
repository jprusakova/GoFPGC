using System;
using System.Collections.Generic;

namespace CostCalculator
{
    class CostCalculator
    {
        static void Main(string[] args)
        {
            List<ICourse> courseList = new List<ICourse>
            {
                new CollegeCourse("Algebra", 200),
                new CollegeCourse("Data Structures", 600),
                new CertificateCourse("Basket Weaving", 160),
                new CertificateCourse("Azure", 240)
            };

            CalculateCourseCostForDegreeProgram degreeCostCalc = new CalculateCourseCostForDegreeProgram();
            CalculateCourseCostForCertificateProgram certCostCalc = new CalculateCourseCostForCertificateProgram();

            foreach (ICourse course in courseList)
            {
                degreeCostCalc.AddCourse(course);
                certCostCalc.AddCourse(course);
            }
            Console.WriteLine("Cost of courses under a degree program: " + degreeCostCalc.TotalCost);
            Console.WriteLine("Cost of courses under a certificate program: " + certCostCalc.TotalCost);
        }
    }
}