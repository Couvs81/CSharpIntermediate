namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;
        private string _name;
        
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
                this._name = name;
        }

        public string GetName()
        { 
            return this._name; 
        }   
    }
}
