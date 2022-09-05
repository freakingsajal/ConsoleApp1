using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace PROJECT.Pages
{
    public class CreateModel : PageModel
    {
       public CreateAccount acc = new CreateAccount();
        public string errorMsg = "";

        public string successMsg = "";

       

        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (Request.Form["accountnumber"].ToString().Length != 0)
            {
                acc.accountnumber = Convert.ToInt32(Request.Form["accountnumber"]);
            }
            // acc.accountnumber = Convert.ToInt32(Request.Form["accountnumber"]);
            if (Request.Form["opendate"].ToString().Length != 0)
            {
                acc.opendate = Convert.ToDateTime(Request.Form["opendate"]);
            }
            if (Request.Form["lasttxndate"].ToString().Length != 0)
            {

                acc.lasttxndate = Convert.ToDateTime(Request.Form["lasttxndate"]);
            }
            acc.type = Request.Form["type"];
            acc.balance = float.Parse(Request.Form["balance"]);
            acc.branch = Request.Form["branch"];
            if(acc.accountnumber == 0 || acc.opendate==DateTime.MinValue || acc.lasttxndate == DateTime.MinValue)
            {
                errorMsg = "Account number is mandatory";
                return;
            }


            try
            {
                string connectionstring = "Data Source=LAPTOP-67GUMUCA;Initial Catalog=demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection sqlconn = new SqlConnection(connectionstring);
                sqlconn.Open();
                string QueryString = "Insert into AccountDetails values(@AccountNumber,@AccountOpenedDate,@LastTransactionDate,@AccountType,@AccountBalance,@Branch) ";
                using (SqlCommand cmd = new SqlCommand(QueryString, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@AccountNumber", acc.accountnumber);
                    cmd.Parameters.AddWithValue("@AccountOpenedDate", acc.opendate);
                    cmd.Parameters.AddWithValue("@LastTransactionDate", acc.lasttxndate);
                    cmd.Parameters.AddWithValue("@AccountType", acc.type);
                    cmd.Parameters.AddWithValue("@AccountBalance", acc.balance);
                    cmd.Parameters.AddWithValue("@Branch", acc.branch);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
            acc.accountnumber = 0 ;
            acc.opendate = DateTime.MinValue;
            acc.lasttxndate = DateTime.MinValue;
            acc.type = "";
            acc.balance = 0;
            acc.branch = "";
            successMsg = "account added successfully";

            Response.Redirect("/Account");

        }
        public class CreateAccount
        {
           public int accountnumber;
            public DateTime opendate;
            public DateTime lasttxndate;
            public string type;
            public float balance;
            public string branch;


        }
        
    }
}
