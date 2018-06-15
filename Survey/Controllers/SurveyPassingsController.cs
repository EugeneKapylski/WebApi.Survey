using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Survey.Models;

namespace Survey.Controllers
{
    [Produces("application/json")]
    [Route("api/SurveyPassings")]
    public class SurveyPassingsController : Controller
    {
        // GET: api/SurveyPassings
        [HttpGet]
        public IEnumerable<SurveyPassing> Get()
        {
            return null;
        }

        // GET: api/SurveyPassings/5
        [HttpGet("{id}")]
        public IEnumerable<SurveyPassing> Get(int id)
        {
            return new List<SurveyPassing>
            {
                new SurveyPassing
                {
                    SurveyId = id,
                    Question = new Question
                    {
                        Id = 1,
                        QuestionType = QuestionType.Text,
                        Title = "How old are you?"
                        
                    },
                    User = new UserNameInfo
                    {
                        FirstName = "John",
                        LastName = "Johnson"
                    },
                    Answer = new Answer
                    {
                        AnswerSettings = "I'm 28 years old"
                    }
                },
                new SurveyPassing
                {
                    SurveyId = id,
                    Question = new Question
                    {
                        Id = 2,
                        QuestionType = QuestionType.Text,
                        Title = "How are you?"
                    },
                    User = new UserNameInfo
                    {
                        FirstName = "John",
                        LastName = "Johnson"
                    },
                    Answer = new Answer
                    {
                        AnswerSettings = "I'm 28 years old"
                    }
                },
                new SurveyPassing
                {
                    SurveyId = id,
                    Question = new Question
                    {
                        Id = 2,
                        QuestionType = QuestionType.Text,
                        Title = "How are you?"

                    },
                    User = new UserNameInfo
                    {
                        FirstName = "James",
                        LastName = "Jameson"
                    },
                    Answer = new Answer
                    {
                        AnswerSettings = "I'm 24 years old"
                    }
                },
                new SurveyPassing
                {
                    SurveyId = id,
                    Question = new Question
                    {
                        Id = 1,
                        QuestionType = QuestionType.Text,
                        Title = "How old are you?"

                    },
                    User = new UserNameInfo
                    {
                        FirstName = "James",
                        LastName = "Jameson"
                    },
                    Answer = new Answer
                    {
                        AnswerSettings = "I'm 24 years old"
                    }
                }
            };
        }
    }
}
