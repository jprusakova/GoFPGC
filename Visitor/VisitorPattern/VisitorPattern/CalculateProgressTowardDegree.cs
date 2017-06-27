using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class CalculateProgressTowardDegree : CourseCalculator, IVisitor
    {
        public int MaxElectiveHours { get; private set; }
        private int _currentElectiveHours; 

        public CalculateProgressTowardDegree(string major, int maxElectiveHours)
        {
            Major = major;
            CreditHours = 0;
            MaxElectiveHours = maxElectiveHours;
            _currentElectiveHours = 0;
        }

        public string Major { get; private set;  }
        public int CreditHours { get; set; }

        public override void Visit(CoreCourse course)
        {
            if (course.GoodTowardMajor(Major))
            {
                AddCreditHours(course);
            }
        }

        public override void Visit(ElectiveCourse course)
        {
            if (_currentElectiveHours < MaxElectiveHours)
            {
                AddCreditHours(course);
                _currentElectiveHours += course.GetValue();
            }
        }

    }
}
