namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}

// Abstract - indicates a class or member is missing implementation
// Abstract methods are inherently virtual - don't need to specify virtual (compiler error if you do)

// Rules:
// 1.  Do not include implementation
// 2.  If a member is abstract, the containing class must be abstract
// 3.  In a derived class, all abstract members from the base class must be implemented.
// 4.  Abstract classes cannot be instantiated.

// When to use:
//  - when you want to provide some common behaviour while forcing other devs to follow your design
//  - e.g. new shape added, must implement the draw method for that shape.