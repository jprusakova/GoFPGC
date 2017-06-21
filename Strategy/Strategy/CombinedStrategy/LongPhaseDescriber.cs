namespace Strategy.CombinedStrategy
{
    public class LongPhaseDescriber : IPhraseDescriber
    {
        public string Describe(string phrase)
        {
            return (phrase.Length > 100)
                       ? "Phrase is long"
                       : null;
        }
    }
}