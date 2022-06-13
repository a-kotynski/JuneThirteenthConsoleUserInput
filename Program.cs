using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuneThirteenth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number: ");
            int myNum = Convert.ToInt32(Console.ReadLine()); //it seems Console.ReadLine()
                                                             //accepts user input as string or char
            Console.WriteLine("Your number is: {0}", myNum);
            Console.ReadLine();
        }
    }
}