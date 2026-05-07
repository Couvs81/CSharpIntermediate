namespace PolymorphismExercises
{
    public class DbCommand
    {
        private DbConnection Connection { get; set; }

        private string Instruction { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            try
            {
                if ((connection == null) || String.IsNullOrWhiteSpace(instruction))
                    throw new ArgumentNullException("Null connection or instruction!");
                
                Connection = connection;
                Instruction = instruction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Execute()
        {
            Connection.OpenConnection();
            Console.WriteLine("Executing: {0}", Instruction);
            Connection.CloseConnection();
        }
    }
}
