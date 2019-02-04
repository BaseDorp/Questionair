using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionair
{
    class User
    {
        public static string Name;
        public static string[] Answers = { "0", "0", "0", "0", "0", "0", "0", "0", "0"};

        public User()
        {
            Console.WriteLine("Please enter your name:");
            Name = Console.ReadLine();
        }
    }
}
