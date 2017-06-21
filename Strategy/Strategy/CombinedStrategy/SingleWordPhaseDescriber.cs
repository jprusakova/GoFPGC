namespace Strategy.CombinedStrategy
{
    public class SingleWordPhaseDescriber : IPhraseDescriber
    {
        public string Describe(string phrase)
        {
            return (phrase.IndexOf(" ") < 0)
                       ? "Phrase is a single word"
                       : null;
        }
    }
}