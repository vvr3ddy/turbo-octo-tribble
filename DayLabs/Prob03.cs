namespace DayLabs
{
    internal class Prob03
    {
        public Prob03()
        {
        }
        public void arithmeticOperations()
        {
            int i1 = 10;
            double d1 = 11.1;
            float f1 = 3.1415f;

            Console.WriteLine("float+double: "+(f1+d1)+", type="+(f1+d1).GetType());
            Console.WriteLine("int/double: "+i1/d1+", type="+(i1/d1).GetType());
            Console.WriteLine("double/int: "+d1/i1+", type="+(d1/i1).GetType());
            Console.WriteLine("double*int: "+d1*i1+", type="+(d1*i1).GetType());
            Console.WriteLine("double%int: "+d1%i1+", type="+(d1%i1).GetType());
        }
    }
}