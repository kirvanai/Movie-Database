using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    internal class Validator
    {

        public static string YesOrNoValidator(string input)
        {
            input = input.ToLower();
            while (input != "y" && input != "n")
            {
                Console.WriteLine("Invalid response. y/n?");
                input = Console.ReadLine();
            }
            return input;

        }

        public static int CategoryValidator(string input)
        {
            int output;
            bool goOn = true;

            while (goOn == true)
            {
                try
                {
                    output = int.Parse(input);
                    if (output < 0 || output > 4)
                    {
                        Console.WriteLine("Please enter 1-4");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        return output;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter category number:");
                    input = Console.ReadLine();
                    continue;
                }
               
            }
            return -1;
        }
    }
}
