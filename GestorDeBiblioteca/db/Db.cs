namespace GestorDeBiblioteca.db
{
    public class Db
    {
        string connectionString;

        public Db (string server, string username, string password)
        {
            connectionString = $"Server={server};Port=3306;User Id={username};Password={password}";
        }
        
        public void CriandoDB(String)
    }
}