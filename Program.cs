using System;

namespace PA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            string input = Console.ReadLine();
            string output = "";
            int counter = 0;
            char countee = ' ';
            try
            {
                while (input != "")
                {
                    if (countee == ' ')
                    {
                        countee = input[0];
                        counter++;
                        input = input.Remove(0, 1);
                    }

                    if (input != "" && countee == input[0])
                    {
                        // Same number being counted
                        counter++;
                        input = input.Remove(0, 1);
                    }
                    else
                    {
                        if (input != "")
                        {
                            // The number must have changed
                            output = output + counter.ToString() + countee;

                            // Reset the boys
                            counter = 0;
                            countee = ' ';
                        }
                    }
                }

                // Covers final iteration
                output = output + counter.ToString() + countee;

                Console.WriteLine(output.ToString());
            } catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
