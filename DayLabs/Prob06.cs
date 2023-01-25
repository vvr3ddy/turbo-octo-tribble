namespace DayLabs
{
    internal class Prob06
    {
        internal void maxOfThreeNumbers()
        {
            Console.WriteLine("Enter three numbers:");
            int[] arr = new int[3];
            for(int i = 0; i<3; i++)
            {
                if(int.TryParse(Console.ReadLine(),out int number))
                {
                    arr[i] = number;
                }
            }
            arr = arr.OrderByDescending(e => e).ToArray();
            Console.WriteLine("Max of the entered numbers is {0}", arr[0]);

        }
    }
}