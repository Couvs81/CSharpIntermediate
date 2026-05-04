namespace Inheritance
{
    // Inheritance is a relationship between classes, whereby one class inherits common code from 
    // another class to avoid duplicate code.
    // "Is-a" relationship
    // Example: A Car is a Vehicle
    // Less flexible than Composition
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();

        }
    }
}
