using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class CalculateTotalCreditHours : CourseCalculator
    {
        public override void Visit(CoreCourse item)
        {
            AddCreditHours(item);
        }

        public override void Visit(ElectiveCourse course)
        {
            AddCreditHours(course);
        }

    }
}
