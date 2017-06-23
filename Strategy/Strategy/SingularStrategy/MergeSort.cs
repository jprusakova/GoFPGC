namespace Strategy.SingularStrategy
{
    public class MergeSort : ISortMethod
    {
        public int Priority { get; } = 3; // there are better sorters.

        public bool IsGoodSorterFor(int[] values)
        {
            // Weed out conditions bad for merge sort
            return true;
        }

        public int[] Sort(int[] values)
        {
            // return array sorted.
            return values;
        }
    }
}