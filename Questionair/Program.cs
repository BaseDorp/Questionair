using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionair
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Questionair by Sam Hirsch";

            User Player = new User();
            Questions Questionair = new Questions();

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
