using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_App.Models
{
    public class Question
    {
        public string Title { get; set; }
        public List<Option> Options { get; } = new List<Option>();


        public Question()
        {

        }

        public Question(string questionTitle)
        {
            this.Title = questionTitle;
        }

        public void AddOption(Option option)
        {
            Options.Add(option);
        }

    }
}
