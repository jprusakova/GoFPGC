namespace Strategy.CombinedStrategy
{
    using System.Linq;

    public class PalindromePhaseDescriber : IPhraseDescriber
    {
        public string Describe(string phrase)
        {
            return (phrase == (string)phrase.Reverse())
                       ? "Phrase is a palindrome"
                       : null;
        }
    }
}