namespace Constructors
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            // Better practice than using overloaded constructors to initialize a class instance is through initialization syntax:
            var customer2 = new Customer
            {
                Id = 1,
                Name = "Rich",
                Orders = new List<Order>()
            };
        }
    }
}
