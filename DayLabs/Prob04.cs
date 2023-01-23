namespace DayLabs
{
    internal class Prob04
    {
        public Prob04() { }

        public void largestSmallestInArray()
        {
            int[] array = new int[5];
            Console.WriteLine("Enter 5 elements:");
            for(int i=0; i<5; i++)
            {
                array[i] = int.Parse(s: Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine(array[0]+"-> min," + array[array.Length-1]+"-> max.");
        }
    }
}
