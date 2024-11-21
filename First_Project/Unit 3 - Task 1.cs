using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] books = new int[] { 2, 2, 2, 1, 1, };

        double totalPrice = CalculateTotalPrice(books);
        Console.WriteLine("Total price: $" + totalPrice.ToString("0.00"));
    }

    static double CalculateTotalPrice(int[] books)
    {
        double bookPrice= 8.00;

        double totalPrice = 0.00;

        while (true)
        {
            int distinctBooks = 0;
            for(int i = 0; i < books.Length; i++)
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

            for(int i = 0;i < books.Length && groupSize > 0; i++)
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