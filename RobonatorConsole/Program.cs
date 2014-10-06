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
            Console.WriteLine("HEllo ROBONATOR!!");
            Console.WriteLine("Second commit");
            Robo robo = new Robo();
            robo.PrintName();
            Console.ReadLine();
        }
    }
}
