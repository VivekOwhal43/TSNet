// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace TSNet // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human human = new();
            human.canSpeak();
            //human.canSpeak();
            StarPattern pattern = new StarPattern();
            pattern.printStar();
            
        }
    }
}