using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    class VisitorPattern
    {
        static void Main(string[] args)
        {
            List<Course> courseList = new List<Course>
            {
                new CoreCourse("Algebra", 4, "Math", "CS", "Philosophy"),
                new CoreCourse("Data Structures", 6, "CS"),
                new ElectiveCourse("Basket Weaving"),
                new ElectiveCourse("Charitable Works")
            };


            CalculateTotalCreditHours totalHoursCalculator = new CalculateTotalCreditHours();
            CalculateProgressTowardDegree progressCalculator = new CalculateProgressTowardDegree("Math", 3);

            foreach (Course course in courseList)
            {
                course.ReceiveVisitor(totalHoursCalculator);
                course.ReceiveVisitor(progressCalculator);
            }

            Console.WriteLine("Total credit hours: " + totalHoursCalculator.TotalCreditHours);
            Console.WriteLine("Credit hours toward degree in " 
                + progressCalculator.Major + ": "
                + progressCalculator.TotalCreditHours);
        }



    }
}
