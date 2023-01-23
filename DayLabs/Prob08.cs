namespace DayLabs
{
    internal class Prob08
    {
        public Prob08()
        {
        }

        public int findFactorial(int n)
        {
            int factorial = 1;
            if (n < 0)
            {
                return -1;
            }
            if(n == 0) {
                return 1;
            }
            else 
            {
                factorial = n*findFactorial(n-1);
            }
            return factorial;
        }
    }
}