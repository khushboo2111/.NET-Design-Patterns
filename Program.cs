using DesignPatterns;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the type of discount:");
        Console.WriteLine("1 - Membership Card");
        Console.WriteLine("2 - Employee Card");
        Console.WriteLine("Any other number - No Card");
        int employeeId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the amount to be paid:");
        int amountToBePaid = int.Parse(Console.ReadLine());

        Customer employee = new Customer(employeeId, amountToBePaid);
        Card card = employee.GetCard(); 
        if (card != null)
        {
            Console.WriteLine("You are eligible for");
            card.GetDiscount();
            Console.WriteLine("Your final amount to be paid is ");
            employee.CalculateAmount();

        }
    }
}