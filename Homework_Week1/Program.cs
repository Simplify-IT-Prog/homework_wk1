using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string strHello = "Hello World";
            int year = 1492;
            bool isDogOwner = true;
            string currentDate = Convert.ToString (DateTime.Now);
            decimal dollarAmount = 5.45m;
            char aChar = 'X';

            //print variables
            Console.WriteLine(strHello);
            Console.WriteLine("Columbus Sailed the world in {0}.", year);
            Console.WriteLine("It is {0} that I have a dog at home.", isDogOwner.ToString().ToLower ());
            Console.WriteLine("Today is {0}.", currentDate);
            Console.WriteLine("I spent {0} on a cheeseburger.", dollarAmount.ToString("C"));
            Console.WriteLine("{0} marks the spot.", Char.ToUpper(aChar));
            
            Console.ReadLine();
        }
    }
}
