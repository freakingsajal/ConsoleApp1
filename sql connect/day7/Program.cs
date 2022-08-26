using System.Data;
using System.Data.SqlClient;
//using System.Configuration;
namespace day7;
public class Day7
{
    public static void Main(string[] args)
    {
        /*  string connect = "data source=LAPTOP-67GUMUCA;initial catalog=demo;trusted_connection=true";
         // string connect = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
          SqlConnection sqlconn = new SqlConnection(connect);
          sqlconn.Open();
          Console.WriteLine("Enter the subject");
          String subject = Console.ReadLine();
          String QueryString = "select demo.dbo.fn9('"+subject+"')";

          SqlCommand sqlCommand = sqlconn.CreateCommand();
          //SqlCommand cmd = new SqlCommand(QueryString, sqlconn);
          // cmd.CommandType = System.Data.CommandType.StoredProcedure;
          // cmd.Parameters.Add("@subjectName", System.Data.SqlDbType.VarChar).Value = subject;
          sqlCommand.Parameters.Add("@subjectName", System.Data.SqlDbType.VarChar).Value = subject;

          String Grade = sqlCommand.ExecuteScalar().ToString();
        //  Console.WriteLine("The Grade is " + Grade);
          if (Grade==null || Grade==String.Empty)
          {
              Console.WriteLine("subject is not there");
          }
          else
          {
              Console.WriteLine("The Grade is " + Grade);
          }
          sqlconn.Close();*/

       /* string connect = "data source=LAPTOP-67GUMUCA;initial catalog=demo;trusted_connection=true";
         SqlConnection sqlconn = new SqlConnection(connect);
         sqlconn.Open();
         Console.WriteLine("Enter the subject");
        String subject = Console.ReadLine();
        // String QueryString = "select demo.dbo.fn9('" + subject + "')";


         SqlCommand cmd = new SqlCommand("select demo.dbo.fn9(@subjectName)", sqlconn);
         
         cmd.Parameters.Add("@subjectName", System.Data.SqlDbType.VarChar).Value = subject;

        String Grade = cmd.ExecuteScalar().ToString();
         //  Console.WriteLine("The Grade is " + Grade);
         if (Grade == null || Grade == String.Empty)
         {
             Console.WriteLine("subject is not there");
         }
         else
         {
             Console.WriteLine("The Grade is " + Grade);
         }*/

         //OR

      /*  SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            Console.WriteLine(dr[0].ToString());
        }
        dr.Close();*/



       // sqlconn.Close();*/



       string connect = "data source=LAPTOP-67GUMUCA;initial catalog=demo;trusted_connection=true";
        SqlConnection sqlconn = new SqlConnection(connect);
        sqlconn.Open();
        Console.WriteLine("Enter the subject");
        String subject = Console.ReadLine();
        SqlCommand cmd = new SqlCommand("select * FROM fn7(@subjectName)", sqlconn);
        cmd.Parameters.Add("@subjectName", System.Data.SqlDbType.VarChar).Value = subject;
       Console.WriteLine(cmd.CommandText.ToString());
       SqlDataReader dr = cmd.ExecuteReader();
       while(dr.Read())
        {
            Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
        }
       dr.Close();
        



       

        sqlconn.Close();

    }
}