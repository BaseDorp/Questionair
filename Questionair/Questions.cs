using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionair
{
    class Questions
    {
        string[] Question = { "Am the life of the party.", "Feel little concern for others.", "Am always prepared.", "Get stressed out easily.", "Have a rich vocabulary.", "Don't talk a lot.", "Am interested in people.", "Leave my belongings around.", "Am relaxed most of the time." };
        string[] Options = { "1. Very Inaccurate", "2. Moderately Inaccurate", "3. Neither", "4. Moderately Accurate", "5. Very Accurate" };

        public Questions()
        {
            Console.Clear();
            //  Loop that shows the next question and prompts for an answer that is stored in the User class
            for (int i = 0; i < Question.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Question[i]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Very Inaccurate\n2. Moderately Inaccurate\n3. Neither\n4. Moderately Accurate\n5. Very Accurate");
                Console.ResetColor();
                User.Answers[i] = Console.ReadLine();
                // Checks to make sure what the user inputed is valid
                while (Convert.ToInt32(User.Answers[i]) < 1 || Convert.ToInt32(User.Answers[i]) > 5)
                {
                    Console.WriteLine("Sorry, this is not a valid answer. Please try again...");
                    User.Answers[i] = Console.ReadLine();
                }
                Console.Clear();
            }
            Console.WriteLine("Thank you " + User.Name + " for taking the Questionair. Your answers are:");

            // prints all the answers the use gave
            for (int i = 0; i < Question.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Question[i]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                // Have to minus one from the answer cuss the array is zero based
                int Feedback = Convert.ToInt32(User.Answers[i]);
                Feedback--;
                Console.WriteLine(Options[Feedback]);
                Console.WriteLine();
                Console.ResetColor();
            }
        }
    }
}
