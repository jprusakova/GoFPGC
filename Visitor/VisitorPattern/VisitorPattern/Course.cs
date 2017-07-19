namespace VisitorPattern
{
    public abstract class Course : IReceiveVisitor
    {
        protected int CreditHours { get; set; }
        public string CourseName { get; }

        protected Course(string name)
        {
            CourseName = name;
        }

        public int GetValue()
        {
            return CreditHours;
        }

        public abstract void ReceiveVisitor(IVisitor visitor);
    }
}
