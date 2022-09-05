using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace PROJECT.Pages
{
    public class AccountModel : PageModel
    {
        public List<accinfo> listofaccounts = new List<accinfo>();
        public void OnGet()
        {
            try
            {
                string connectionstring = "Data Source=LAPTOP-67GUMUCA;Initial Catalog=demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection sqlconn = new SqlConnection(connectionstring);
                sqlconn.Open();
                string QueryString = "select AccountNumber,AccountOpenedDate,AccountType from AccountDetails ";
                SqlCommand cmd = new SqlCommand(QueryString, sqlconn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accinfo info = new accinfo();
                    info.number = reader.GetInt32(0);
                    info.date = reader.GetDateTime(1);
                    info.stringdate = info.date.ToShortDateString();
                    info.type = reader.GetString(2);
                    listofaccounts.Add(info);

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
    public class accinfo
    {


        public int number;
        public DateTime date;
        public string type;
        public string stringdate;
    }
}
