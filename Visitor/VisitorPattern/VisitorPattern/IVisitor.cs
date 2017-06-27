namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(CoreCourse course);
        void Visit(ElectiveCourse course);
    }
}
