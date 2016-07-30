using PartialAndChildTest.Models;
using System.Web.Mvc;

namespace PartialAndChildTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new MyClass
            {
                Title = "Title",
                Body = "Body"
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}