using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Survey.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public QuestionType QuestionType { get; set; }

        public string AnswerOptions { get; set; }
    }
}
