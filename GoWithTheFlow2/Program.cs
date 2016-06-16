using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Flow Chart of a Cat Lady");
            Console.WriteLine("Are you happy?");

            string answer = Console.ReadLine();
                        
            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("End");
                answer = Console.ReadLine();

            }

            else
            {
                Console.WriteLine("Get another cat");

            }
            
            Console.ReadKey();
            
        }
    }
}
