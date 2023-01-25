namespace DayLabs
{
    internal class Prob09
    {
        internal void checkNumBW1_10()
        {
            Console.WriteLine("Enter a number:");
            if(int.TryParse(Console.ReadLine(),out int number))
            {
                Console.WriteLine(number is >= 1 and <= 10 ? "Number is within 1 to 10":"Number is outside 1 to 10");
            }
        }
    }
}