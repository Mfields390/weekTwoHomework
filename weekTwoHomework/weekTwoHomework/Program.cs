using System;

namespace weekTwoHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1 Farenheit to Celcius");

            Console.WriteLine("Please enter degrees in Fahrenheit.");
            double fahrenheit = double.Parse (Console.ReadLine());
            double celsius = (fahrenheit - 32) * .5556;
            Console.WriteLine($"{fahrenheit} degrees Fahrenheit = {celsius} degrees Celsius");
            Console.WriteLine();

            Console.WriteLine("Exercise 2 Sales Tax");

            Console.WriteLine("Please enter your price before taxes.");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your tax percentage.");
            double taxRate = double.Parse(Console.ReadLine());
            double salesTax = (taxRate / 100) * (price);
            double totalPrice = (price + salesTax);
            Console.WriteLine($"Your total cost is {totalPrice:c}");
            Console.WriteLine();

            Console.WriteLine("Exercise 3 Tip Calculator");

            Console.WriteLine("Please give me the total bill.");
            double bill = double.Parse(Console.ReadLine());
            Console.WriteLine("What percentage would you like to tip?");
            double percentTip = double.Parse(Console.ReadLine());
            double tipAmount = (percentTip / 100) * (bill);
            Console.WriteLine($"Your tip total is {tipAmount:c}");
            Console.WriteLine();

            Console.WriteLine("Exercise 4 Bill Dividends");

            Console.WriteLine("Please give me the total bill.");
            double bill2 = double.Parse(Console.ReadLine());
            Console.WriteLine("How many people are contributing?");
            int people = Int32.Parse(Console.ReadLine());
            double amount = (bill2 / people);
            Console.WriteLine($"You each owe {amount:c}");
            Console.WriteLine("Please press enter to exit.");
            Console.ReadLine();





        }
    }
}
