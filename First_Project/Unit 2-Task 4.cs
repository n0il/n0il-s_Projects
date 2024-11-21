using System;


class Triangle
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the first side: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length of the second side: ");
        double side2= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length of the first side: ");
        double side3= Convert.ToDouble(Console.ReadLine());




        if(side1 <= 0|| side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid values: All sides must be greater than 0!");
            return;
        }
        

        if(side1 + side2 <= side3|| side2 + side3 <= side1 || side3 + side1 <= side2)
        {
            Console.WriteLine("Invalid values: The sum of the lengths of any two sides must be greater than the third side!");
            return;
        }
         

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("This triangle is equilateral.");
        }
        else if(side1 == side2 || side2 == side3 || side3 == side1)
        {
            Console.WriteLine("This triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("This triangle is scalene.");
        }


    }   

    

}
