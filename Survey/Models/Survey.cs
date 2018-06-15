using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Survey.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public QuestionType QuestionType { get; set; }
    }
}
