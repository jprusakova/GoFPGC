namespace Strategy.SingularStrategy
{
    public interface ISortMethod
    {
        int Priority { get; }

        bool IsGoodSorterFor(int[] values);

        int[] Sort(int[] values);
    }
}