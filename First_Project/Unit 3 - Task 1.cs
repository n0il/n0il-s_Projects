using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        List<int> bookS = new List<int>();
        for (int i = 0; i < 5; i++)
        { 
            Console.WriteLine("Please enter the number of books you want:");
            int books = int.Parse(Console.ReadLine());
            bookS.Add(books);
        }

        double totalPrice = CalculateTotalPrice(bookS);
        Console.WriteLine("Total price: $" + totalPrice.ToString("0.00"));
    }

    static double CalculateTotalPrice(List<int> books)
    {
        double bookPrice= 8.00;

        double totalPrice = 0.00;

        while (true)
        {
            int distinctBooks = 0;
            for(int i = 0; i < books.Count; i++)
            {
                if (books[i] > 0)
                {
                    distinctBooks++;
                }
            }

            if (distinctBooks == 0)
            {
                break;
            }


            int groupSize = Math.Min(distinctBooks, 5);

            double discount = 0;
            if (groupSize == 5)
            {
                discount = 0.25;

            }
            else if (groupSize == 4)
            {
                discount = 0.20;
            }
            else if(groupSize == 3)
            {
                discount = 0.10; 
            }
            else if(groupSize == 2)
            {
                discount = 0.05;
            }



            double groupPrice = groupSize * (bookPrice - (bookPrice * discount));
            totalPrice += groupPrice;

            for(int i = 0;i < books.Count && groupSize > 0; i++)
            {
                if (books[i] > 0)
                {
                    books[i]--;
                    groupSize--;
                }
            }
        } 
        return totalPrice;






    }

    

    

}
