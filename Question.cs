using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace Exam
{
    class Question
    {
        string quest { get; set; }

         string [] answer { get; set; }

        int pravotvet { get; set; }

        public Question(string q, int po)
        {
            answer = new string[4];
            quest = q;
            pravotvet = po;
        }
        
        public void AddAnswer(Question q1, string answ1,string answ2, string answ3, string answ4)
        {
           q1.answer[0] = answ1;
           q1.answer[1] = answ2;
           q1.answer[2] = answ3;
           q1.answer[3] = answ4;
        }        

      


        public override string ToString()
        {
            return $"{quest}\n 1. {answer[0]}\n 2. {answer[1]}\n 3. {answer[2]}\n 4. {answer[3]}";
        }



    }
}
