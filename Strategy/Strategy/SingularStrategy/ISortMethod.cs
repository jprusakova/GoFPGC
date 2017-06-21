namespace Strategy.SingularStrategy
{
    public interface ISortMethod
    {
        int Priority { get; }

        bool ShouldBeSorter(int[] values);

        int[] Sort(int[] values);
    }
}