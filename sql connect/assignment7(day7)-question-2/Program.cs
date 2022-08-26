using System.Data;
using System.Data.SqlClient;
//using System.Configuration;
namespace day7;
public class Day7
{
    public static void Main(string[] args)
    {
        string connect = "data source=LAPTOP-67GUMUCA;initial catalog=demo;trusted_connection=true";
        SqlConnection sqlconn = new SqlConnection(connect);
        sqlconn.Open();
        Console.WriteLine("Enter the MovieType");
        String Type = Console.ReadLine();
        SqlCommand cmd = new SqlCommand("select * from GetMovies(@Type);", sqlconn);
        cmd.Parameters.Add("@Type", System.Data.SqlDbType.VarChar).Value = Type;
        Console.WriteLine(cmd.CommandText.ToString());
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString());
        }
        dr.Close();
        sqlconn.Close();

    }
}
