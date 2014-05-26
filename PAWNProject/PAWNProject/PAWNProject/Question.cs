using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNProject
{
    class Question
    {
        private int QuestionNumber{get; set;}
        private string QuestionType { get; set; }
        private string QuestionString { get; set; }
        private Dictionary<int, string> Choices { get; set; }

    }
}
