using System;
using System.Threading.Channels;

public class CandleSolution
{ 
    public static int Solution(int solutionNumber, int makeNew)
    {
        int totalBurned = solutionNumber;
        int leftovers = solutionNumber;
        
        while(leftovers >= makeNew)
        {
            int newCandles = leftovers / makeNew;
            totalBurned += newCandles;

            leftovers = leftovers % makeNew + newCandles;
        }
        return totalBurned;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter how much solution you possess: ");
        int solutionNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the minimum for making a new candle: ");
        int makeNew = Convert.ToInt32(Console.ReadLine());
        int result = Solution(solutionNumber, makeNew);
        Console.WriteLine($"Total candles burned: {result}.");
    }
}