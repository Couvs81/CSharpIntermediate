namespace PolymorphismExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("SQLString");
            var oracle = new OracleConnection("OracleString");

            // Exercise 1 testing
            //sql.OpenConnection();
            //oracle.OpenConnection();
            
            //sql.CloseConnection();
            //oracle.CloseConnection();

            // Exercise 2 calls
            var sqlCommand = new DbCommand(sql, "SQL Command");
            var oracleCommand = new DbCommand(oracle, "Oracle Command");

            sqlCommand.Execute();
            oracleCommand.Execute();
        }

        
    }    
}
