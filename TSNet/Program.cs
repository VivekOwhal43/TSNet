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
            Console.WriteLine("Enter your choice from below");
            Console.WriteLine("\n1.Call Human class \n2.Call Star Pattern method \n3.Find number is even or odd \n4.Student information using constructor.");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("You are in case 1");
                    Human human = new();
                    human.canSpeak();
                    break;

                case 2:
                    Console.WriteLine("You are in case 2");
                    StarPattern pattern = new StarPattern();
                    pattern.printStar();
                    break;

               case 3:
                    EvenOdd evenodd = new EvenOdd();
                    evenodd.Even_odd();
                    break;

                case 4:
                    Student student = new Student(5, "Vivek");
                    student.showDetails();
                    break;

                default:
                    Console.WriteLine("Please enter a number between 1 to 4");
                break;
            }
        }
    }
}