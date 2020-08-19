using TextAnalyzer.Factories;
using TextAnalyzer.Metrics;

namespace TextAnalyzer
{
    public class TextAnalyzer
    {
        private readonly IMetricFactory _factory;
        
        public TextAnalyzer(IMetricFactory factory)
        {
            _factory = factory;
        }

        public string GetAnalysisResult(string text)
        {
            var metrics = _factory.GetAllMetrics();
            var result = string.Empty;
            
            foreach (var m in metrics)
            {
                result = result + '\n' + m.Analyze(text) ;
            }

            return result;
        }
    }
}