namespace StartApp
{
    class Globals
    {
        private static string _connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI";
        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }
    }
}
