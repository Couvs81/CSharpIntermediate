namespace Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\rcouvillon1\Documents\CSharp Intermediate\6 - Interfaces\Extensibility\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
