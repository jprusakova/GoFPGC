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
            var messages = new List<string>();
            foreach (var describer in this.phraseDescribers)
            {
                var message = describer.Describe(phrase);
                if (message != null)
                    messages.Add(message);
            }

            //return messages.ToArray();


            return this.phraseDescribers
                .Select(pd => pd.Describe(phrase))
                .Where(d => d != null)
                .AsParallel()
                .ToArray();
        }
    }
}