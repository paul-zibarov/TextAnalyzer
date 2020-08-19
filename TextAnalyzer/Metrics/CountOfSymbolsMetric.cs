using System.Linq;

namespace TextAnalyzer.Metrics
{
    public class CountOfSymbolsMetric : ITextMetric
    {
        public string Analyze(string text)
        {
            var countOfSymbols= text.ToCharArray().Count(c => !char.IsWhiteSpace(c));
            return $"Count of symbols: {countOfSymbols}";
        }
    }
}