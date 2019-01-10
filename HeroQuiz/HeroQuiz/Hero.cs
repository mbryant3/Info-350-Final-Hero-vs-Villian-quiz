using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroQuiz
{
    class Hero
    {
        private string thezames;
        //constructors
        public Hero()
        {

        }
        public Hero(string what)
        {
            thezames = what;
        }
        //properties
        public string Nzame
        {
            get
            {
                return thezames;
            }
            set
            {
                thezames = value;
            }
        }
        public override string ToString()
        {
            return "Hello: " + thezames;
        }
    }
}
    

    

