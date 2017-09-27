using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            int x, y;

            Console.WriteLine("Please enter the first number:");
            x = Convert.ToInt32(Console.ReadLine());// explicit casting 

            Console.WriteLine("Please enter the second number:");
            y = int.Parse(Console.ReadLine());// explicit casting 


            // processing

            int Result = x + y;


            // output 

            Console.WriteLine("The result of adding {0} and {1} is {2}",x,y,Result);


        }
    }
}
