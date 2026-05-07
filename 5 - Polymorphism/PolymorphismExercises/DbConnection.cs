using System.Collections.Concurrent;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(connectionString))
                    throw new ArgumentNullException("Connection string is null or empty!");
                else
                    ConnectionString = connectionString;
                Timeout = TimeSpan.FromSeconds(60); // times out if the connection does not open within a minute
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
