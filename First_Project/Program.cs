int totalsquares = 64;
long totalgrains = 0;

for (int square = 0; square <= totalsquares; square++)
{
    long grainsonsquare = (long)Math.Pow(2, square -1);
    totalgrains += grainsonsquare;

    Console.WriteLine($"Square {square}: {grainsonsquare} grain(s)");

}
Console.WriteLine($"\nTotal grains on the chessboard: {totalgrains}");