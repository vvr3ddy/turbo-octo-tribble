namespace DayLabs
{
    internal class Prob07
    {
        public Prob07()
        {
        }

        internal void checkPalindrome()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            int j = str.Length-1;
            bool flag = false;

            for(int i = 0; i<str.Length/2; i++)
            {
                if (str[i] == str[j - i])
                {
                    flag = true;
                }
            }
            Console.WriteLine("The entered string \"{0}\" is {1} palindrome",str,flag==true?"a":"not a");
        }
    }
}