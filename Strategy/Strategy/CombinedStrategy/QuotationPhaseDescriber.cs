namespace Strategy.CombinedStrategy
{
    public class QuotationPhaseDescriber : IPhraseDescriber
    {
        public string Describe(string phrase)
        {
            return (phrase.Contains("--"))
                       ? "Phrase appears to be a quotation"
                       : null;
        }
    }
}