using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Threading.Tasks;

namespace Exam
{
    class Player
    {
        string Login { get; set; }

        string Password { get; set; }

        public Player(string a, string b)
        {
            Login = a;
            Password = b;
        }
     

        public void Registr()
        {
            
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Players.xml");
                

            }
            catch
            {


            }
            finally
            {

                if (player != null)
                    player.Close();
            }
           

        }

    }
}
