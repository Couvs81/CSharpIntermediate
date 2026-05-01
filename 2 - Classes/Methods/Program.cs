namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int number = int.Parse("abc"); // crashes b/c string does not parse to an int.  Need to use a try/catch block
                                              // to handle the exception.
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed...");

        }

        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at: ({0}; {1})", point.X, point.Y);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at: ({0}; {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                // exception handling prevents crashing!
                Console.WriteLine("An unexpected error occurred");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
        }
    }
}
