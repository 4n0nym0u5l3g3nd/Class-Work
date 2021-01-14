using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Football f1 = new Football();
            Football f2 = new Football();
            Football f3 = new Football();
            Football f4 = new Football();
            Football f5 = new Football();
            Football f6 = new Football();
            Football f7 = new Football();
            Football f8 = new Football();
            Football f9 = new Football();
            Football f10 = new Football();
            f1.name = "Jose Bican";
            f2.name = " Cristiano Ronaldo";
            f3.name = "Romario";
            f4.name = "Pele";
            f5.name = "Ferenc Puskas";
            f6.name = "Lionel Messi";
            f7.name = "Gerd Muller";
            f8.name = "Eusebio";
            f9.name = "Tulio Maravilha";
            f10.name = "Ferenc Deak";

            f1.goals = 805;
            f2.goals = 776;
            f3.goals = 772;
            f4.goals = 767;
            f5.goals = 746;
            f6.goals = 742;           
            f7.goals = 735;
            f8.goals = 623;
            f9.goals = 588;
            f10.goals = 576;

            f1.match = 530;
            f2.match = 1071;
            f3.match = 994;
            f4.match = 834;
            f5.match = 754;
            f6.match = 947;
            f7.match = 793;
            f8.match = 856;
            f9.match = 943;
            f10.match = 877;

            f1.Show();
            f2.Show();
            f3.Show();
            f4.Show();
            f5.Show();
            f6.Show();
            f7.Show(); 
            f8.Show(); 
            f9.Show(); 
            f10.Show();
            Console.ReadLine();
        }
    }
}
