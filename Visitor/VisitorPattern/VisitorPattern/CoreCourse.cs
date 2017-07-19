using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class CoreCourse : Course
    {
   
        private readonly List<string> _towardMajor;

        public CoreCourse(string name, int hours, params string[] majors) : base(name)

        {
            CreditHours = hours;
            _towardMajor = majors.ToList();
        }

        public override void ReceiveVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public bool GoodTowardMajor(string major)
        {
            return _towardMajor.Contains(major);
        }
    }
}
