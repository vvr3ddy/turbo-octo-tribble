namespace DayLabs
{
    internal class Prob10
    {
        public Prob10()
        {
        }

        internal void checkDigOrLetter()
        {
            Console.WriteLine("Enter a character or a digit:");
            string input = Console.ReadLine();
            if (input.Length != 1)
            {
                Console.WriteLine("Entered either a string or a number not a character or digit. Detection may not be accurate");
            }
            if(int.TryParse(input,out int num))
            {
                Console.WriteLine("Entered value is a digit");
            }
            else
            {
                Console.WriteLine("Entered value is a character")
            }
        }
    }
}