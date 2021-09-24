using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            Question q1 = new Question("Летают ли пингвины?", 1);
            q1.AddAnswer(q1, "да", "нет", "иногда", "только летом");

            Question q2 = new Question("Летают ли пингвины?", 1);
            q2.AddAnswer(q2, "да", "нет", "иногда", "только летом");

            Question q3 = new Question("Летают ли пингвины?", 1);
            q3.AddAnswer(q3, "да", "нет", "иногда", "только летом");

            Console.WriteLine (q1.ToString());


        }
    }
}
