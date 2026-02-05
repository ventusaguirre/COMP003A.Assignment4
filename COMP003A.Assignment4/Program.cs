using System.Diagnostics.Metrics;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine\n2. View Routine Progress\n3. Exit\n\nEnter choice: ");
            
            int counter = 0;

            string userInput = Console.ReadLine();
          
            do
            {

                switch (userInput) 
                {
                    case "1": 
                        counter++;
                        Console.WriteLine($"{userInput}\nStep {counter} completed.");
                            break;
                }
            }
            while (counter <=5);
           
        }
    }
}
