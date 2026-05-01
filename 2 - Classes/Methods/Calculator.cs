namespace Methods
{
    public class Calculator
    {
        public int Add(params int[] numbers) // varying number of integer parameters without having to initialize an array on each call
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
