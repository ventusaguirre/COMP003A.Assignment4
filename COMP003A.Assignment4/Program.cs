using System.Diagnostics.Metrics;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine\n2. View Routine Progress\n3. Exit");
            
            int counter = 0;

            while (counter <=5)
            {
                Console.Write("\nEnter choice: ");

                string userInput = Console.ReadLine();

                switch (userInput) 
                {
                    case "1": 
                        counter++;

                        if (counter == 3)
                        {
                            Console.WriteLine("Step 3 is restricted and was skipped.");
                            continue;
                        }

                        if (counter >= 5)
                        {
                            Console.WriteLine("The routine has ended for safety reasons.");
                            continue;
                        }

                        Console.WriteLine($"Step {counter} completed.");
                            break;

                    case "2":
                        Console.WriteLine($"Current progress: {counter} steps completed.");
                        break;

                    case "3":
                        Console.WriteLine("Program ended.");
                        Environment.Exit(0);
                        break;

                    default: Console.WriteLine("Invalid input");
                        break;
                }
                    
            }
     
        }
    }
}
