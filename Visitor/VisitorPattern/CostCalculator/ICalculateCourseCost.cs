using System;
using System.Collections.Generic;
using System.Text;

namespace CostCalculator
{
    interface ICalculateCourseCost
    {
        int TotalCost { get; }

        void AddCourse(ICourse course);
    }
}
