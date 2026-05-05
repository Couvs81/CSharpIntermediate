namespace UpcastingAndDowncasting
{
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
}

// Upcasting    -> conversion from a derived class to a base class
// Downcasting  -> conversion from a base class to a derived class