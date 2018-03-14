using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobonatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
//hack comment
            Console.WriteLine("HEllo ROBONATOR!!");
            Console.WriteLine("Second commit");
            Robo robo = new Robo();
            robo.PrintName();
            Console.WriteLine("This text added from another robonator");
            Console.ReadLine();
        }
    }
}
