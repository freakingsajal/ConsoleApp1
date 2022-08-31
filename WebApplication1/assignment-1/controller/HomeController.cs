using Microsoft.AspNetCore.Mvc;

namespace assignment_1.controller
{
    public class HomeController : Controller
    {
        public string tempCheck(int temp)
        {
            
           if (temp > 96 && temp <= 99)
            {
                return $"normal";
            }
            else if (temp > 99 && temp <= 101)
            {
                return $"Take home care";
            }
            else if (temp > 101)
            {
                return $"Medical attention needed";
            }
            
           return $"check again {temp}";
            
        }



    }
}
