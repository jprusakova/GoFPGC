namespace Strategy.SingularStrategy
{
    public class QuickSort : ISortMethod
    {
        public int Priority { get; } = 1; // efficient sorter under it's conditions.

        public bool ShouldBeSorter(int[] values)
        {
            // is only good with short lists.
            return values.Length < 10;
        }

        public int[] Sort(int[] values)
        {
            // return array sorted.
            return values;
        }
    }
}