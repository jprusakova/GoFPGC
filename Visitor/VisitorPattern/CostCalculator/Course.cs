using System;
using System.Collections.Generic;
using System.Text;

namespace CostCalculator
{
    interface ICourse
    {
        string CourseName { get; }
        int CourseBasePrice { get; }
    }
}
