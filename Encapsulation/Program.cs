using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Anime a1 = new Anime();
            Anime a2 = new Anime();
            Anime a3 = new Anime();
            a1.Setname("One Piece");
            a2.Setname("One Punch Man");
            a3.Setname("The God of High School");
            Console.WriteLine(a1.Getname());
            Console.WriteLine(a2.Getname());
            Console.WriteLine(a3.Getname());
            Console.ReadKey();
        }
    }
}
