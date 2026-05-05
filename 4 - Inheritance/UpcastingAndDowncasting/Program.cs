using System.Collections;

namespace UpcastingAndDowncasting
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Upcasting
            //var text = new Text();
            //Shape shape = text;     // reference to the same object in memory.  different view

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);

            //           StreamReader reader = new StreamReader(new MemoryStream());

            // Downcasting
            Shape shape = new Text();   // Cannot see the Text fields from the derived class from this object.  Need to downcast!
            Text text = (Text)shape;    // Downcast syntax

            
            
        }
    }
}

// Upcasting    -> conversion from a derived class to a base class
// Downcasting  -> conversion from a base class to a derived class

// Where is this used in the real world??