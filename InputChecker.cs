using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computershare_Code_Test
{
    class InputChecker
    {
        public List<string> UserInputList = new List<string>();
        public string stringInput;
        public int numInRange, num;

        public void CheckStringNotNullOrEmpty(string input)
        {
            while(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Looks like you didn't type in anything, try again!");
                input = Console.ReadLine();
            }

            stringInput = input;
        }

        public void CheckIntExists(string input, bool checkRange)
        {
            //https://codeasy.net/lesson/input_validation
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine("\nThis is not a valid number! Try again\n");
                input = Console.ReadLine();
            }

            if(checkRange == true)
            {
                CheckNumberInRange(input);
            }
        }

        public void CheckNumberInRange(string numAsString)
        {
            numInRange = Convert.ToInt32(numAsString);

            while (numInRange <= 0 || numInRange > 10)
            {
                 Console.WriteLine("\nHey that's not cool. I said between 1 and 10! Try again.\n");
                numAsString = Console.ReadLine();
                CheckIntExists(numAsString, true);
                numInRange = Convert.ToInt32(numAsString);
            }
        }

        public List<string> SplitInputIntoStrings(string inputString)
        {

            UserInputList = inputString.Split(',').ToList();

            return UserInputList;
        }

       public void CheckStringInListAreLegal(List<string> inputString)
        {
            if (inputString != null)
            {
                foreach (string x in inputString)
                {
                    if (x == null)
                    {
                        Console.WriteLine("\nI'm sorry, it looks like you didn't type in anything. Please try again.\n");
                    }
                }

            }
            else
            {
                Console.WriteLine("I'm sorry, it looks like you didn't type in anything. Please try again.");
            }
        }
    }
}
