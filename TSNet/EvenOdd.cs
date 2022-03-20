using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSNet
{
    internal class EvenOdd
    {
        //Console.WriteLine("Enter a Number");
        //
        public void Even_odd()
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number%2 == 0)
            {
                Console.WriteLine(+number+" is Even number");
            }
            else
            {
                Console.WriteLine(+number + " is odd number");
            }
        }
    }
}
