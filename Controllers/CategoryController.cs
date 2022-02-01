using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryRepository());   //cm nesnesi ile bütün methotlara erişim sağlıcam category managerdeki metholara ulaşım sağlıuyoruz
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }

       


    }
}
