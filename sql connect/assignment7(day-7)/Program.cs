using System;
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
        Console.WriteLine("Enter the Amount");
        String AMT = Console.ReadLine();
        int amt1 = Convert.ToInt32(AMT);
        SqlCommand cmd = new SqlCommand("SELECT * FROM GetBalance(@BalanceSlap);", sqlconn);
        cmd.Parameters.Add("@BalanceSlap", System.Data.SqlDbType.Int).Value = amt1;
        // Console.WriteLine(cmd.CommandText.ToString());
        SqlDataReader dr = cmd.ExecuteReader();
      

        if (dr.HasRows)
        {
            Console.WriteLine("AccountNumber " + " CustomerName " + " OpenedDate " + " TransactionDate "
                           + " Balance " + " AadharNumber ");
            while (dr.Read())
            {

                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString()
                   + " " + dr[3].ToString() + " " + dr[4].ToString() + " " + dr[5].ToString());
            }
        }
        else
        {
            Console.WriteLine("Customer not present");
        }
       
        dr.Close();
        sqlconn.Close();

    }
}
