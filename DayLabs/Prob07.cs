namespace DayLabs
{
    internal class Prob07
    {
        public Prob07() { }

        public void checkLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Year {0} is a century leap year",year);
                    }
                    else
                    {
                        Console.WriteLine("Year {0} is not a leap year", year);
                    }
                }
                else
                {
                    Console.WriteLine("Year {0} is a leap year.",year);
                }
            }
            else
            {
                Console.WriteLine("Year {0} is not a leap year", year);
            }
        }
    }
}