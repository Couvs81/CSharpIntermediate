namespace Composition
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {
            _logger.Log("Installing...");
        }
    }
}

// Composition - Relationship betweeen too classes that allows one to contain the other
// "Has-a" relationship
// Example:  Car has an Engine
// Code re-use
// Flexibility
// means to loose-coupling

