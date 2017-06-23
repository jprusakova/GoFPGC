namespace Strategy.SingularStrategy
{
    public class CrapSort : ISortMethod
    {
        public int Priority { get; } = int.MaxValue; // this is a last chance sorting method

        public bool IsGoodSorterFor(int[] values)
        {
            // Always return true, because this is the last catch.
            return true;
        }

        public int[] Sort(int[] values)
        {
            // return array sorted.
            return values;
        }
    }
}