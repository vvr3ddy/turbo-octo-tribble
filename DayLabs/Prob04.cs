namespace DayLabs
{
    internal class Prob04
    {
        internal void positiveNegativeZero()
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int number))
            {
                Console.WriteLine("Entered Number {0} is {1}",number,(number==0?"zero":number>0?"positive":"negative"));
                
            }

        }
    }
}