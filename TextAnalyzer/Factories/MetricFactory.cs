using System.Collections.Generic;
using TextAnalyzer.Enums;
using TextAnalyzer.Metrics;

namespace TextAnalyzer.Factories
{
    public class MetricFactory : IMetricFactory
    {
        public ITextMetric GetMetric(MetricType type)
        {
            switch (type)
            {
                case MetricType.CountOfWords:
                    return new CountOfWordsMetric();
                case MetricType.CountOfParagraphs:
                    return new CountOfParagraphsMetric();
                case MetricType.CountOfPunctuationSymbols:
                    return new CountOfPunctuationSymbolsMetric();
                case MetricType.CountOfSymbols: 
                    return new CountOfSymbolsMetric();
                default: 
                    return null;
            }
        }

        public ICollection<ITextMetric> GetAllMetrics()
        {
            return new List<ITextMetric>()
            {
                new CountOfSymbolsMetric(),
                new CountOfWordsMetric(),
                new CountOfParagraphsMetric(),
                new CountOfPunctuationSymbolsMetric()
            };
        }
    }
}