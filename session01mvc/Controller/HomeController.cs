using Microsoft.AspNetCore.Mvc;
namespace session01mvc.controller

{
    public class HomeController : Controller
    {
        private object id;

        public IActionResult Index()
        {
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = "hello from index";
            //contentResult.ContentType = "text/html";
            //return Content($"product{id},text/html");
            return View();
        }
        public IActionResult redirect()
        {
            RedirectResult  redirectResult =new RedirectResult("https://www.google.com ");
            return redirectResult;

        }
        public IActionResult redirectToAction()
        {
            RedirectToActionResult RedirectToActionResult = new RedirectToActionResult("get", "product", new {id=10});
            return RedirectToActionResult;

        }
        public IActionResult login()
        {
          
            return View();
        }
        public IActionResult aboutus()
        {

            return View();
        }
        public IActionResult contactus()
        {

            return View();
        }
    
    }
}
