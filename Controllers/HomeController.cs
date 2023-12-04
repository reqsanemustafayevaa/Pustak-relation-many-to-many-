using Microsoft.AspNetCore.Mvc;

namespace MVC_project_crud_fileupload.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
