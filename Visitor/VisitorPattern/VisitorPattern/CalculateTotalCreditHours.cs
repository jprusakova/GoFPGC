namespace VisitorPattern
{
    public class CalculateTotalCreditHours : CourseCalculator
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
