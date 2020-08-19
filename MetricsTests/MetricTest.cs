using System;
using System.Linq;
using NUnit.Framework;
using TextAnalyzer.Enums;
using TextAnalyzer.Factories;


namespace MetricsTests
{
    public class MetricTest
    {
        private MetricFactory Factory { get; set; } = new MetricFactory();

        [Test]
        public void CountOfSymbolsMetricTest()
        {
            var metric = Factory.GetMetric(MetricType.CountOfSymbols);
            string testCase = "test .,!? 1234";
            Assert.AreEqual(12,int.Parse((metric.Analyze(testCase).Split(' ').Last())));
        }
        
        [Test]
        public void CountOfPunctuationSymbolsMetricTest()
        {
            var metric = Factory.GetMetric(MetricType.CountOfPunctuationSymbols);
            string testCase = "Hello, Michael! How are you?";
            Assert.AreEqual(3,int.Parse((metric.Analyze(testCase).Split(' ').Last())));
        }
        
        [Test]
        public void CountOfParagraphsMetricTest()
        {
            var metric = Factory.GetMetric(MetricType.CountOfParagraphs);
            string testCase = "Paragraph1" + Environment.NewLine + Environment.NewLine + "Paragraph2" + Environment.NewLine + Environment.NewLine + "Paragraph3";
            Assert.AreEqual(3,int.Parse((metric.Analyze(testCase).Split(' ').Last())));
        }
        
        [Test]
        public void CountOfWordsMetricTest()
        {
            var metric = Factory.GetMetric(MetricType.CountOfWords);
            string testCase = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at augue erat.";
            Assert.AreEqual(12,int.Parse((metric.Analyze(testCase).Split(' ').Last())));
        }
    }
}