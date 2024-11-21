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
            Console.WriteLine(result);  
            Console.ReadKey();
        }

         static string RunLengthEncode(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;  
            string output = "";  
            int count = 1;  

            
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    
                    count++;
                }
                else
                {
                    
                    output += input[i - 1] + count.ToString();
                    count = 1;  // Reset the count for the new character
                }
            }

            
            output += input[input.Length - 1] + count.ToString();

            return output;
        }



    }
}
