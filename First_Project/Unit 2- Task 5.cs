/* # Instructions

Reverse a string

For example:
input: "cool"
output: "looc" */
using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string reversed = ReverseString(input);
        Console.WriteLine("Reversed string: " + reversed);
    }   



    public static string ReverseString(string s)
    { 
        char[] cArray = s.ToCharArray();
        Array.Reverse(cArray);
        return new string(cArray);
    }
}