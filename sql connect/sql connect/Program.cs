using System.Data.SqlClient;
namespace day5;
public class Day5
{
    public static void Main(string[] args)
    {
        string connect = "data source=LAPTOP-67GUMUCA;initial catalog=demo;trusted_connection=true";
        SqlConnection sqlconn = new SqlConnection(connect);
        sqlconn.Open();
        Console.WriteLine("after open");
       SqlCommand cmd = new SqlCommand("salaryinformation", sqlconn);
       // SqlCommand cmd = new SqlCommand("select * from EmployeeInformation", sqlconn);
        Console.WriteLine("after result");

        // Console.WriteLine("input aadhar number");

        Console.WriteLine("check the salary");

        //parameters
        //string name = Console.ReadLine();
        //string aadhar = Console.ReadLine();
        string incr = Console.ReadLine();
        float increment = float.Parse(incr);


        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        

        //for parameters
        //cmd.Parameters.Add("@name",System.Data.SqlDbType.VarChar).Value=name;

        cmd.Parameters.Add("@increment", System.Data.SqlDbType.Float).Value = increment;
        //cmd.ExecuteNonQuery();
        SqlDataReader dr = cmd.ExecuteReader();
        Console.WriteLine("table created successfully");
         while (dr.Read())
         {
             Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
            //Console.WriteLine(dr[1].ToString());
            //Console.WriteLine(dr[2].ToString());
           // Console.WriteLine(dr[3].ToString());
         }
        dr.Close();
        sqlconn.Close();

    }
}
