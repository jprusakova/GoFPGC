using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class CourseCalculator : IVisitor
    {
        public int TotalCreditHours { get; protected set; }

        protected void AddCreditHours(Course course)
        {
            TotalCreditHours += course.GetValue();
        }

        public abstract void Visit(CoreCourse course);

        public abstract void Visit(ElectiveCourse course);
    }
}
