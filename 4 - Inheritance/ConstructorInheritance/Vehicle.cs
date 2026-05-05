namespace ConstructorInheritance
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        /*
        public Vehicle()
        {
            Console.WriteLine("Vehicle initialized.");
        }
        */

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle initialized. {0}", registrationNumber);
        }
    }
}
