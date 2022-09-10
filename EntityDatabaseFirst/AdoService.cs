using BenchmarkDotNet.Attributes;
using Microsoft.Data.SqlClient;

namespace EntityDatabaseFirst
{
    //Connect: verb (không được đặt class bắt verb)
    public class AdoService
    {
        public void Run()
        {
            var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Blog;User ID=sa;Password=Asdf@123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "Select * From Post";
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var title = reader["Title"].ToString();
                        var context = reader["Content"].ToString();

                        Console.WriteLine("{0}=={1}", title, context);
                    }
                }
            }
        }
    }
}
