namespace Strategy.Examples
{
    using System.Collections.Generic;
    using System.Linq;

    public class BeforeCombinedStrategy
    {
        public string[] DescribePhrase(string phrase)
        {
            var messages = new List<string>();

            if (phrase == (string)phrase.Reverse())
            {
                messages.Add("Phrase is a palindrome");
            }

            if (phrase.Length > 100)
            {
                messages.Add("Phrase is long");
            }

            if (phrase.IndexOf(" ") < 0)
            {
                messages.Add("Phrase is a single word");
                if (phrase.Length > 10)
                {
                    messages.Add("Phrase is a long word");
                }
            }

            if (phrase.Contains("--"))
            {
                messages.Add("Phrase appears to be a quotation");
            }

            return messages.ToArray();
        }
    }
}