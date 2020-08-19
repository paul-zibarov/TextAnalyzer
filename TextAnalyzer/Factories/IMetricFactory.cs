using System.Collections.Generic;
using TextAnalyzer.Enums;
using TextAnalyzer.Metrics;

namespace TextAnalyzer.Factories
{
    public interface IMetricFactory
    {
        ITextMetric GetMetric(MetricType type);
        ICollection<ITextMetric> GetAllMetrics();
    }
}