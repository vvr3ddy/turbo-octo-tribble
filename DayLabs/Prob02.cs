namespace DayLabs
{
    internal class Prob02
    {
        public Prob02()
        {
        }

        internal void checkPrimeOrNot()
        {
            Console.WriteLine("Enter a number.");
            string input = Console.ReadLine();
            int num = int.TryParse(input,out int number)==true?int.Parse(input):0;
            bool prime = true;
            if (num <= 1 || num % 2 == 0) prime = false;
            if (num == 2) prime = true;
            else
            {
                for (int i = 3; i < Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                    }
                }
            }
            Console.WriteLine("Entered Number {0} is {1}",num,prime?"prime":"not a prime");
        }
    }
}