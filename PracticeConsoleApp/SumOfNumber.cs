namespace PracticeConsoleApp;

internal class SumOfNumber
{
    public SumOfNumber()
    {
        Console.WriteLine("Enter number to process it for SUM");
        int number = int.Parse(Console.ReadLine());

        int tempRemainder;
        int sum = 0;

        while (number > 0)
        {
            tempRemainder = number % 10; // get remainder
            number = number / 10; // get Quotient
            sum = sum + tempRemainder;
        }
        Console.WriteLine($"Sum of number is: {sum}");
    }
}
