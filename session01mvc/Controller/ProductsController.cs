using Microsoft.AspNetCore.Mvc;
namespace session01mvc.controller
{

    public class ProductController : Controller
    {
        public IActionResult Get( int id, string name ,product product)
        //public IActionResult Get([FromHeader] int id)
        {
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = $"product {id}";
            //contentResult.ContentType="object/PDF";
            return Content($"product {id} : { name} ");
        }
        public IActionResult redirect(string v)
        {
            return redirect("https://www.google.com ");
        }
    }
}