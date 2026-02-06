using System.Diagnostics.Metrics;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine\n2. View Routine Progress\n3. Exit");
            
            int counter = 0;

            do
            {
                Console.Write("\nEnter choice: ");

                string userInput = Console.ReadLine();

                switch (userInput) 
                {
                    case "3":
                        Console.WriteLine("Program ended.");
                        break;

                    case "1": 
                        counter++;
                        Console.WriteLine($"Step {counter} completed.");
                            break;

                    case "2":
                        Console.WriteLine($"Current progress: {counter} steps completed.");
                        break;


                    default: Console.WriteLine("Invalid input");
                        break;
                }

                if (counter == 3)
                    Console.WriteLine("Step 3 is restricted and was skipped.");

                if (counter == 5)
                    Console.WriteLine("The program has ended for safety reasons.");
            }
            while (counter <=4);

            
           
        }
    }
}
