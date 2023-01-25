namespace DayLabs
{
    internal class Prob08
    {
        internal void checkPointInRectangle()
        {
            Console.WriteLine("Enter four space separated parameters as X, Y, Height and Width:");
            string input = Console.ReadLine();

            //string[] dims = input.Split(" ");
            int[] dims = Array.ConvertAll(input.Split(" "), int.Parse);

            Console.WriteLine("Enter the coordinates(X,Y) of the point:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (dims.Length < 4)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                if (x < dims[0]
                    || x > dims[3]
                    || y < dims[1]
                    || y > dims[2])
                {
                    Console.WriteLine("Out of the rectangle");
                }
                else if (x > dims[0] && x < dims[3] && y < dims[1] && y > dims[2]){
                    Console.WriteLine("Inside the rectangle");
                }
                else
                {
                    Console.WriteLine("On the Rectangle");
                }
            }
        }
    }
}