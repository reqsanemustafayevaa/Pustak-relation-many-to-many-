using Microsoft.AspNetCore.Mvc;

namespace MVC_project_crud_fileupload.Areas.manage.Controllers
{
    [Area("manage")]
    public class DashBoardController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
