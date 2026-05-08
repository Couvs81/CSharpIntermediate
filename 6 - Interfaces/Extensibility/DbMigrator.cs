namespace Extensibility
{
    public partial class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            //Console.WriteLine($"Migration started at {0}", DateTime.Now);
            // details of migrating the database
            _logger.LogInfo("Migration finished at " + DateTime.Now);
            //Console.WriteLine($"Migration finished at {0}", DateTime.Now);

        }
    }
}
