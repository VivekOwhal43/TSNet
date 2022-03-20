using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSNet
{
    internal class Student
    {
        string name;
        int roll_number;
        public Student(int roll_number, string name)
        {
            this.roll_number = roll_number;
            this.name = name;
        }

        public void showDetails()
        {
            Console.WriteLine("Roll Number"+roll_number+" Name: "+name);
        }
    }
}
