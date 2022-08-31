using Microsoft.AspNetCore.Mvc;

namespace assignment1_question2_.controllers
{
    public class HomeController : Controller
    {
        public string books(string subject)
        {
            if (subject == "History")
            {
                return $" History1 \n History2 \n History3 \n History4";
            }
            if (subject == "Mathematics")
            {
                return $" Mathematics1 \n Mathematics2 \n Mathematics3 \n Mathematics4";
            }
            if (subject == "Computer")
            {
                return $" Computer1 \n Computer2 \n Computer3 \n Computer4";
            }
            return $"{subject}";
        }
    }
}
