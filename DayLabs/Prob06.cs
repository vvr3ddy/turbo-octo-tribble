namespace DayLabs
{
    internal class Prob06
    {
        public Prob06() { }

        public void reverseString(string s)
        {
            char[] strs = s.ToCharArray();
            Array.Reverse(strs);
            string s1 = new string(strs);
            Console.WriteLine("String {0} when reversed is {1}", s, s1);
        }
    }
}