using System.Data.SqlClient;
namespace day5;
public class Day5
{
    public static void Main(string[] args)
    {
        string connect = "data source=LAPTOP-67GUMUCA;initial catalog=demo;trusted_connection=true";
        SqlConnection sqlconn = new SqlConnection(connect);
        sqlconn.Open();
       
        SqlCommand cmd = new SqlCommand("passportInformation", sqlconn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;


        //parameters
       /* Console.WriteLine("Enter the id");
        string id = Console.ReadLine();
        int id1 = Convert.ToInt32(id);
        Console.WriteLine("Enter the name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the date");
        DateTime expiryDate = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("enter years of Validity");
        string YearsOfValidity = Console.ReadLine();
        int YearsOfValidity1 = Convert.ToInt32(YearsOfValidity);
        Console.WriteLine("Enter channel name");
        string ChannelName = Console.ReadLine();*/


        //for parameters

        for (int i = 0; i <= 1; i++)
        {
            cmd.Parameters.Clear();
            Console.WriteLine("Enter the id");
            string id = Console.ReadLine();
            int id1 = Convert.ToInt32(id);
            cmd.Parameters.Add("@Number", System.Data.SqlDbType.Int).Value = id1;
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            cmd.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = name;
            Console.WriteLine("Enter the date");
            DateTime expiryDate = Convert.ToDateTime(Console.ReadLine());
            cmd.Parameters.Add("@ExpiryDate", System.Data.SqlDbType.Date).Value = expiryDate;
            Console.WriteLine("enter years of Validity");
            string YearsOfValidity = Console.ReadLine();
            int YearsOfValidity1 = Convert.ToInt32(YearsOfValidity);
            cmd.Parameters.Add("@validity", System.Data.SqlDbType.Int).Value = YearsOfValidity1;
            Console.WriteLine("Enter channel name");
            string ChannelName = Console.ReadLine();
            cmd.Parameters.Add("@channelName", System.Data.SqlDbType.VarChar).Value = ChannelName;
            cmd.ExecuteNonQuery();
        }
        cmd.Parameters.Clear();


        // cmd.ExecuteNonQuery();


        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.CommandText = "fetchPassportInformation";
        SqlDataReader dr = cmd.ExecuteReader();
        //Console.WriteLine("table created successfully");
       while (dr.Read())
        {
            Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString());
            //Console.WriteLine(dr[1].ToString());
            //Console.WriteLine(dr[2].ToString());
            // Console.WriteLine(dr[3].ToString());
        }
       dr.Close();
       sqlconn.Close();

    }
}
