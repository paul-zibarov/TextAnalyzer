using System;

namespace TextAnalyzer.Metrics
{
    public class CountOfParagraphsMetric : ITextMetric
    {
        public string Analyze(string text)
        {
            var countOfParagraphs = text.Split(new[] {Environment.NewLine + Environment.NewLine},
                StringSplitOptions.RemoveEmptyEntries).Length;
            return $"Count of paragraphs: {countOfParagraphs}";
        }
    }
}