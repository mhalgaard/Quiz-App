using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_App.Models
{
    public class Option
    {
        public int OptionID { get; set; }
        public string OptionText { get; set; }
        public bool CorrectAnswer { get; }


        public Option()
        {

        }

        public Option(string optionText, bool correctAnswer, int optionID)
        {
            this.OptionText = optionText;
            this.CorrectAnswer = correctAnswer;
            this.OptionID = optionID;
        }

    }

}
