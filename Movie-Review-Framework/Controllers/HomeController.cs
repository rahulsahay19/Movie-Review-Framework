using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Review_Framework.Data;

namespace Movie_Review_Framework.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieReviewDbContext _context;
      

        public HomeController(MovieReviewDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
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

    public interface IHelloWorld
    {

    }

    public class HelloWorld : IHelloWorld
    {

    }
}