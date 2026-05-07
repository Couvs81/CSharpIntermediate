namespace PolymorphismExercises
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            :base(connectionString) { }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL connection...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL connection...");
        }
    }
}
