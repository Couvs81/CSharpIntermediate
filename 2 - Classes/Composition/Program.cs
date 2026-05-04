namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}

// Composition - Relationship betweeen too classes that allows one to contain the other
// "Has-a" relationship
// Example:  Car has an Engine
// Code re-use
// Flexibility
// means to loose-coupling

