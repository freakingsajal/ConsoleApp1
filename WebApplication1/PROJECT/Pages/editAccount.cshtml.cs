using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
namespace PROJECT.Pages
{
    public class editAccountModel : PageModel
    {
        public CreateAccount acc = new CreateAccount();
        public string errorMsg = "";

        public string successMsg = "";



        public void OnGet()
        {
            string id1 = Request.Query["id"];
            int id = Convert.ToInt32(id1);
           // Console.WriteLine("hello"+id1);

            try
            {
                string connectionstring = "Data Source=LAPTOP-67GUMUCA;Initial Catalog=demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection sqlconn = new SqlConnection(connectionstring);
                sqlconn.Open();
                string QueryString = "select AccountNumber,AccountOpenedDate,Branch from AccountDetails where AccountNumber=@id";
                
                using (SqlCommand cmd = new SqlCommand(QueryString, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    Console.WriteLine(QueryString,id1);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                       
                        acc.accountnumber = reader.GetInt32(0);
                        acc.opendate = reader.GetDateTime(1);
                     
                        acc.branch = reader.GetString(2);
                       


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void OnPost()
        {
            Console.WriteLine("hello"+(Request.Form["accountnumber"]));
            if (Request.Form["accountnumber"].ToString().Length != 0)
            {
                acc.accountnumber = Convert.ToInt64(Request.Form["accountnumber"]);
            }
            acc.branch = Request.Form["branch"];
            if (acc.accountnumber == 0 || acc.branch == "")
            {
                errorMsg = "Account and/or branch number is mandatory";
                return;
            }
           
            if (Request.Form["opendate"].ToString().Length != 0)
            { 
                acc.opendate = Convert.ToDateTime(Request.Form["opendate"]);
                Console.WriteLine(acc.opendate);
            }
            try
            {
                string connectionstring = "Data Source=LAPTOP-67GUMUCA;Initial Catalog=demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection sqlconn = new SqlConnection(connectionstring);
                sqlconn.Open();
                string QueryString = "update AccountDetails set AccountOpenedDate = @opendate, Branch=@Branch where AccountNumber=@id ";
                using (SqlCommand cmd = new SqlCommand(QueryString, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@opendate", acc.opendate);
                    cmd.Parameters.AddWithValue("@Branch", acc.branch);
                    cmd.Parameters.AddWithValue("@id", acc.accountnumber);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            acc.accountnumber = 0;
            acc.branch = "";
            successMsg = "employee updated successfully";

            Response.Redirect("/Account");

        }

    }
        public class CreateAccount
        {
            public long accountnumber;
            public DateTime opendate;
       
        public DateTime lasttxndate;
            public string type;
            public float balance;
            public string branch;


        }

    
}
