using System.Diagnostics.SymbolStore;

namespace TextAnalyzer.Metrics
{
    public class CountOfWordsMetric : ITextMetric
    {
        public string Analyze(string text)
        {
            const char dash = '-';
            const char apostrophe = '\'';
            
            int position = 0;
            int countOfWords = 0;

            while (position < text.Length && (char.IsPunctuation(text[position]) || char.IsWhiteSpace(text[position])))
            {
                position++;
            }

            while (position < text.Length)
            {
                while (position < text.Length && (char.IsLetter(text[position]) || char.IsDigit(text[position]) || char.IsPunctuation(text[position])))
                {
                    position++;
                }
                
                countOfWords++;
                
                while (position < text.Length && (char.IsPunctuation(text[position]) || char.IsWhiteSpace(text[position])))
                {
                    position++;
                }
            }

            return $"Count of words: {countOfWords}";
        }
    }
}