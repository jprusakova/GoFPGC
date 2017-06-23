namespace Strategy.Examples
{
    public class BeforeSingularStrategy
    {
        public int[] Sort(int[] values)
        {
            if (values.Length < 10) // where quicksort is good.
            {
                // code for quicksort
                return values;
            }

            if (values.Length > 10000) // breaking point between MergeSort and BubbleSort
            {
                // code for mergesort
                return values;
            }

            if (values.Length == 523) // condition where crapsort is better than bubble sort
            {
                // code for crapsort
                return values;
            }

            // code for bubblesort
            return values;
        }
    }
}
