namespace DayLabs
{
    internal class Prob05
    {
        internal void checkNumDivisibleby3()
        {
            Console.WriteLine("Enter a number:");
            if(int.TryParse(Console.ReadLine(),out int number))
            {
                Console.WriteLine("The number {0} is {1} by 3",number, (number%3==0?"divisible":"not divisible"));
            }
        }
    }
}