namespace DayLabs
{
    internal class Prob03
    {
        internal void checkVowelOrConsonant()
        {
            Console.WriteLine("Enter a character:");
            char input = (Console.ReadLine() ?? "a").ToLower()[0];
            Console.WriteLine("Entered character is :{0}", (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' ? "vowel" : "consonant"));

        }
    }
}