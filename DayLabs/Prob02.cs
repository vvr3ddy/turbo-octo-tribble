namespace DayLabs
{
    internal class Prob02
    {
        public Prob02()
        {
        }
        public void declareAndInitializeDataTypes()
        {
            int i = 0;
            float f = 3.14f;
            double d = 1.2;
            char ch = 'a';
            string s = "Hello, World!";
            bool b = true;

            Console.WriteLine("int:{0} " +
                "float: {1}" +
                "double: {2}" +
                "char: {3}" +
                "string: {4}" +
                "bool: {5}" +
                "", i, f, d, ch, s, b);
        }
    }
}