using System;

class Program
{
    static void Main()
    {
        // Program Structure
        Console.WriteLine("Welcome to Hans Motor Shop!");

        // Variables and Data Types
        int bikesSold = 15;
        double pricePerBike = 499.99;
        string bikeModel = "Mountain Bike";

        // Doing Math
        double totalRevenue = bikesSold * pricePerBike;

        // More on Strings
        Console.WriteLine($"Bike Model: {bikeModel}\nBikes Sold: {bikesSold}\nPrice per Bike: ${pricePerBike}");

        // Concatenation and Interpolation
        string greeting = "Thank you for choosing Hans Motor Shop!";
        Console.WriteLine(greeting);

        // Comparison Operators
        if (bikesSold > 0)
        {
            Console.WriteLine("Bikes are available.");
        }
        else if (bikesSold == 0)
        {
            Console.WriteLine("Out of stock.");
        }
        else
        {
            Console.WriteLine("Invalid bike quantity.");
        }

        // Logical Operators
        bool isDiscountAvailable = true;
        if (bikesSold > 10 && isDiscountAvailable)
        {
            Console.WriteLine("You qualify for a discount!");
        }

        // switch Statement
        string customerRating = "Excellent";
        switch (customerRating)
        {
            case "Excellent":
                Console.WriteLine("Thank you for your excellent rating!");
                break;
            case "Good":
                Console.WriteLine("We appreciate your positive feedback!");
                break;
            default:
                Console.WriteLine("We value your feedback!");
                break;
        }

        // Ternary Operator
        string status = (bikesSold > 0) ? "Available" : "Out of stock";
        Console.WriteLine($"Status: {status}");

        // for Loop
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Assisting customer {i}");
        }

        // while Loop
        int restockCount = 0;
        while (restockCount < 3)
        {
            Console.WriteLine($"Restocking bike inventory. Restock count: {restockCount + 1}");
            restockCount++;
        }

        // break and continue
        for (int i = 2; i <= 12; i++)
        {
            if (i % 2 == 0)
                continue; // Skip even bikes
            Console.WriteLine($"Assisting with bike {i}");
        }

        // Methods, Parameters, and Returning from Methods
        double discountedTotalRevenue = CalculateDiscountedTotal(totalRevenue, 0.1);
        Console.WriteLine($"Discounted Total Revenue: ${discountedTotalRevenue}");
    }

    // Method with parameters and return statement
    static double CalculateDiscountedTotal(double total, double discountRate)
    {
        return total - (total * discountRate);
    }
}
