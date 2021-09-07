using System;

namespace DevYou_ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            Console.WriteLine("Enter degree in fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double convertedToCelsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Fahrenheit: {fahrenheit}");
            Console.WriteLine($"Celsius: {convertedToCelsius}");

            //Exercise Two
            Console.Write("Enter Price: ");
            double price = int.Parse(Console.ReadLine());

            Console.Write("Enter Tax: ");
            double tax = int.Parse(Console.ReadLine());

            double taxConverted = tax / 100;
            double totalSalesTax = price * taxConverted;
            double totalCost = price + totalSalesTax;

            Console.WriteLine($"Total with tax is {totalCost:C}");

            //Exercise Three
            Console.Write("Enter Bill Total: ");
            double billTotal = int.Parse(Console.ReadLine());

            Console.Write("Enter percent to tip: ");
            double tipPercent = int.Parse(Console.ReadLine());

            double tipConverted = tipPercent / 100;
            double totalTip = billTotal * tipConverted;

            Console.WriteLine($"Your tip amount is {totalTip:C}");





            //Exercise Four
            Console.Write("Enter Bill Total: ");
            billTotal = int.Parse(Console.ReadLine());

            Console.Write("How many people: ");
            double numOfPeople = int.Parse(Console.ReadLine());

            double totalPerPerson = billTotal / numOfPeople;

            Console.WriteLine($"Each person will pay {totalPerPerson:C}");

            //Challenge

            double money = 100;

            Console.WriteLine($"{money:C}");

        }
    }
}
