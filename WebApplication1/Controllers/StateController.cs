using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        //1- adding action set session


        public IActionResult setSession()
        {

            HttpContext.Session.SetString("name", "ammar");
            HttpContext.Session.SetInt32("age", 26);
            HttpContext.Session.SetInt32("salary", 26000);


            return Content("session saved ");
        }

       //2- getting session
       public IActionResult getSession()
        {
            string name =HttpContext.Session.GetString("name");
            int? age = HttpContext.Session.GetInt32("age");
            int? salary = HttpContext.Session.GetInt32("salary");

            return Content($" Session name :{name}\n age is : {age} \n salary : {salary}");
        }





    }
}
