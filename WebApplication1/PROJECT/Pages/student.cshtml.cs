using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace PROJECT.Pages
{
    public class studentModel : PageModel
    {
        public List<studentinfo> listofstudents = new List<studentinfo>();
        public void OnGet()
        {
            try
            {
                string connectionstring = "Data Source=LAPTOP-67GUMUCA;Initial Catalog=demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection sqlconn = new SqlConnection(connectionstring);
                sqlconn.Open();
                string QueryString = "select Name,age,Course from StudentInfo ";
                SqlCommand cmd = new SqlCommand(QueryString, sqlconn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studentinfo info = new studentinfo();
                    info.name = reader.GetString(0);
                    info.age = reader.GetInt32(1);
                    info.course = reader.GetString(2);
                    listofstudents.Add(info);

                }
            }
            catch (Exception ex)
            {

            }
        }

    }
    public class studentinfo
    {


        public string name;
        public int age;
        public string course;
    }
}
