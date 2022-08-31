using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public string showid(int id)
        {
            return $"The id is = {id}" ;
        }

        public int increament(int id)
        {
            int c = 2;
            int a = c + id;
            return a;
        }
        public string display()
        {
            DateTime dateTime = DateTime.Now;
            if (dateTime.Hour > 12 && dateTime.Hour < 17)
                 return $"good afternoon + {dateTime}";
            if (dateTime.Hour < 12)
                return $"good morning + {dateTime}";
            return $"Time + {dateTime}";


        }
    }
}
