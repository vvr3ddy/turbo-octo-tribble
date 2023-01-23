namespace DayLabs
{
    internal class Program
    {
        static void Main()
        {
            Prob01 prob01 = new();

            Prob02 prob02 = new();
            prob02.declareAndInitializeDataTypes();

            Prob03 prob03 = new();
            prob03.arithmeticOperations();

            Prob04 prob04 = new();
            prob04.largestSmallestInArray();

            Prob05 prob05 = new();
            prob05.findlengthOfString("Hello, World!");

            Prob06 prob06 = new();
            prob06.reverseString("Hello, World!");

            Prob07 prob07 = new();
            prob07.checkLeapYear(1992);

            Prob08 prob08 = new();
            Console.WriteLine("Factorial of {0} is {1}",10,prob08.findFactorial(10));

            Prob09 prob09 = new();
            prob09.generateFibonacciSeries(10);

            Prob10 prob10 = new();
            prob10.areaAndXfOfCircle();
            
        }
    }
}