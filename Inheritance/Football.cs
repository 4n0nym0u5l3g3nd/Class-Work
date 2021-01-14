using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Football
    {
        public string name;
        public int goals;
        public int match;
        public void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("goals in career: " + goals);
            Console.WriteLine("Match: " + match);
            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
}
