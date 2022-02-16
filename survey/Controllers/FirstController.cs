using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey.Models;

namespace Dojo_Survey.Controllers
{
    public class FirstController : Controller
    {
        
        public static User result;
        
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(User usingNewUser)
        {
            if(ModelState.IsValid)
            {
            result= usingNewUser;
            return RedirectToAction("Result");
        }
        else{
            return View ("Index");
        }
        }
        [HttpGet("Result")]
        public IActionResult Result()
        {
           ViewBag.User=result;
            return View("Result");
        }

        [HttpPost("process2")]
        public RedirectToActionResult Submit()
        {
            return RedirectToAction("Index");
        }

    }


}