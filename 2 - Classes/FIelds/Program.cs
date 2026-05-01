namespace Fields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Brad");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
            
        }
    }
}
