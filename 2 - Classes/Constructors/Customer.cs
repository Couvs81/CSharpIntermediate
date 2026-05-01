namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()                   // Default constructor
        {
            this.Orders = new List<Order>();    // Reference types must be initialized on construction!
        }
        public Customer(int id)             // Constructor with Customer ID initialization
            : this()    // calls the default constructor to initialize reference types.  Saves code repetition
        {
            this.Id = id;

        }
        public Customer(int id, string name) // Constructor with Customer ID & Name initialization
            : this(id) // calls the constructor taking only the id parameter
        { 
            this.Name = name;
        }

    }
}

// The above isn't the best practice, makes the code ugly and hard to maintain
// keep the usage of this method of cascading overloaded constructors to a minimum.
// Better to use object initialization:


