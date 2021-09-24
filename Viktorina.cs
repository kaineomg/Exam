using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace Exam
{
    class Viktorina
    {
        string ThemeName;

        List<Question>q1;

        public Viktorina(List<Question>w,string tn)
        {
            ThemeName = tn;
            q1 = w;

        }


    }
}
