namespace ConstructorInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)       // If no default constructor in parent class, must initialize with : base
                                            // Need to also take a corresponding parameter in the Car construtor arguments
        {
            Console.WriteLine("Car intialized. {0}", registrationNumber);
        }

       

    }
}
