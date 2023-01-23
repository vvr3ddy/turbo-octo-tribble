namespace DayLabs
{
    internal class Prob10
    {
        public void areaAndXfOfCircle()
        {
            Console.WriteLine("Enter the radius of circle:");
            int radius = int.Parse(Console.ReadLine());
            float area = (float)(Math.PI * radius * radius);
            float cFerence = (float)Math.PI*2*(radius);
            Console.WriteLine("The Area and circumference of a circle having radius {0} units are, " +
                "\narea: {1} unit sq., and" +
                "\ncircumference: {2} units",radius,area,cFerence);
        }
    }
}