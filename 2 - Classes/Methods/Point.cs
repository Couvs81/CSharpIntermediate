namespace Methods
{
    public class Point 
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            // This duplicates code.  there's a better way!
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;

            if (newLocation == null)
                throw new ArgumentNullException("newLocation"); // defensive programming

            Move(newLocation.X, newLocation.Y);  // Cleaner, but by itself does not handle a null object!
        }
    }
}
