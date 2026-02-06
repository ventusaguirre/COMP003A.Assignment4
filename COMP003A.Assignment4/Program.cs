using System.Diagnostics.Metrics;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine\n2. View Routine Progress\n3. Exit");
            
            int counter = 0; 

            /*
             The following loop exists to repeatedly prompt user input to make a choice from the menu.
             The loop will only run while the counter is less than or equal to the value 5.
            */

            while (counter <=5)
            {
                Console.Write("\nEnter choice: "); 

                string userInput = Console.ReadLine();

                switch (userInput) 
                {
                    
                    case "1": //increases counter by one and outputs which step was completed
                        counter++;

                        if (counter == 3) //skips "step 3" and lets user know why it was skipped
                        {
                            Console.WriteLine("Step 3 is restricted and was skipped.");
                            continue;
                        }

                        if (counter >= 5) //ends the routine if the user attempts to continue after step 4
                        {
                            Console.WriteLine("The routine has ended for safety reasons.");
                            continue;
                        }

                        Console.WriteLine($"Step {counter} completed."); //is skipped if either statement above is true
                            break;

                    case "2": //displays how many steps have been completed
                        Console.WriteLine($"Current progress: {counter} steps completed.");
                        break;

                    case "3": //ends the loop and exits the program
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
