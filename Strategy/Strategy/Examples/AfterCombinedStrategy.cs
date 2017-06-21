namespace Strategy.Examples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Strategy.CombinedStrategy;

    public class AfterCombinedStrategy
    {
        private readonly IEnumerable<IPhraseDescriber> phraseDescribers;

        /// <summary>
        /// Initializes a new instance of the <see cref="AfterCombinedStrategy"/> class.
        /// </summary>
        public AfterCombinedStrategy(IEnumerable<IPhraseDescriber> phraseDescribers)
        {
            this.phraseDescribers = phraseDescribers;
        }

        public string[] DescribePhrase(string phrase)
        {
            return this.phraseDescribers
                .Select(pd => pd.Describe(phrase))
                .Where(d => d != null)
                .ToArray();
        }
    }
}