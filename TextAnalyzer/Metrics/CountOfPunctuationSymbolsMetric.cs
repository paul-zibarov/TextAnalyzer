using System.Linq;

namespace TextAnalyzer.Metrics
{
    public class CountOfPunctuationSymbolsMetric : ITextMetric
    {
        public string Analyze(string text)
        {
            var countOfPunctuationSymbols = text.ToCharArray().Count(c => char.IsPunctuation(c));
            return $"Count of punctuation symbols: {countOfPunctuationSymbols}";
        }
    }
}