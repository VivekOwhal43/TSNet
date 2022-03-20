using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSNet
{
    
    internal class StarPattern
    {
        public void printStar()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered Number is : "+num);
            for(int i = 1; i <=num; ++i)
            {
                Console.WriteLine("*");
                for (int j = 1; j <=i; ++j)
                {
                    Console.Write("* ");
                }
            }
            //Console.WriteLine();
        }
    }
}
