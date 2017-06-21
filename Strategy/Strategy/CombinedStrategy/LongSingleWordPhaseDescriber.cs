namespace Strategy.CombinedStrategy
{
    public class LongSingleWordPhaseDescriber : IPhraseDescriber
    {
        public string Describe(string phrase)
        {
            return (phrase.IndexOf(" ") < 0 && phrase.Length > 10)
                       ? "Phrase is a long word"
                       : null;
        }
    }
}