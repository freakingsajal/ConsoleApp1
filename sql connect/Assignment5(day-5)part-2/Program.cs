using System.Data.SqlClient;
using System.Configuration;
namespace day5;
public class Day5
{
    public static void Main(string[] args)
    {
        //string connect = "data source=LAPTOP-67GUMUCA;initial catalog=demo;trusted_connection=true";
        string connect = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(connect);
        sqlconn.Open();

        SqlCommand cmd = new SqlCommand("informationOfStudent", sqlconn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        //parameters
        Console.WriteLine("Enter the year");
        string year = Console.ReadLine();
        int year1 = Convert.ToInt32(year);
       


        //for parameters

        
            //cmd.Parameters.Clear();
            cmd.Parameters.Add("@studentYear", System.Data.SqlDbType.Int).Value = year;
        
        


        SqlDataReader dr = cmd.ExecuteReader();
      //  Console.WriteLine("table created successfully");
        while (dr.Read())
         {
             Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString() + " " 
                 + dr[3].ToString() + " " + dr[4].ToString());
             //Console.WriteLine(dr[1].ToString());
             //Console.WriteLine(dr[2].ToString());
             // Console.WriteLine(dr[3].ToString());
         } 
        dr.Close();
        sqlconn.Close();

    }
}

