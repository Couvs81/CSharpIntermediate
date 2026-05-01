namespace Properties
{
    public class Person
    {
        // Can use the prop shortcut to autocreat a property and tab through the type and name to specify them
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; private set; } // make the set method read only if the property should be constant.

        // Construdctor(s) and calculated properties should be defined after the automatic properties
        // with a vertical separator in between

        public Person(DateTime birthdate)   // define constructor to initialize with birthdate
        {
            Birthdate = birthdate;
        }
        
        public int Age  // Age should be based on the Birthdate. need to explicitly define the logic instead of
                        // having the compiler generate a default
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }

            // no need for a set method since age is automatically calculated.
        }
    }
}
