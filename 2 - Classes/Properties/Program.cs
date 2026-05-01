namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // now that the set method for Birthdate is private,
            // invoke constructor with DateTime parameter
            var person = new Person(new DateTime(1981, 3, 25));
            //person.Birthdate = new DateTime(1981, 3, 25);


            Console.WriteLine(person.Age);
        }
    }
}
