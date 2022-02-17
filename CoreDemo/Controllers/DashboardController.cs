using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());

        //[AllowAnonymous]
        [Authorize]
        public IActionResult Index()
        {
            Context c = new Context();

            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterID == 1).Count().ToString();
            ViewBag.v3 = c.Categories.Count();


            return View();
        }
    }
}
