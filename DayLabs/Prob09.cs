namespace DayLabs
{
    internal class Prob09
    {
        internal void generateFibonacciSeries(int v)
        {
            //algorithm = Fibonacci series = a,b,b+a,c+b+a,....
            int a = 0;
            int b = 1;
            int c = 0;
            for(int i = 1; i < v; i++)
            {
                c =a+b;
                a = b;
                b = c;
            }
            Console.WriteLine("The {0}th term of the fibonacci series is {1}", v, c);
        }
    }
}