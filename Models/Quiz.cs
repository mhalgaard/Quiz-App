using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_App.Models
{
    public class Quiz
    {
        public int QuizID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Question> Questions = new List<Question>();

        public Quiz()
        {

        }

        public Quiz(string title, string description, int quizID)
        {
            this.Title = title;
            this.Description = description;
            this.QuizID = quizID;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
    }
}
