namespace Strategy.SingularStrategy
{
    public class BubbleSort : ISortMethod
    {
        public int Priority { get; } = 1; // should be chosen over other sorters.

        public bool IsGoodSorterFor(int[] values)
        {
            // Weed out conditions bad for bubble sort
            return true;
        }

        public int[] Sort(int[] values)
        {
            // return array sorted.
            return values;
        }
    }
}