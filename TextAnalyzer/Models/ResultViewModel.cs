namespace TextAnalyzer.Models
{
    public class ResultViewModel
    {
        public string Message { get; set; }

        public ResultViewModel(string result)
        {
            Message = result;
        }
    }
}