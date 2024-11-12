using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a string!");
            string input = Console.ReadLine();
            string result = RunLengthEncode(input);
            Console.WriteLine(result);  // Output the result
            Console.ReadKey();
        }

         static string RunLengthEncode(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;  // If the input is empty, return an empty string

            string output = "";  // To store the result
            int count = 1;  // Initialize the count of consecutive characters

            // Loop through the input string starting from the second character
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    // If the current character is the same as the previous one, increment the count
                    count++;
                }
                else
                {
                    // If it's a different character, append the previous character and its count to the result
                    output += input[i - 1] + count.ToString();
                    count = 1;  // Reset the count for the new character
                }
            }

            // Append the last character and its count
            output += input[input.Length - 1] + count.ToString();

            return output;
        }



    }
}