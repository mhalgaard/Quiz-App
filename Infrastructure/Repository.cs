using Quiz_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_App.Infrastructure
{
    public interface IRepository
    {
        List<Quiz> Quizzes { get; set; }
        List<Question> Questions { get; set; }
    }
    public class Repository : IRepository
    {
        public List<Quiz> Quizzes { get; set; } = new List<Quiz>();
        public List<Question> Questions { get; set; } = new List<Question>();
        public Repository()
        {
            // Questions
            Question q1 = new Question("Which American rapper is also known as Drizzy?");
            q1.AddOption(new Option("Drake", true, 11));
            q1.AddOption(new Option("D12", false, 12));
            q1.AddOption(new Option("Dizzee Rascal", false, 13));
            q1.AddOption(new Option("Dr. Dre", false, 14));
            Questions.Add(q1);

            Question q2 = new Question("Who released the song 'BUTTERFLY EFFECT' in 2018?");
            q2.AddOption(new Option("Travis Scott", true, 21));
            q2.AddOption(new Option("Tyler, The Creator", false, 22));
            q2.AddOption(new Option("Eminem", false, 23));
            q2.AddOption(new Option("50 Cent", false, 24));
            Questions.Add(q2);

            Question q3 = new Question("What League of Legends team does the midlaner 'Caps' play for?");
            q3.AddOption(new Option("Fnatic", false, 31));
            q3.AddOption(new Option("G2", true, 32));
            q3.AddOption(new Option("TSM", false, 33));
            q3.AddOption(new Option("Splyce", false, 34));
            Questions.Add(q3);

            Question q4 = new Question("What lane in League of Legends, do you usually send 2 players to?");
            q4.AddOption(new Option("Top lane", false, 41));
            q4.AddOption(new Option("Middle lane", false, 42));
            q4.AddOption(new Option("Jungle", false, 43));
            q4.AddOption(new Option("Bottom lane", true, 44));
            Questions.Add(q4);

            // Quizzes
            Quiz quiz1 = new Quiz("Music Quiz", "Questions about HipHop and Rap music", 1);
            quiz1.AddQuestion(q1);
            quiz1.AddQuestion(q2);
            Quizzes.Add(quiz1);

            Quiz quiz2 = new Quiz("Esports Quiz", "Questions about esports", 2);
            quiz2.AddQuestion(q3);
            quiz2.AddQuestion(q4);
            Quizzes.Add(quiz2);
        }
    }
}
