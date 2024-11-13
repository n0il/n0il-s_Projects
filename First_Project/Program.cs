using System;

class Program
{
    static double CalculateSpeedMps(double distance, int hours, int minutes, int seconds)
    {
        double totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;
        return distance / totalTimeInSeconds;
    }
    static double CalculateSpeedKph(double distance, int hours, int minutes, int seconds)
    {
        double distanceInKilometers = distance / 1000;
        double totalTimeInHours = (hours) + (minutes / 60.0) + (seconds / 3600.0);
        return distanceInKilometers / totalTimeInHours;
    }
    static double CalculateSpeedMph(double distance, int hours, int minutes, int seconds)
    {
        double distanceInMiles = distance / 1609.34;
        double totalTimeInHours = (hours) + (minutes / 60.0) + (seconds / 3600.0);
        return (distanceInMiles / totalTimeInHours);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the distance in meters.");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time taken: (hours, minutes, seconds)}");
        Console.Write("Hours ");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Minutes ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Seconds ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        double speedMps = CalculateSpeedMps(distance, hours, minutes, seconds);
        double speedKph = CalculateSpeedKph(distance, hours, minutes, seconds);
        double speedMph = CalculateSpeedMph(distance, hours, minutes, seconds);

        Console.WriteLine($"Speed in meters per second {speedMph:F2}");
        Console.WriteLine($"Speed in kilometers per hour {speedKph:F2}");
        Console.WriteLine($"Speed in miles per hour {speedMph:F5}");

    }
}




