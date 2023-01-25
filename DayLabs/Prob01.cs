namespace DayLabs
{
    internal class Prob01
    {
        public Prob01()
        {
        }

        public void checkEvenOdd()
        {
            Console.WriteLine("Enter a number.");
            string oddEven = int.Parse(Console.ReadLine())%2==0?"Even":"Odd";
            Console.WriteLine("The Entered Number is " + oddEven);
        }
    }
}