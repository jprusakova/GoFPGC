using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ElectiveCourse : Course
    {
        public ElectiveCourse(string name) : base(name) 
        {
            CreditHours = 3; 
        }

        public override void ReceiveVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
