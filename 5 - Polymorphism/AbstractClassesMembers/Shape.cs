namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Width {  get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public abstract void Draw();    // No definition for drawing a shape - too abstract

        public void Copy()              // Common implementation  across all sub-classes
        {
            Console.WriteLine("Shape copied to clipboard!");
        }
        
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");

        }
    }

    public class Rectangle : Shape 
    {
        public override void Draw()
        {

            Console.WriteLine("Draw a rectangle.");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle.");
        }
    }
}
