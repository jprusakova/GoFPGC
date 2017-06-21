namespace Strategy.Examples
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Strategy.SingularStrategy;

    public class AfterSingularStrategy
    {
        private readonly IEnumerable<ISortMethod> sortingMethods;

        /// <summary>
        /// Initializes a new instance of the <see cref="AfterSingularStrategy"/> class.
        /// </summary>
        public AfterSingularStrategy(IEnumerable<ISortMethod> sortingMethods)
        {
            // use IoC to fill this.
            this.sortingMethods = sortingMethods;
        }

        public int[] Sort(int[] values)
        {
            return this.sortingMethods
                .Where(sm => sm.ShouldBeSorter(values))
                .OrderBy(sm => sm.Priority)
                .First()
                .Sort(values);
        }
    }
}
